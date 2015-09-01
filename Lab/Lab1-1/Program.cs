using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ltos

namespace Lab1_1
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            bool flag = true;

            // input
            int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };

          

            // output
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
