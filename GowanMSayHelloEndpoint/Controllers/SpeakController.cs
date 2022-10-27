/*Madeline Gowan
10-25-2022
Say Hello - Endpoint
We have to create a program that will say hello to us.

Peer reviewed by: Jacob Dekok - The code looks very organized and well put together. The program runs as intended.
*/

using Microsoft.AspNetCore.Mvc;

namespace GowanMSayHelloEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SpeakController : ControllerBase
{

//cheat sheet: https://localhost:xxxx/Speak/Hello/(name)/(good/bad/etc.)

    [HttpGet]
    [Route("Hello/{name}/{doing}")]
    public string Hello(string name, string doing)
    {
        return $"What's up {name}. How are you doing? \n {doing}. \n Well I hope you have a nice day.";
    }
}
