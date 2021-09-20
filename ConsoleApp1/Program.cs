// Programmer: Raleigh Sullivan
// Project: Conversation
// Date: Sept. 20 2021
// Description: Converting KM to Miles

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring the variable increment to be use for KM
            int increment = 0;
            // The loop statement with the condition
            while(increment < 10 || increment > 25)
                {
                Console.WriteLine("This program will display a table of conversions from KM to Miles");
                Console.WriteLine();
                Console.WriteLine("Enter a value to use as Kilometer increment (between 10 to 25)");
                string input = Console.ReadLine();
                increment = int.Parse(input);
                
            }
            // End of loop

            // Display the increment value selected
            Console.WriteLine(String.Format("Kilometer Increment Value selected = {0}", increment));

            // Initiating the conversations
            Console.WriteLine("Executing conversations");
            Console.WriteLine("----------------");

            // Displaying the headers
            Console.WriteLine("Kilometers          Eqiv Miles");

            // Declaring the variables to be used in the conversation process
            int km = 0;
            double miles = 0;
            double convrates = 0.621371;

            // Printing the first row of values
            Console.WriteLine("");
            Console.WriteLine("0 km          0 miles");

            // The conversation process
            do
            {
                km += increment; // Incrementing the km
                miles = km * convrates; // Converting km to miles
                Console.WriteLine(String.Format("{0} km          {1} miles", km, miles)); // Printing the actual lines of values

            } while (km + increment
            <= 200); // Setting the condition (km must not exceed 200)

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            
            

        }
    }
}
