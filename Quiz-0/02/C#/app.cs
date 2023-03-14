using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static int factorial(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }
            return n * factorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            string input = Console.ReadLine();
            int n = int.Parse(input);
            Console.WriteLine((float)1 / factorial(n));

            Console.ReadKey();
        }
    }
}
