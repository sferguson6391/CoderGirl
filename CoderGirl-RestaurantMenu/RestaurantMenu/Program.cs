using RestaurantMenu.Model;
using System;
using System.IO;

namespace RestaurantMenu
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Menu menu = new Menu();

            int counter = 0;
            string line;
            StreamReader file = new StreamReader(@"C:\Users\Jared\Source\Repos\CoderGirl-RestaurantMenu\RestaurantMenu\Menu.txt");
            while ((line = file.ReadLine()) != null)
            {
                MenuItem item = new MenuItem();
                string[] lineValues = line.Split(',');
                item.AddedOn = Convert.ToDateTime((lineValues[0]));
                item.Category = Convert.ToString(lineValues[1]);
                item.Description = Convert.ToString(lineValues[2]);
                item.Name = Convert.ToString(lineValues[3]);
                item.Price = Convert.ToDecimal(lineValues[4]);
                counter++;
            }

            Console.WriteLine(menu);
            Console.ReadLine();

        }
    }
}