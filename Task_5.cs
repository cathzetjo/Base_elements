using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Task_5
    {

        public static void Run()
        {

            {

                ConsoleKey[] arr = {ConsoleKey.Q, ConsoleKey.W, ConsoleKey.E, ConsoleKey.R,ConsoleKey.T,ConsoleKey.Y,
                                ConsoleKey.A,ConsoleKey.S,ConsoleKey.D,ConsoleKey.F,ConsoleKey.G,ConsoleKey.H,
                                ConsoleKey.J,ConsoleKey.K,ConsoleKey.L,ConsoleKey.Z,ConsoleKey.X,ConsoleKey.C,
                                ConsoleKey.V,ConsoleKey.B,ConsoleKey.N,ConsoleKey.M,
                                ConsoleKey.Backspace, ConsoleKey.D0, ConsoleKey.D1, ConsoleKey.D2, ConsoleKey.D3,
                                ConsoleKey.D4, ConsoleKey.D5, ConsoleKey.D6, ConsoleKey.D7, ConsoleKey.D8,
                                ConsoleKey.D9, ConsoleKey.Escape, ConsoleKey.F1,ConsoleKey.F10, ConsoleKey.F2,
                                ConsoleKey.F3, ConsoleKey.F4, ConsoleKey.F5, ConsoleKey.F6, ConsoleKey.F7, ConsoleKey.F8,
                                ConsoleKey.F9, ConsoleKey.F11, ConsoleKey.F12, ConsoleKey.Home, ConsoleKey.Insert, ConsoleKey.NumPad0,
                                ConsoleKey.NumPad1,ConsoleKey.NumPad2,ConsoleKey.NumPad3,ConsoleKey.NumPad4,ConsoleKey.NumPad5,
                                ConsoleKey.NumPad6,ConsoleKey.NumPad7,ConsoleKey.NumPad8,ConsoleKey.NumPad9,ConsoleKey.PageDown,
                                ConsoleKey.PageUp, ConsoleKey.Tab, ConsoleKey.Enter};

                Random rand = new Random();


                int max = 20;


                int correctNumber = 0;
                int wrongNumber = 0;

                ConsoleKeyInfo key;

                for (int i = 0; i < max; ++i)
                {
                    int indexAnykey = rand.Next(0, arr.Length);
                    ConsoleKey anyKey = arr[indexAnykey];
                    Console.WriteLine("\nPlease enter  key \"{0}\" \n", anyKey);

                    key = Console.ReadKey();

                    if (key.Key == anyKey)
                    {
                        ++correctNumber;

                        if (correctNumber == max)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\n\nWell done! :) \n");
                        }
                    }
                    else

                    {
                        ++wrongNumber;

                        i = 0;
                        correctNumber = 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nLeft {0} times to enter", (3 - wrongNumber));
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }


                    if (wrongNumber == 3)
                    {
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("\n\nWhats wrong with you?... :( \n");
                            System.Diagnostics.Process.GetCurrentProcess().Kill();
                        }
                    }

                }


            }
        }
    }
}
    

