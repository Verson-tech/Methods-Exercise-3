using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Methods_exercise_3
{
    internal class MyMethods
    {
        //1. Write a method that will print to the console all numbers 1000 through -1000.
        public static void OutputThousand()
        {
            Console.WriteLine("\n************************** 1 *****************************");
            for (int i = -1000; i <= 1000; i++)
            {              
                Console.WriteLine(i);
            }
            
        }
        //2. Write a method that will print to the console numbers 3 through 999 by 3 each time.
        public static void ByThree()
        {
            Console.WriteLine("\n************************** 2 *****************************");
            int num = 3;
            do
            {
                num += 3;
                Console.Write($" number {num}");
            }
            while (num <= 999);
            
        }

        // 3. Write a method to accept two integers as parameters and check whether they are equal or not.
        public static void EqualityTest()
        {
            Console.WriteLine("\n************************** 3 *****************************");
            Console.WriteLine("\nType the first number value to be checked:");
            int firstValue = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nType the second number value to be checked:");
            int secondValue = Int32.Parse(Console.ReadLine());
            if (firstValue != secondValue)
            {
                Console.WriteLine($"Your values {firstValue} and {secondValue}  are not equal.");
            }
            else
            {
                Console.WriteLine($"Your values {firstValue} and {secondValue}  are equal.");
            }
        }
        //4. Write a method to check whether a given number is even or odd.
        public static void EvenOdd()
        {
            Console.WriteLine("\n************************** 4 *****************************");
            Console.WriteLine("Type your number:");
            int yourNumber = Int32.Parse(Console.ReadLine());
            if (yourNumber % 2 == 0)
            {
                Console.WriteLine($"{yourNumber} is an even number.");
            }
            else
            {
                Console.WriteLine($"{yourNumber} is an odd number.");
            }

        }
        //5. Write a method to check whether a given number is positive or negative.
        public static void PositiveNegative()
        {
            Console.WriteLine("\n************************** 5 *****************************");
            Console.WriteLine("Type your number to check if it is positive or negative:");
            int number = Int32.Parse(Console.ReadLine());
            bool positive = number > 0;
            if (positive)
            {
                Console.WriteLine("The number you entered is positive.");
            }
            else
            {
                Console.WriteLine("The number you entered is negative.");
            }
        }
        //6. Write a method to read the age of a candidate and determine whether they can vote. 
        public static void DetermineAge()
        {
            Console.WriteLine("\n************************** 6 *****************************");
            
            Console.WriteLine("Please, enter your age:");
            int age = Int32.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
        }
        public static void CheckRange()
        //7. Write a method to check if an integer (from the user) is in the range -10 to 10
        {
            Console.WriteLine("\n************************** 7 *****************************");
            Console.WriteLine("Enter a number in the range -10 to 10:");
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput >= -10 && userInput<= 10)
            {
                Console.WriteLine("Your number is within the range.");
            }
            else
            {
                Console.WriteLine("Your number is out of the range.");
            }
        }
        public static void DisplayTable()
        //8. Write a method to display a given integer's multiplication table(from 1 to 12)
        {
            Console.WriteLine("\n************************** 8 *****************************");
            Console.WriteLine("Enter a number in order to display a multiplication table:");
            int numberInput = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= 12 ; i++)
            {        
                Console.WriteLine("{0} x {1} = {2} \n" , numberInput, i, numberInput * i);
            }  
        }
    }
}