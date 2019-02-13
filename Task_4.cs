using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Task_4
    {

        public static void Run()
        {

            Console.WriteLine("Введите количество повторов");

            int povtor = int.Parse(Console.ReadLine());
            Random rand = new Random();

            Console.Clear();

            for (int i = 0; i < povtor; ++i)

            {
                int randPosLeft = rand.Next(0, Console.WindowWidth);
                int randPosTop = rand.Next(0, Console.WindowHeight);
                Console.SetCursorPosition(randPosLeft, randPosTop);
                Console.WriteLine("C#");

                System.Threading.Thread.Sleep(250);
            }


        }
    }
}
