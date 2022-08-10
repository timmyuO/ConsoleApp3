using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your vehicle type");
            string vehicletype = Console.ReadLine();
            Console.WriteLine("Are you a member of the union");
            bool Isunion = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many trips did you take");
            int trips = Convert.ToInt32(Console.ReadLine());
            int tolls;
            if (vehicletype.ToLower() == "keke")
            {
                int toll = 300;
                tolls = toll;
            }
            else if (vehicletype.ToLower() == "bus")
            {
                int toll = 500;
                tolls = toll;
            }
            else if (vehicletype.ToLower() == "minibus")
            {
                int toll = 700;
                tolls = toll;

            }
            else if (vehicletype.ToLower() == "okada")
            {
                int toll = 100;
                tolls = toll;
            }
            else
            {
                Console.WriteLine("The vehicle type  is an Invalid input");
            }
            if (Isunion)
            {
                int final = tolls *  
            }


        }
    }
}
