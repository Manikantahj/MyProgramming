using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgramming.MarchProgramming
{
    internal class Day1Program
    {
        public static void SwapNumbers()
        {
            int a = 10;
            int b = 20;

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");

            Console.ReadLine();
        }
    }
}
