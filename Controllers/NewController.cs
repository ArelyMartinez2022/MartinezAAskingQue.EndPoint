using Microsoft.AspNetCore.Mvc;

namespace day2ApiInput.Controllers;

[ApiController]
[Route("[controller]")]
public class NewController : ControllerBase
{
    [HttpGet]
    [Route("Asking/{name}/{time}")]
    //localHost9000/Input/Name
    public string AskingQuestions(string name, int time)
    {
        return$"Whats up {name}, you woke up at {time} !";
    }

    //return$"This would be my return {var} "
}