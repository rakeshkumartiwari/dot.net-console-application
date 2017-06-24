using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Que.2--write a program to print from 1 to 100and for multiples of 3, it print Fizz and
            //for multiples of five i prnts Buzz instead of numbers.
            //For numbers which are multiples of both 3 and 5 it prints FizzBuzz.

            //Ans--
            for (int i = 0; i <= 100; i++)
            {
                //multiples of 3
                if (i % 3 == 0)
                {
                    Console.Write("Fizz"+" ");
                }

                //multiples of five
                if (i % 5 == 0)
                {
                    Console.Write("Buzz"+" ");
                }

                // multiples of both 3 and 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz"+" ");
                }
            }
            Console.ReadLine();
        }
    }
}
