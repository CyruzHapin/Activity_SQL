using System;
using System.Collections.Generic;
using Model;
using BusinessLayer;
using DataLayer;

namespace RestaurantMenu
{
    public class Program
    {
        static void Main(string[] args)
        {

            SqlDbData.AddUser("Porkchop", "Meal 8", "119 Pesos", "Sprite");          

            GetUsers();
        }

        public static void GetUsers()
        {
            List<Menu> infoFromDB = SqlDbData.GetUsers();

            foreach (var item in infoFromDB)
            {
                Console.WriteLine(item.Description);
                Console.WriteLine(item.Meal);
                Console.WriteLine(item.Price);
                Console.WriteLine(item.Drinks);
            }
            //Console.WriteLine("What meal do you want to see?");
            //Console.WriteLine("Enter Meal number: ");
            // string meal = Console.ReadLine();
            //  DisplayMealNumInfo(meal);
            // }

            //    public static void DisplayMealNumInfo( string stringmeal)
            //   {
            //  Services businessServices = new Services();
            //   List<Menu> foundMenus = businessServices.GetMenusByMealNum(stringmeal);

            //   if(foundMenus.Count > 0)
            //  {
            //   Console.WriteLine($"Found meal for {stringmeal}(s):");
            //   for (int i = 0; i < foundMenus.Count; i++)
            //  {
            //  Console.WriteLine($"Description: {foundMenus[i].Description}");
            //   Console.WriteLine($"Meal: {foundMenus[i].Meal}");
            //  Console.WriteLine($"Price: {foundMenus[i].Price}");
            //    Console.WriteLine($"Drinks: {foundMenus[i].Drinks}");
            //  }
            //    }
            // else
            //     {
            //   Console.WriteLine("No Meal Information for the specified Meal Number");
            //    }
        }
    }

}
