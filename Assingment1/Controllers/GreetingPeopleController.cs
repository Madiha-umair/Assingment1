using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assingment1.Controllers
{
    public class GreetingPeopleController : ApiController
    {
        /// <summary>
        /// Returns the string “Greetings to (input number) people!”
        /// </summary>
        /// <param name="id">input number to be mention number of people in string</param>
        /// <example>eg. GET api/GreetingPeople/3  -> Greetings to 3 people! </example>
        /// <example>eg. GET api/GreetingPeople/6  -> Greetings to 6 people! </example>
        /// <example>eg. GET api/GreetingPeople/0  -> Greetings to 0 people! </example>
        /// <returns>A string"Greeting to {Integer} people"</returns>
        public string Get(int id)
        {
            return ("Greetings to "+ (id) +" people!");
        }
    }
}
