using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMaster
{
    public class Food
    {
        public string Name;
        public string Detail;
        public string Cost;
        //public int Name { get; set; }
        //public int Detail { get; set; }
        //public int Cost { get; set; }

        public Food()
        {

        }


        public Food(string name, string detail, string cost)
        {
            Name = name;
            Detail = detail;
            Cost = cost;
        }
        

        public Food CreateFood()
        {
            Console.Write("Type food name: ");
            string name = Console.ReadLine();
            Console.Write("Type food details: ");
            string detail = Console.ReadLine();
            Console.Write("Type food cost: ");
            string cost = Console.ReadLine();

            Food food = new Food(name, detail, cost);

            return food;
        }

    }
}
