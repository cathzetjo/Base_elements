using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace zadanie1
{
    class Task_2
    {

        public static void Run()
        {
            Console.WriteLine("Lets play in \"STONE\" - \"BOOM\" - \"SCISSORS\"!\n");

            ConsoleKeyInfo key = new ConsoleKeyInfo();

            int count = 0;
            int playerWin = 0;
            int robotWin = 0;
            int friendshipWin = 0;

            do
            {

                Console.Write("Make your choise: ");
                string version_player = Console.ReadLine();


                if (version_player != "stone" && version_player != "boom" && version_player != "scissors")
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nThere is no such option. Try again.\n");
                    Console.ResetColor();
                }

                else
                {
                    Thread.Sleep(300);
                    Console.WriteLine("\nYour choise: " + version_player);

                    Random rand = new Random();
                    int version_PC = rand.Next(1, 4);
                    string version_PC2 = "temp";
                    switch (version_PC)
                    {
                        case 1: version_PC2 = "stone"; break;
                        case 2: version_PC2 = "scissors"; break;
                        case 3: version_PC2 = "boom"; break;
                    }


                    Thread.Sleep(300);
                    Console.WriteLine("\nRobot choise: " + version_PC2);
                    Thread.Sleep(1000);


                    if (version_player == version_PC2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nDraw!\n");
                        count++;
                        friendshipWin++;
                        Console.ResetColor();
                    }

                    if ((version_player == "stone") && (version_PC2 == "scissors"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nYou won!\n");
                        count++;
                        playerWin++;
                        Console.ResetColor();
                    }



                    if ((version_player == "stone") && (version_PC2 == "boom"))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nRobot won!\n");
                        count++; ++robotWin;
                        Console.ResetColor();
                    }

                    if ((version_player == "scissors") && (version_PC2 == "boom"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nYou won!\n");
                        count++;
                        playerWin++;
                        Console.ResetColor();
                    }



                    if ((version_player == "scissors") && (version_PC2 == "stone"))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nRobot won!\n");
                        count++;
                        ++robotWin;
                        Console.ResetColor();
                    }

                    if ((version_player == "boom") && (version_PC2 == "stone"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nYou won!\n");
                        count++;
                        playerWin++;
                        Console.ResetColor();
                    }

                    if ((version_player == "boom") && (version_PC2 == "scissors"))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nRobot won!\n");
                        count++;
                        ++robotWin;
                        Console.ResetColor();
                    }

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\n\t\tPrss ESC for exit\n\t or any other key to continue.\n");
                    key = Console.ReadKey();
                    Console.ResetColor();


                }
            }
            while (key.Key != ConsoleKey.Escape);

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nStatistics:\n");
            Thread.Sleep(300);
            Console.WriteLine($"You: {playerWin}");
            Thread.Sleep(100);
            Console.WriteLine($"Robot: {robotWin}");
            Thread.Sleep(100);
            Console.WriteLine($"Draw: {friendshipWin}");
            Thread.Sleep(100);
            Console.WriteLine("_________");
            Console.WriteLine($"Total: {count}\n");
            
            Console.WriteLine($"The end");
        }

    }
}


