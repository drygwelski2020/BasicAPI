
using System;
using Microsoft.AspNetCore.Mvc;

namespace BasicAPI.Controllers
{
    // We speak JSON here!
    [ApiController]
    // This endpoint is at /HelloWorld because
    // our controller class name is HelloWorldController
    // and we chop off the name 'Controller' to get the name
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        // This is the code to run for a GET
        // ... and there is no other part of that URL
        //
        // If you do GET https://localhost:5001/HelloWorld
        // you'll get *THIS* code
        [HttpGet]
        public string SayHello(string who = "World")
        {
            // This is the response
            // string whoOrWorld;


            // If whoOrWorld is null, use "World". Otherwise, use the query response from the user
            //string whoOrWorld = who == null ? "World" : who;

            return $"Hello {who}! It is currently {DateTime.Now}. Have a great day.";
        }
    }
}