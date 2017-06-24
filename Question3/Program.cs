using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Que.3--Write a program to calculate power of number using recursion. 
            //Eg:
            //Input:x=5, n=4
            //Output:5 Power 4 is :625

            //Ans--

            int x;
            int n;
            int result;
            Console.WriteLine("Enter a number for x.");
            x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter a number for n.");
            n = Convert.ToInt16(Console.ReadLine());
            result = CalculatePowerOfNumber(x, n);
            Console.WriteLine("{0} Power {1} is : " + result, x, n);
            Console.ReadLine();
        }
        //I used this recusive function for this.
        public static int CalculatePowerOfNumber(int number, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
