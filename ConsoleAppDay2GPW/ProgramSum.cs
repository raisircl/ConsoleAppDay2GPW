using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDay2GPW
{
    internal class ProgramSum
    {
        static void Main()
        {
            int n1, n2, total;
            Console.WriteLine("enter value of N1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value of N2");
            n2 = Convert.ToInt32(Console.ReadLine());

            total = n1 + n2;
            Console.WriteLine($"The Sum of {n1} and {n2} is {total}");
        }
    }
}
/*
 Q1. Subtraction of 2 Nos -> -
 Q2. Production of 3 Nos -> *
 Q3. Division of 2 Numbers -> /
 Q4. Modulas of 2 Nos -> Remainder %

 */