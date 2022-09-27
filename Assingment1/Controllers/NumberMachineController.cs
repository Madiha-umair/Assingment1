using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assingment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// A method which takes a number as input and applies four mathematical operations to it.
        /// </summary>
        /// <example>eg.GET localhost/NumberMachine/10  -> 1, 100, 20, 0 </example>
        /// <example>eg.GET localhost/NumberMachine/-5  -> 1, 25, -10, 0 </example>
        /// <example>eg.GET localhost/NumberMachine/30  -> 1, 900, 60, 0 </example>
        /// <param name="id">an input number to perform four mathematical operations by itself</param>
        /// <returns> Four integers after applying four mathematical operations to integer input</returns>

        public IEnumerable<int> get(int id)
        {
            return new int[] { id/id ,id*id , id+id , id-id};
        }

    }
}
