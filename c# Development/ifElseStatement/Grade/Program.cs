﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());
            if (grade >= 3.00 && grade <= 6.00)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Not passed");
            }
        }
    }
}
