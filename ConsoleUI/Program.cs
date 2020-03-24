using System;
using System.Collections.Generic;
using MenuMaster;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)         //täällä luodaan restaurant, menu, ruoka ja juoma
        {

            List<Restaurant> list = new List<Restaurant>();
            Restaurant restaurant = new Restaurant();


            restaurant = new Restaurant();

            Console.Write("Type restaurant name: ");
            string resName = Console.ReadLine();
            Console.Write("Type restaurant location: ");
            string resLocation = Console.ReadLine();

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
