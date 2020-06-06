using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace BasicAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiceController : ControllerBase
    {
        // This is a GET request, but there is more in the URL
        //
        //        This is the more of the URL
        //        |
        //        |
        //        v
        [HttpGet("{sides}")]
        //
        // Examples
        //   GET /Dice/6   <== 'sides' equals 6
        //   GET /Dice/20  <== 'sides' equals 20
        public List<int> Roll(int sides, int count = 1)
        //               ^          ^
        //             (url param)  (query param)
        {
            var randomNumberGenerator = new Random();

            var rolls = new List<int>();

            // Do this loop *count* times
            for (var rollNumber = 0; rollNumber < count; rollNumber++)
            {
                // Generate a random number between 1 and 'sides' (inclusive)
                // example: between 1 and 6
                // example: between 1 and 20

                // Must add one due to index staring at zero
                var roll = randomNumberGenerator.Next(sides) + 1;

                // Add that roll to our List
                rolls.Add(roll);
            }

            // Return the List of rolls
            return rolls;

        }
    }
}