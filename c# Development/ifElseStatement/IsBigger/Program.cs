using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBigger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine($"Числото {number} е положително.");
            }
            else if (number < 0)
            {
            
                Console.WriteLine($"Числото {number} не е положително.");
            }
            else
            {
                Console.WriteLine($"Числото {number} е нула.");

            }
            
        }
    }
}
