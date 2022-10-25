/*
ARELY MARTINEZ 
OCT 25, 2022 11:23AM
THIS PROGRAM WILL MAKE IT SO THAT THE 
USER CAN INPUT TWO NUMBERS AND IT REPSOND 
WITH THE SUM. THEY WOULD INPUT THROUGH 
POSTMAN LIKE 
OUTPUT: https://localhost:7119/input/asking/arely/3PM
OUTPUT: Whats up arely, you woke up at 3pm 

PEER REVIEW: Pedro Castaneda -- Arely did a great job setting up her Endpoints. The route() is properly named. I think you should try adding validation to see if you can get the user to input the correct data type. Other than that your code is clean and you did a great job!  
*/
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
