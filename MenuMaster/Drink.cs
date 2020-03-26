using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMaster
{
    public class Drink
    {
        public string Name;
        public string Cost;
        //public int Name { get; set; }
        //public int Cost { get; set; }

        public Drink()
        {

        }

        public Drink(string name, string cost)
        {
            Name = name;
            Cost = cost;
        }

        public Drink CreateDrink()
        {
            Console.WriteLine("Type drink name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Type drink cost: ");
            string cost = Console.ReadLine();

            Drink drink = new Drink(name, cost);

            return drink;
        }

    }
}
