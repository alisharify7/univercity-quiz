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

            // 6 number is fibunacci sequence
            int fibseq= 6;

            int res = 1;
            for (int i = 1; i <= fibseq; i++)
            {
                Console.WriteLine(i);
                res *= i;
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
