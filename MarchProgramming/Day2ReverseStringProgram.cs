using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgramming.MarchProgramming
{
    internal class Day2ReverseStringProgram()
    {
        public static void ReverseString()
        {
            string str = "Manikanta";
            string revered = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                revered = revered + str[i];
            }

            Console.WriteLine("original string " + str);
            Console.WriteLine("reveresd string is " + revered);
        }

        //===============================
        public static void CheckggivenArrayIsSortedOrNot()
        {
            //==========  0  1  2  3  4
            int[] arr = { 1, 2, 3, 4, 5 };

            bool isSorted = true;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] >= arr[i + 1])
                {
                    isSorted = false;
                    break;
                }
            }

            if (isSorted)
            {
                Console.WriteLine("given array is sorted");
            }
            else
            {
                Console.WriteLine("given array is not sorted");
            }

        }

        public static void PrintArrayInReverseOrder()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            for (int i =arr.Length - 1; i>=0; i--)
            {
                Console.Write(arr[i]);
            }
        }

        public static void PrintLargestElement()
        {
            int[] arr = { 10, 25, 7, 99, 45 };

            int largest = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }

            Console.WriteLine("Largest Element: " + largest);
        }

        public static void PrintsmallestElement()
        {
            int[] arr = { 10, 25, 7, 99, 45 };

            int smallest = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }

            Console.WriteLine("smallest Element: " + smallest);
        }
    }
}
