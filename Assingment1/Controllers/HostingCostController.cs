using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web.Http;

namespace Assingment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// 1- Charging a client $5.50 / FN (fortnight = 14 days) for web hosting and maintenance,plus an additional 13% HST.
        /// 2- Take an input number as "id" which represents the number of days which has elapsed since the beginning of the hosting.
        /// 3- Take an integer "fortnight", to find out the number of fortnights to be charged.
        /// 4- To get the chargesForFortnights:Multiply fortnight by chargesOfOnefortnight.
        /// 5- For getting 13% hst: Multiply "charges for fortnights" by 13%(0.13) and store the result in variabale as decimal.
        /// 6- To get the total: just add "hst" and "charges for fortnights" and store the result in variabale as decimal.
        /// 7- Return the total as "result" in string array form.
        ///    <example>GET API/HostingCost/0    ->  “1 fortnights at $5.50/FN = $5.50 CAD”,“HST 13% = $0.72 CAD”,“Total = $6.22 CAD” </example>
        ///    <example>GET API/HostingCost/14    ->  “2 fortnights at $11.00/FN = $5.50 CAD”,“HST 13% = $1.43 CAD”,“Total = $12.43 CAD” </example>
        ///    <example>GET API/HostingCost/15    ->  “2 fortnights at $11.00/FN = $5.50 CAD”,“HST 13% = $1.43 CAD”,“Total = $12.43 CAD” </example>
        ///    <example>GET API/HostingCost/28    ->  “3 fortnights at $16.50/FN = $5.50 CAD”,“HST 13% = $2.14 CAD”,“Total = $18.64 CAD” </example>
        /// </summary>
        /// <param name="id">The input id represents the number of days which has elapsed since the beginning of the hosting</param>
        /// <returns> 3 strings which describe the total hosting cost.
        /// i.e; “1 fortnights at $5.50/FN = $5.50 CAD”,“HST 13% = $0.72 CAD”,“Total = $6.22 CAD” </returns>
        public IEnumerable<string> Get(int id)
        {
            int fortnight= (id/14)+1;
            Decimal chargesOfOneFortnight =(Decimal) 5.50;
            Decimal chargeForFortnights = (Decimal) fortnight*  chargesOfOneFortnight;
            chargeForFortnights= Decimal.Round(chargeForFortnights, 2);
            Decimal HST = (Decimal) (0.13)* chargeForFortnights;
            HST= Decimal.Round(HST, 2);
            Decimal total = (Decimal) HST+ chargeForFortnights;
            total= Decimal.Round(total,2);
            IEnumerable<string> result;
            result = new string[] {"\""+ fortnight+ " fortnights at $5.50/FN= $" + chargeForFortnights +" CAD\"", "\"HST 13% = $"+HST+ " CAD\"","\"Total = $"+total+" CAD\"" };
            return result;
        }
    }
}