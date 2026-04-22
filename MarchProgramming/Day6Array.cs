using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgramming.MarchProgramming
{
    internal class Day6Array
    {
        public static void demo()
        {
            Console.WriteLine("Enter a Array Size:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            for(int i=0; i<arr.Length;i++)
            {
                Console.WriteLine("Enter An Array Element:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
