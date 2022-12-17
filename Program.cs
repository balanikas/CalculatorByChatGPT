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

            int result1 = calculator.Add(x, y);
            Console.WriteLine(result1);

            int result2 = calculator.Subtract(x, y);
            Console.WriteLine(result2);

            int result3 = calculator.Multiply(x, y);
            Console.WriteLine(result3);

            int result4 = calculator.Divide(x, y);
            Console.WriteLine(result4);

        }
    }
}