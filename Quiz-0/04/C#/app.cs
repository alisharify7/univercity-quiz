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
            for (int i = 1; i <= n; i++)
            {
                res *= i;
                if (res == n)
                {
                    Console.WriteLine(string.Format("{0:d}! = {1:d}", i, res));
                    break;
                }
                else if (res > n)
                {
                    Console.WriteLine("Not Found");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
