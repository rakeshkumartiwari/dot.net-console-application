using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Que.4--write a program to move zeros to end of array.
            //Input: arr[]={0,6,0,20,0,0,36,8}
            //Output: 6,20,36,8,0,0,0,0

            //Ans--
            int[] arr = { 0, 6, 0, 20, 0, 0, 36, 8 };
            
           var arr1 = new int[arr.Length];
            int temp=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]!= 0)
                {
                    if (arr1.Length > temp) arr1[temp] = arr[i];
                    temp++;
                }
            }
            Console.WriteLine("Input : 0 6 0 20 0 0 36 8");
            Console.Write("Output :");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
