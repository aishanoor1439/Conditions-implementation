using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions_implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taking input from the user
            Console.WriteLine("Enter value for x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for y:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for z:");
            int z = int.Parse(Console.ReadLine());

            // Condition: x > y > z
            if (x > y && y > z)
            {
                Console.WriteLine("Condition a) x > y > z is true.");
            }
            else
            {
                Console.WriteLine("Condition a): x > y > z is false.");
            }

            // Condition: x and y both are less than 0
            if (x < 0 && y < 0)
            {
                Console.WriteLine("Condition b) is true. Both x and y are less than 0.");
            }
            else if (x >= 0)
            {
                Console.WriteLine("x is not less than 0. Hence, Condition b) is false.");

            }
            else if (y >= 0)
            {
                Console.WriteLine("y is not less than 0. Hence, Condition b)  is false.");
            }
            else
            {
                Console.WriteLine("Condition b) is false. Both x and y are greater than 0.");
            }
           

            // Condition: Neither x nor y is less than 0
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Condition c) is true. Neither x nor y is less than 0.");
            }
               else if (x < 0)
                {
                    Console.WriteLine("x is less than 0. Hence, Condition c) is false.");
                }
               else if (y < 0)
                {
                    Console.WriteLine("y is less than 0. Hence, Condition c) is false.");
                }
             else
            {
                Console.WriteLine("Condition c) is false. Both x and y are less than 0.");
            }

            // Condition: x is equal to y but not equal to z
            if (x == y && x != z)
            {
                Console.WriteLine("Condition d) is true. x is equal to y but not equal to z.");
            }
                else if(x != y)
                {
                    Console.WriteLine("x is not equal to y. Hence, Condition d) is false.");
                }
                else if(x == z)
                {
                    Console.WriteLine("x is equal to z. Hence, Condition d) is false.");
                }
            else
            {
                Console.WriteLine("Condition d) is false. x equal to z but not eaual to y.");
            }
        }
    }
}
