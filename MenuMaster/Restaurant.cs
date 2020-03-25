using System;
using System.Collections.Generic;
using System.Text;


namespace MenuMaster
{
    public class Restaurant      //restaurantin sisällä on menu
    {
        public string Name;
        public string Location;
        //private string Name { get; set; }
        //private string Location { get; set; }

        public Restaurant()
        {

        }
        
        public Restaurant(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public Restaurant CreateRestaurant()
        {
            Console.Write("Type restaurant name: ");
            string name = Console.ReadLine();
            Console.Write("Type restaurant location: ");
            string location = Console.ReadLine();

            Restaurant restaurant = new Restaurant(name, location);

            return restaurant;
        }
        


    }
}
