using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgramming.MarchProgramming
{
    internal class Day4Arrays
    {
        public static void DisplayElementsEvenindexinGivenArray()
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
            Console.WriteLine("Elements at even indices:");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    //PRINT ELEMENTS AT EVEN INDICES========
                    Console.WriteLine($"Index {i}: {numbers[i]}");
                }
            }
        }
    }
}
