using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            string input = Console.ReadLine();
            int n = int.Parse(input);

            int res = 1;
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
                sum += (float)i / res;
                if (i == n)
                {
                    Console.Write(string.Format("{0:d}/{0:d}! = ", i));
                }
                else
                {
                    Console.Write(string.Format("{0:d}/{0:d}! + ", i));
                }
            }
            Console.Write(sum);
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}
