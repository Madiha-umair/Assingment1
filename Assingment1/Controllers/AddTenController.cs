using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assingment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Returns 10 more than the input number.
        /// </summary>
        /// <example>eg. GET localhost/AddTen/21   -> 31 </example>
        /// <example>eg. GET localhost/AddTen/0   -> 10 </example>
        /// <example>eg. GET localhost/AddTen/-9   -> 1 </example>
        /// <param name="id">input number to be added in 10</param>
        /// <returns>10 more than the ineger input </returns>
        public int Get(int id)
        {
            return (id+10);
        }
    }
}
