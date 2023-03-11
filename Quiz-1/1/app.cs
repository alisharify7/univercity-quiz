using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // s = > sum 
            // c = > couter
            // avrage formula => sum / count
            int s = 0, c = 0;
            for (int i = 0; i < 100; i++)
            {
                Console.Write(String.Format("Enter Score for student {0:d}: ", i+1));
                string temp = Console.ReadLine();
                int n = Convert.ToInt32(temp);
                if (n >= 15) {
                    s += n;
                    c++;
                }

            }
            Console.WriteLine(String.Format("Avrage of Scores that is higher than 15 is {0:d}", s/c));
            Console.ReadKey();
        }
    }
}
