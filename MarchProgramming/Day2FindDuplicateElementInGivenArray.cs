using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgramming.MarchProgramming
{
    internal class Day2FindDuplicateElementInGivenArray
    {
        public static void FindDuplicateElement()
        {

            int[] arr = { 10,20,30,10,20,50,70,80};

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine($"Duplicate element found: {arr[i]}");
                        break;
                    }
                  
                }
            }
            Console.ReadLine();
        }
    }
}
