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
