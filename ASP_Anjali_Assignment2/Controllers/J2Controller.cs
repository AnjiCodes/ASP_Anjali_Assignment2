using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASP_Anjali_Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        // GET: /api/J2/DiceGame/{m}/{n}
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            int i;
            int j;
            int counter = 0;
            for(i = 1; i <= m; i++)
            {
                if (i > 10)
                {
                    break;
                }

                for(j = 1; j <= n; j++)
                {
                    if(i + j == 10)
                    {
                        counter++;
                        break;
                    }
                }
            }

            return $"There are {counter} total ways to get the sum 10.";
        }
    }
}
