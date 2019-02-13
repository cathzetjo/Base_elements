using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Task_7
    {

        public static void Run()
        {

            void Addition(int[] arrFull, params int[] arrParametrs)

            {

                Console.WriteLine("\nFirst array: ");

                foreach (int elements in arrFull)
                {
                    Console.Write(elements + " ");
                }

                Console.WriteLine("\n\nElements for deleting: ");

                foreach (int elements in arrParametrs)
                {
                    Console.Write(elements + " ");
                }

                int count = 0;
                for (int i = 0; i < arrFull.Length; i++)
                {
                    for (int j = 0; j < arrParametrs.Length; j++)
                    {
                        if (arrFull[i] == arrParametrs[j])

                        { ++count; }

                    }

                }
                Console.WriteLine("\n\nNumber of repits: {0} \n", count);

                int size = (arrFull.Length - count);


                int[] arrFinal = new int[size];

                for (int i = 0, k = 0; i < arrFull.Length; i++)
                {
                    bool foundSame = false;

                    for (int j = 0; j < arrParametrs.Length; j++)
                    {
                        if (arrFull[i] == arrParametrs[j])
                        {
                            foundSame = true;

                        }
                    }
                    if (foundSame == false)
                    {
                        arrFinal[k] = arrFull[i];
                        k++;
                    }

                }

                Console.WriteLine("New array: ");
                foreach (int elements in arrFinal)
                {
                    Console.Write(elements + " ");
                }

                Console.WriteLine("\n");
            }
            int[] arr = new int[] { 9, 2, 10, 3, 9, 15 };
            Addition(arr, 1, 2, 3, 9);


        }
    }
}
