using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgramming.MarchProgramming
{
    internal class Day5Array
    {
        public static void DisplayOddIndx()
        {
            Console.WriteLine("Enter Array Size");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine("Enter the Array Elements");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Elements at odd indexes:");
            for(int i=0; i<arr.Length; i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
