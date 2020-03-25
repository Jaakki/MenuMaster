using System;
using System.Collections.Generic;
using MenuMaster;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)         //täällä luodaan restaurant, menu, ruoka ja juoma
        {
            Restaurant restaurant = new Restaurant();
            restaurant.CreateRestaurant();

            List<Restaurant> list = new List<Restaurant>();

            Console.Write("Type food name: ");
            string fodName = Console.ReadLine();
            Console.Write("Type food details: ");
            string fodDetail = Console.ReadLine();
            Console.Write("Type food cost: ");
            string fodCost = Console.ReadLine();

            Console.Write("Type drink details: ");
            string driName = Console.ReadLine();
            Console.Write("Type food cost: ");
            string driCost = Console.ReadLine();



        }
    }
}
