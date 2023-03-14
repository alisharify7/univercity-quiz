using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static int calc_sum(int a, int b)
        {
            int res = 0;
            for (int i = 0; i < a; i++)
            {
                res += b;
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            string input1 = Console.ReadLine();
            int a = int.Parse(input1);

            Console.Write("Enter First Number: ");
            string input2 = Console.ReadLine();
            int b = int.Parse(input2);

            Console.WriteLine(calc_sum(a, b));
            Console.ReadKey();
        }
    }
}
