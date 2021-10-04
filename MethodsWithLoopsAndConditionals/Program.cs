using System;
using System.Collections.Generic;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintNumbers();
            //PrintNumbersSkipBy3();
            //IntegerCompare(3, 4);
            //EvenOrOdd();
            //PositiveOrNegative();
            //EligibleForVote();
            //IsInRange();
            //MultiplicationTable();
        }

        public static void PrintNumbers()
        {
           
            int num = -1000;
            do
            {
                Console.Write(num);
                num++;

            } while (num<=1000);
        }

        public static void PrintNumbersSkipBy3()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static void IntegerCompare(int x, int y)
        {


            if (x == y)
                Console.WriteLine("Two integers are equal!!");
            else
                Console.WriteLine("Two integers are not equal!!");
        }

        public static void EvenOrOdd()
        {
            Console.Write("Enter a number : ");
            var num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine($"{num} is an even number");
            else
                Console.WriteLine($"{num} is an odd number");

        }
        public static void PositiveOrNegative()
        {
            Console.Write("Enter a vaild number : ");
            //int num = Convert.ToInt32(Console.ReadLine());
            bool success = int.TryParse(Console.ReadLine(), out int num);
            if (success)
            {
                if (num > 0)
                    Console.WriteLine("Positive number!!");
                else if (num == 0)
                    Console.WriteLine("Neither negative nor positive!!");
                else
                    Console.WriteLine("Negative number!!");
            }

            else
                Console.WriteLine("Please enter a valid number!");

        }
        public static void EligibleForVote()
        {
            Console.Write("What is your age? ");
            //int age = int.Parse(Console.ReadLine());
            
            bool success = int.TryParse(Console.ReadLine(),out int age);
            if (success)
            {
                if (age > 18)

                    Console.WriteLine("You may vote");

                else

                    Console.WriteLine("Looks like you ar too young too vote!!");

            }
            else
            {
                Console.WriteLine("Please enter a valid age!!");
            }
        }

        public static void IsInRange()
        {
            var aList = new List <int>() { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write("Please enter a number: ");
            bool success = int.TryParse(Console.ReadLine(), out int num);
            bool inRange = false;

            if (success)
            {

                foreach (var n in aList)
                {
                    if (num == n)
                    {
                        inRange = true;
                        break;
                    }
                }

                if(inRange==true)
                    Console.WriteLine($"{num} is in the range.");
                else
                    Console.WriteLine($"{num} is not in the range.");

            }
            else
            {
                Console.WriteLine("Please enter a valid number!!");
            }
        }

        public static void MultiplicationTable()
        {
            Console.Write("Enter a number to see its Multiplication table: ");
            bool success = int.TryParse(Console.ReadLine(), out int num);

            if(success)
            {
                Console.WriteLine($" \nMultiplication Table of {num}\n------------------------------------------\n");
                for(int i=1;i<=12;i++)
                {
                    Console.WriteLine($"{num} * {i} = {num *i} \n");
                }
            }

            else
            {
                Console.WriteLine("Please enter a valid number!!");
            }



        }
    }

}
