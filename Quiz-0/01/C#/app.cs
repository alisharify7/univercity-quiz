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
            Console.Write("Enter n: ");
            string input = Console.ReadLine();
            int n = int.Parse(input);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(string.Format("2^{0} = {1}" , i, Math.Pow(2,i)));
            }

            Console.ReadKey();
        }
    }
}
