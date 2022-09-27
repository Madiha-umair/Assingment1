using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assingment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Returns the square of the input number.
        /// </summary>
        /// <example>eg. GET localhost/Square/2   -> 4 </example>
        /// <example>eg. GET localhost/Square/-2   -> 4 </example>
        /// <example>eg. GET localhost/Square/10   -> 100 </example>
        /// <param name="id">input number to get squared</param>
        /// <returns>square of the integer input</returns>

        public int Get(int id)
        {
            return (id*id);
        }
        
    }
}
