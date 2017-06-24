using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Que.4--write a program to swap min and max element in integer array.
            //Input: arr[]={10,6,11,20,15,36,8}
            //Outout:10,36,11,20,15,6,8


            //Ans--

            int[] arr = {10, 6, 11, 20, 15, 36, 8};
            int j = 0;
           int temp=0 ;
         
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[j] < arr[i])
                {
                    arr[temp] = arr[i];
                    arr[i] = arr[j];
                    arr[j] =arr[temp];
                }
                j ++;
            }

            Console.ReadLine();
        }
    }
}

