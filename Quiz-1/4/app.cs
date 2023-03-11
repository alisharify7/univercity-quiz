using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n=5, m=30;
            while (n <= m)
            {
                if (n % 5 == 0)
                {
                    Console.WriteLine(n);
                }
                n++;
            }
            Console.ReadKey();
        }
    }
}
