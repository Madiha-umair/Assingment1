using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assingment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This method returns a  string "Hello World!" when receiving a post request.
        /// </summary>
        /// <example>eg. POST api/Greeting </example>
        /// <returns>“Hello World!”</returns>
        public string Post()
        {
            return ("Hello World!");
        }
    }
}
