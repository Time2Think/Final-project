
using System;
using System.Threading;

namespace Labirint
{
    class Program
    {

        private static int offsetX=40;
        private static int offsetY = 21;

        public  void FirstDraw(char[,] map) 
        {
            Console.Clear();
            for (int y = 0; y < 21; y++)
                for (int x = 0; x < 40; x++)
                    PutCh(map[y, x], y, x);
        }

        public static void PutCh(char ch, int y, int x)
        {
            
            Console.SetCursorPosition(offsetX + x, offsetY + y);
            Console.Write(ch);
        }

        static char[,] map =
           {
                {'■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■'},
                {'■',' ',' ',' ',' ',' ','■',' ',' ',' ',' ',' ','■',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','■',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','■'},
                {'■',' ',' ','■','■',' ','■',' ','■',' ','■','■','■',' ','■','■','■','■','■','■','■','■',' ','■','■','■',' ','■','■','■','■','■','■','■',' ','■','■','■',' ','■'},
                {'■',' ','■',' ',' ',' ',' ',' ','■',' ','■',' ',' ',' ','■',' ',' ',' ',' ','■',' ','■',' ','■',' ','■',' ',' ',' ',' ',' ',' ',' ',' ',' ','■',' ','■',' ','■'},
                {'■',' ','■',' ','■','■','■',' ','■',' ','■',' ','■','■','■',' ','■','■','■','■',' ','■',' ','■',' ','■',' ','■','■','■','■','■',' ','■',' ','■',' ','■',' ','■'},
                {'■',' ','■',' ','■',' ',' ',' ','■',' ','■',' ','■','■','■',' ',' ',' ',' ',' ',' ','■','■','■',' ',' ',' ',' ',' ',' ','■','■',' ','■',' ','■',' ','■',' ','■'},
                {'■',' ','■','■','■','■','■',' ','■',' ','■',' ',' ',' ','■','■','■',' ','■','■','■','■','■','■',' ','■','■','■','■','■',' ',' ',' ','■',' ','■',' ','■',' ','■'},
                {'■',' ',' ',' ',' ',' ','■',' ','■',' ','■','■','■',' ',' ',' ',' ',' ','■',' ',' ',' ',' ','■',' ','■',' ',' ',' ',' ',' ','■',' ','■',' ','■',' ','■',' ','■'},
                {'■',' ','■','■','■',' ','■',' ','■',' ',' ',' ',' ',' ','■','■','■','■','■',' ','■','■',' ','■',' ','■',' ','■','■','■','■','■',' ','■',' ','■',' ','■',' ','■'},
                {'■',' ','■',' ','■',' ','■',' ','■','■','■',' ','■','■','■',' ',' ',' ',' ',' ',' ','■',' ','■','■','■',' ','■',' ',' ',' ',' ',' ','■',' ',' ',' ','■',' ','■'},
                {'■',' ','■',' ','■',' ','■',' ','■',' ','■',' ',' ',' ',' ',' ','■','■','■','■',' ','■','■','■','■','■',' ','■','■','■','■','■','■','■','■',' ','■','■',' ','■'},
                {'■',' ','■',' ',' ',' ','■',' ','■',' ','■',' ','■',' ','■','■','■',' ',' ','■',' ',' ',' ',' ','■','■',' ',' ',' ',' ',' ',' ','■','■','■',' ','■','■','■','■'},
                {'■',' ','■',' ','■','■','■',' ','■',' ','■','■','■',' ','■',' ',' ',' ','■','■','■','■','■','■','■','■','■','■','■','■','■',' ','■','■','■',' ',' ',' ',' ','■'},
                {'■',' ','■',' ','■',' ','■',' ','■',' ',' ',' ',' ',' ','■',' ','■','■',' ',' ','■',' ',' ',' ',' ',' ',' ',' ','■',' ','■',' ','■','■','■','■',' ','■',' ','■'},
                {'■',' ','■','■','■',' ','■',' ','■',' ','■','■',' ','■','■',' ','■',' ',' ','■','■',' ','■',' ','■','■','■',' ','■',' ','■','■','■','■','■','■',' ','■',' ','■'},
                {'■',' ','■','■','■',' ',' ',' ','■',' ','■','■',' ',' ',' ',' ','■',' ','■',' ',' ',' ','■','■','■',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','■','■',' ','■'},
                {'■',' ',' ',' ','■','■','■','■','■',' ','■','■',' ','■','■','■','■',' ','■',' ','■',' ','■',' ',' ','■','■','■','■','■','■',' ','■','■','■',' ','■','■',' ','■'},
                {'■','■','■',' ','■',' ',' ',' ',' ',' ',' ','■',' ',' ',' ',' ',' ',' ','■',' ','■',' ',' ',' ','■',' ',' ',' ',' ',' ','■',' ','■',' ','■',' ',' ',' ','■','■'},
                {'■',' ','■',' ','■',' ','■','■','■','■','■','■','■','■','■','■','■','■','■',' ','■','■','■','■','■',' ','■','■','■',' ','■',' ','■',' ','■','■','■',' ',' ','■'},
                {'■',' ',' ',' ','■',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','■',' ',' ',' ','■',' ',' ',' ',' ','■','■',' ','$','■'},
                {'■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■','■'}
            };


        static int heroX = 1; 
        static int heroY = 1;
        
        
        class GameMenu : Program
        {

            public ConsoleKeyInfo keypress = new ConsoleKeyInfo();






            public void ShowMainMenu()
            {
                int choiceID;

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("||========================================================||");
                Console.WriteLine("||--------------------------------------------------------||");

                Console.Write("||-------------------------- ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Maze");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" ------------------------||");

                Console.Write("||-------------------- ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Console version");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" -------------------||");
                Console.WriteLine("||========================================================||");

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.WriteLine("                     PLAY GAME - press 1                  ");
                Console.WriteLine("                     HELP      - press 2                  ");
                Console.WriteLine("                     CREDITS   - press 3                  ");
                Console.WriteLine("                     QUIT GAME - press 4                  ");
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("                        Enjoy the Game ");

                while (true)
                {
                    keypress = Console.ReadKey(true);
                    if (keypress.Key == ConsoleKey.D1)
                    {
                        choiceID = 1;
                        break;
                    }
                    else if (keypress.Key == ConsoleKey.D2)
                    {
                        choiceID = 2;
                        break;
                    }
                    else if (keypress.Key == ConsoleKey.D3)
                    {
                        choiceID = 3;
                        break;
                    }
                    else if (keypress.Key == ConsoleKey.D4)
                    {
                        choiceID = 4;
                        break;
                    }


                }

                switch (choiceID)
                {
                    case 1:
                        
                       
                        CountDown();
                        FirstDraw(map);
                       
                        break;

                    case 2:
                        ViewHelp();
                        break;

                    case 3:
                        ViewCredits();
                        break;

                    case 4:
                        AreUsure("quit");
                        break;


                }
            }



            void ViewCredits()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine("||------------------------- Maze ---------------------||");
                Console.WriteLine("                    ** Console version **");
                Console.WriteLine("                      <<< CREDITS >>>");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("              Written in C#  language on 15/10/2019");
                Console.WriteLine("                        Author: SHTANCHENKO NIKOLAY");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("           -- Press ESC to return to Main Menu --");

                while (true)
                {
                    keypress = Console.ReadKey(true);
                    if (keypress.Key == ConsoleKey.Escape)
                        break;
                }
                ShowMainMenu();
            }

