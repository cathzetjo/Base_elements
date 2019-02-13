using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Title = "Lets go. C#. Lesson #1.";
            Console.WriteLine("Enter task number");
            Byte choise = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _\n");
            switch (choise)
            {
                case 1: Task_1.Run(); break;
                case 2: Task_2.Run(); break;
                case 3: Task_3.Run(); break;
                case 4: Task_4.Run(); break;
                case 5: Task_5.Run(); break;
                case 6: Task_6.Run(); break;
                case 7: Task_7.Run(); break;
                case 8: Task_8.Run(); break;
                case 9: Task_9(); break;
                case 10: Task_10(); break;


                default:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("This task is not exist! \n"); 
                    Console.ForegroundColor = ConsoleColor.Gray; break;
            }

        }

        static void Task_9()                                          

        {

            Console.WriteLine("This task is in other file \"Task_1.9\" ");
        }

        static void Task_10()                                          

        {

            Console.WriteLine("This task is in other file \"Task_1.10\" ");
        }
    }
    }

