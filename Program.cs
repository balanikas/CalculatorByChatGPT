using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Error: The program requires exactly two numeric arguments.");
                return;
            }

            if (!int.TryParse(args[0], out int x) || !int.TryParse(args[1], out int y))
            {
                Console.WriteLine("Error: The arguments must be numeric.");
                return;
            }
            // Your code here
            Calculator<int> calculator = new Calculator<int>();

            int result1 = calculator.Add(1, 2);
            Console.WriteLine(result1); // Outputs 3

            int result2 = calculator.Subtract(4, 2);
            Console.WriteLine(result2); // Outputs 2

            int result3 = calculator.Multiply(3, 2);
            Console.WriteLine(result3); // Outputs 6

            int result4 = calculator.Divide(8, 2);
            Console.WriteLine(result4); // Outputs 4

        }
    }
}