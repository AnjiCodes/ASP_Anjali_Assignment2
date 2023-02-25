using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASP_Anjali_Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="burger"></param>
        /// <param name="drink"></param>
        /// <param name="side"></param>
        /// <param name="dessert"></param>
        /// <returns></returns>
        //GET: /api/J1/Menu/{burger}/{drink}/{side}/{dessert}
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int[] BurgerCalories = { 461, 431, 420, 0 };
            int[] DrinkCalories = { 130, 160, 118, 0 };
            int[] SideCalories = { 100, 57, 70, 0 };
            int[] DessertCalories = { 167, 266, 75, 0 };
            
            return $"Your total calorie count is {(BurgerCalories[burger-1] + DrinkCalories[drink-1] + SideCalories[side-1] + DessertCalories[dessert-1])}";

        }
    }
}
