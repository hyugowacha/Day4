using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class gwaje2
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 4];
            int num1 = 1;
            int num2 = 1;
            arr[0, 1] = 1;

            Console.WriteLine("변경 전\n");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = num1;
                    num1 = num2 * 3;
                    num2++;
                    Console.Write($"{arr[i, j]}　");
                }
                Console.WriteLine('\n');
            }

            int temp;

            temp = arr[1, 2];
            arr[1, 2] = arr[2, 1];
            arr[2, 1] = temp;

            Console.WriteLine("변경 후\n");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{arr[i, j]}　");
                }
                Console.WriteLine('\n');
            }

        }
    }
}
