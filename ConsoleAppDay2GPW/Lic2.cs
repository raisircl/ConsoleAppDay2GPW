using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDay2GPW
{
    internal class Lic2
    {
        //logical And 
        static void Main()
        {
            int age;
            Console.WriteLine("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18 && age <= 60)
            {
                Console.WriteLine("You are eligible for LIC");
            }
            else
            {
                Console.WriteLine("You are not eligible for LIC");
            }
        }
    }
}
// Logical Or ||