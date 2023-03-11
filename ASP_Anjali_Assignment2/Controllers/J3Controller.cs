using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASP_Anjali_Assignment2.Controllers
{
    //I Have tried J3 (2007) Problem
    public class J3Controller : ApiController
    {
        /// <summary>
        /// this method will check whether the user should take the deal or not
        /// </summary>
        /// <param name="a"></param>
        /// <param name="valuesEliminated"></param>
        /// <param name="firstOffer"></param>
        /// <returns>it'll return the average and on basis of that it'll show deal oe no deal</returns>
        [HttpPost]
        public string CalculateDeal(int a, int[]valuesEliminated, int firstOffer)
        {
            int[] DealValues = {100,500,1000,5000,10000,25000,50000,100000,500000,1000000};
            int total = 0;
            int counter = 0;

            if (a < 1 || a > 10)
            {
                return "Invalid input";
            }
            if (firstOffer <=10)
            {
                return "Invalid input";
            }
                
            for (int i = 1; i <= 10; i++)
            {
                if (!valuesEliminated.Contains(i))
                {
                    total += i;
                    counter++;
                }
            }
            int average = total / counter;
            if (firstOffer> average) 
            {
                return "deal";
            }
            else
            {
                return "no deal";
            }

        }
        
    }
}
