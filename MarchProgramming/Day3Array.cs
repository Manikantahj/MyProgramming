using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgramming.MarchProgramming
{
    internal static class Day3Array
    {
        public static void WriteAndReadElementsInArray()
        {
            //INITIALIZE ARRAY SIZE========
            int[] numbers = new int[5];

            //WRITE ELEMENTS IN ARRAY========
            for (int i = 0; i < numbers.Length; i++)
            {
                //USER WILL ENTER THE ELEMENTS IN ARRAY========
                Console.Write("Enter a number: ");

                //STORE THE ELEMENTS IN ARRAY========
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("You entered:");
            foreach (int number in numbers)
            {
                //USER ENTERED ELEMENTS IN ARRAY WILL BE PRINTED========
                Console.WriteLine(number);
            }
        }
    }
}
