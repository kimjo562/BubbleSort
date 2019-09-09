using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {

            bool sorting = true;

//            int[] arrayToSort = { 45, 6, 12, 51, 4, 23, 31 };
            int[] arrayToSort = {14, 65, 63, 1, 54, 89, 84, 9, 98, 57,
                                 71, 18, 21, 84, 69, 29, 11, 83, 13, 42,
                                 64, 58, 78, 82, 13, 9, 96, 14, 39, 89,
                                 40, 32, 51, 85, 48, 40, 23, 15, 94, 93,
                                 35, 81, 1, 9, 43, 39, 15, 17, 97, 52};
            int temp;
            int swaps = 0;
            int loops = 0;


            Console.WriteLine("Unsorted ");
            Console.WriteLine("---------------------------------");

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(arrayToSort[i] + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            while (sorting)
            {
                sorting = false;
                for (int i = 1; i < arrayToSort.Length; i++)
                {
                    if (arrayToSort[i] < arrayToSort[i - 1])
                    {
                        temp = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i - 1];
                        arrayToSort[i - 1] = temp;
                        swaps++;
                        sorting = true;
                    }
                    loops++;
                }


            }

            Console.WriteLine("Sorted ");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(arrayToSort[i] + " ");
            }
            Console.WriteLine("\nSwaps: " + swaps);
            Console.WriteLine("Loops: " + loops);
            Console.ReadKey();

        }
    }
}

