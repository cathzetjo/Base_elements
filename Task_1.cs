using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Task_1
    {

        public static void Run()
        {
            Console.WriteLine("Введите строку 'Я буду усердно делать все задания по C#'");
            string str1 = Console.ReadLine();
            string str2 = "Я буду усердно делать все задания по C#";

            if (str1 == str2)
                Console.WriteLine("За это ты получишь печеньку");
            else
                Console.WriteLine("Вы неправы!");

        }
    }
}
