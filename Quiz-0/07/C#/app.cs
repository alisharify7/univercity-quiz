using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class Program
    {
        static int fibunacci(int n)
        {
            // this function return a number fibunacci number
            int a = 0, b = 1, c = 1;

            for (int i = 0; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;

        }

        static void Main(string[] args)
        {
            // get number and convert
            Console.Write("Enter N: ");
            string input = Console.ReadLine();
            int n = int.Parse(input);
            Console.WriteLine(string.Format("{0:d}'s number in fibunacci sequences is {1:d}", n, fibunacci(n)));

            Console.ReadKey();
        }
    }
}
