using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Lab
{
    internal class Validator
    {
        public static double getUserRadius()
        {
            double x = 0;
            while (true)
            {
                try
                {
                    //get user input
                    Console.WriteLine("Please enter a radius");
                    x = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return x;
        }

        public static bool getContinue()
        {
            bool result = true;

            while (true)
            {
                Console.WriteLine("Do you want to continue? y/n");
                string choice = Console.ReadLine();
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Not valid");
                }
            }

            return result;
        }
    }
}
