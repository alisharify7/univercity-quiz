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
            int sum = 0;
            List<int> numbers = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                res *= i;
                numbers.Add(res);
                sum += res;
                if (i == n)
                {
                    Console.Write(string.Format("{0:d}! = ", i));
                }
                else
                {
                    Console.Write(string.Format("{0:d}! + ", i));
                }
            }
            Console.Write(sum);
            Console.WriteLine();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == numbers.Count)
                {
                    Console.Write(string.Format("{0:d} = ", numbers[i]));
                }
                else
                {
                    Console.Write(string.Format("{0:d} + ", numbers[i]));
                }
            }
            Console.Write(sum);
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
