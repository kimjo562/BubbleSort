using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static int passes = 0;
        static int swaps = 0;
        static int loops = 0;

        static void Main(string[] args)
        {



            //            int[] arrayToSort = { 45, 6, 12, 51, 4, 23, 31 };
            int[] arrayToSort = {14, 65, 63, 1, 54, 89, 84, 9, 98, 57,
                                 71, 18, 21, 84, 69, 29, 11, 83, 13, 42,
                                 64, 58, 78, 82, 13, 9, 96, 14, 39, 89,
                                 40, 32, 51, 85, 48, 40, 23, 15, 94, 93,
                                 35, 81, 1, 9, 43, 39, 15, 17, 97, 52};



            //Bubble Sort
            CocktailShakerSort(arrayToSort);

            Console.WriteLine("\nPasses: " + passes);
            Console.WriteLine("Swaps: " + swaps);
            Console.WriteLine("Loops: " + loops);
            Console.ReadKey();

        }




        public static void BubbleSort(int[] arrayToSort)
        {
            bool sorting = true;
            int temp;

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

        }


        public static void OptimizedBubbleSort(int[] arrayToSort)
        {
            bool sorting = true;
            int temp;
            int magic = arrayToSort.Length;

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
                passes++;
                for (int i = 1; i < magic; i++)
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
                magic--;

            }

            Console.WriteLine("Sorted ");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(arrayToSort[i] + " ");
            }

        }




        public static void CocktailShakerSort(int[] arrayToSort)
        {
            bool sorting = true;
            int temp;
            int magic = arrayToSort.Length - 1;
            int chickenNumber = 0;

            Console.WriteLine("Unsorted ");
            Console.WriteLine("---------------------------------");

            for (int i = 1; i < arrayToSort.Length; i++)
            {
                Console.Write(arrayToSort[i] + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            while (sorting)
            {
                sorting = false;
                passes++;
                for (int i = chickenNumber; i < magic; i++)
                {
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        temp = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + 1];
                        arrayToSort[i + 1] = temp;
                        swaps++;
                        sorting = true;
                    }
                    loops++;
                }
                magic--;


                for (int i = magic; i > chickenNumber; i--)
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
                chickenNumber++;

            }


            Console.WriteLine("Sorted ");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(arrayToSort[i] + " ");
            }

        }

    }
}






