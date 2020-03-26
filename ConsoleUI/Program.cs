using System;
using System.Collections.Generic;
using MenuMaster;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)         //täällä luodaan restaurant, menu, ruoka ja juoma
        {
            Console.WriteLine("0 to exit!");
            Console.WriteLine("1 to create a new Restaurant");
            Restaurant restaurant = new Restaurant();
            restaurant.CreateRestaurant();

            Food food = new Food();
            food.CreateFood();

            Drink drink = new Drink();
            drink.CreateDrink();
        }
    }
}
