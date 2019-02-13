using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Task_3
    {

        public static void Run()
        {

            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите число n2: ");
            int n2 = int.Parse(Console.ReadLine());

            decimal firstSum = 0.0m;

            for (int i = 0; i < n + 1; i++)
            {
                firstSum += 1 / Convert.ToDecimal(Factorial(i));
            }

            Console.WriteLine("\nСумма первого ряда: " + firstSum + "\n");

            Decimal secondSum = 1.0m;

            for (int i = 1; i < n2 + 1; i++)
            {
                secondSum += (Convert.ToDecimal(Math.Pow(-1, i)) / (2 * Convert.ToDecimal(i) + 1));

            }

            secondSum *= 4;

            Console.WriteLine("\nСумма второго ряда: " + secondSum + "\n");

            Console.WriteLine("\n_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _\n");
        }

        static int Factorial(int n)                                // factorial!
        {
            if (n == 0) return 1;
            else return n * Factorial(n - 1);
        }



    }
}

