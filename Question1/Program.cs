using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Que.1--Write a program to calculate Fibonacci series up to given n value.

            //Eg:
            //Input: n=10
            //output:0,1,1,2,3,5,8,13,21,34

            //Ans--

            int i;
            int n;
            int num1 = 0;
            int num2 = 1;
            int num3;
            Console.WriteLine("Enter a number.");
            n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Fibonacci series for : " + n);
            Console.Write(num1 + " ");
            Console.Write(num2 + " ");
            for (i = 0; i < n; i++)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }
            Console.ReadLine();


        }
    }
}
