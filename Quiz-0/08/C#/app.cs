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
            string input1 = Console.ReadLine();
            int n = int.Parse(input1);

            Console.Write("Enter M: ");
            string input2 = Console.ReadLine();
            int m = int.Parse(input2);

            for (int i = 0; i < m + n; i++)
            {
                if (fibunacci(i) == n)
                {
                    if (fibunacci(i + 1) == m)
                    {
                        Console.WriteLine("Yes");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        break;
                    }
                }
                if (fibunacci(i) > n || fibunacci(i) > m)
                {
                    Console.WriteLine("NO");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
