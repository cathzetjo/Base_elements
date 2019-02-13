using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Task_6
    {

        public static void Run()
        {

            int arrLeng = 10;
            int[] arr = new int[arrLeng];
            int[] arr2 = new int[arrLeng];
            int[] arr3 = new int[arrLeng];
            Random rand = new Random();

            Console.WriteLine("Original Array: ");

            for (int i = 0; i < arrLeng; ++i)
            {
                arr[i] = rand.Next(-100, 100);
                Console.Write(arr[i] + " ");
                arr2[i] = arr[i];
            }
            Console.WriteLine();

            Array.Sort(arr);                             //сортируем массив от меньшего к большему
            Array.Reverse(arr);                          //меняем метод сортировки на возрастающий

            Console.WriteLine("\nSorted Array: ");

            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\nFinal Array: ");

            for (int i = 0; i < arrLeng; ++i)
            {

                arr3[i] = arr[i] + arr2[i];
                Console.Write(arr3[i] + " ");
            }

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Gray;


        }
    }
}
