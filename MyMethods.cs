using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_exercise_3
{
    internal class MyMethods
    {
        //1. Write a method that will print to the console all numbers 1000 through -1000.
        public static void OutputThousand()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
        //2. Write a method that will print to the console numbers 3 through 999 by 3 each time.
        public static void ByThree()
        {
            int num = 3;
            do
            {
                num += 3;
                Console.Write($" number {num}"); 
            }
            while (num <= 999 );
        }

        // 3. Write a method to accept two integers as parameters and check whether they are equal or not.
        public static void EqualityTest()
        {
            Console.WriteLine("\nType the first value to be checked:");
            int firstValue = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nType the first value to be checked:");
            int secondValue = Int32.Parse(Console.ReadLine());
            if(firstValue != secondValue) {
                Console.WriteLine($"Your values {firstValue} and {secondValue}  are not equal.");
            }
            else {
                Console.WriteLine($"Your values {firstValue} and {secondValue}  are equal.");
            } 
        }
  
    }
}