            void ViewHelp()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine("||------------------------- Maze ---------------------||");
                Console.WriteLine("                    ** Console version **                ");
                Console.WriteLine("                        <<< HELPS >>>                    ");
                Console.WriteLine("                                                         ");
                Console.WriteLine("                                                         ");
                Console.WriteLine("                                                         ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("    Keyboard buttons: - Press 'W'A'S'D' to move the hero");
                Console.WriteLine("                      - Press ESC to pause game");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("           -- Press ESC to return to Main Menu --");
                while (true)
                {
                    keypress = Console.ReadKey(true);
                    if (keypress.Key == ConsoleKey.Escape)
                        break;
                }
                ShowMainMenu();
            }

            void AreUsure(string Case)
            {
                while (true)
                {
                    if (Case == "quit")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.CursorTop = 15;
                        Console.WriteLine();
                        Console.WriteLine(" |--------------------------------------------------------|");
                        Console.WriteLine(" |                DO YOU WANT TO QUIT GAME?               |");
                        Console.WriteLine(" |                      Yes - Press 1                     |");
                        Console.WriteLine(" |                      No  - Press 2                     |");
                        Console.Write(" |--------------------------------------------------------|");

                        keypress = Console.ReadKey(true);
                        
                        if (keypress.Key == ConsoleKey.D2)
                            ShowMainMenu();
                        if (keypress.Key == ConsoleKey.D1)
                            Environment.Exit(0);
                        {
                            break;
                        }


                    }
                }
            }

            void CountDown()
            {
                Console.SetCursorPosition(20,15);
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Ready to play: ");

                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("GO!!!");
                Thread.Sleep(1000);

                Console.ForegroundColor = ConsoleColor.Green;
            }

            public void Pause()
            {
                Console.Clear();
                Console.CursorTop = 10;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("        ============================================        ");
                Console.WriteLine("                         GAME PAUSED                        ");
                Console.WriteLine("              Resume game             - press 1             ");
                Console.WriteLine("              Restart game            - press 2             ");
                Console.WriteLine("              Return to the Main Menu - press 3             ");
                Console.WriteLine("        ============================================        ");
                Console.ForegroundColor = ConsoleColor.Green;

                while (true)
                {
                    keypress = Console.ReadKey(true);
                    if (keypress.Key == ConsoleKey.D1)
                    {

                    }
                    else if (keypress.Key == ConsoleKey.D2)
                    {


                    }
                    else if (keypress.Key == ConsoleKey.D3)
                    {
                        ShowMainMenu();
                    }
                    break;
                }



            }







        }

        static void Main(string[] args)

        {
        

            GameMenu menu = new GameMenu();

            menu.ShowMainMenu();

            Console.ForegroundColor = ConsoleColor.Red;
          
            Console.CursorVisible = false;
            ConsoleKeyInfo keypress;
            do
            {
                keypress = Console.ReadKey(true);
                switch (keypress.KeyChar)
                {
                    case 'w': move(0, -1); break;
                    case 's': move(0, 1); break;
                    case 'd': move(1, 0); break;
                    case 'a': move(-1, 0); break;
                    default:
                        break;
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            
                if (keypress.Key == ConsoleKey.Escape)


            { 
                menu.Pause();
            }

            void move(int dx, int dy)
            {
                Console.CursorVisible = false;
                if (map[heroY + dy, heroX + dx] == '■') return; //Провяем нет ли стены там, куда мы будем двигаться
                {
                    map[heroY, heroX] = '@';
                    PutCh('.', heroY, heroX);
                    heroY += dy; heroX += dx;
                    map[heroY, heroX] = '@';
                    PutCh('@', heroY, heroX);
                }
                if (map[heroY + dy, heroX + dx] == '$')
                {
                  
                    Console.Clear();
                    Console.SetCursorPosition(30,20);
                    Console.WriteLine("Congratulations You Wоn!!!");
                    Thread.Sleep(2000);
                    Console.Clear();
                   
                    menu.ShowMainMenu();

                    
                }

            }
            

        }
    }
}
