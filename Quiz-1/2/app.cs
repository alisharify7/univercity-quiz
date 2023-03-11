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

            //way one
            //Console.Write("Enter a Number: ");
            //string input = Console.ReadLine();
            //char[] rev = (input.Reverse()).ToArray();
            //Console.WriteLine(rev);
            //Console.ReadKey();


            //way two
            //Console.Write("Enter a Number: ");
            //string input = Console.ReadLine();
            //int len = (input.Length)-1;
            //int i= 0;

            //while (i <= len)
            //{
            //    Console.Write(input[len - i]);
            //    i++;
            //}
            //Console.WriteLine();
            //Console.ReadKey();


            //way three
            int number = 980;
            int res = 0;
            int revers = 0;
            while (number != 0) {
                res = number % 10;
                revers = revers * 10 + res;
                number /= 10;
            }
            Console.WriteLine(revers);

            Console.ReadKey();
        }
    }
}
