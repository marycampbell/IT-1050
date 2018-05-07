using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        public const int size = 8;
        public static string[][] board;

        static void Main(string[] args)
        {
            bool finished = false;
            int startX;
            int startY;
            int destX;
            int destY;

            CreateBoard();

            while (!finished)
            {               
                PrintBoard();

                System.Console.WriteLine("To exit the game, put 0 for all coordinates");
                System.Console.WriteLine();
            
                System.Console.Write("Specify X coordinate starting point : ");
                startX = Int32.Parse(System.Console.ReadLine());

                System.Console.Write("Specify Y coordinate starting point : ");
                startY = Int32.Parse(System.Console.ReadLine());

                System.Console.Write("Specify X coordinate destination point : ");
                destX = Int32.Parse(System.Console.ReadLine());

                System.Console.Write("Specify Y coordinate destination point : ");
                destY = Int32.Parse(System.Console.ReadLine());

                if (startX == 0)
                {
                    if (startY == 0)
                    {
                        if (destX == 0)
                        {
                           if (destY == 0)                  
                              {
                                finished = true;
                            }

                        }
                    }
                }

                System.Console.WriteLine("Press any key to continue");
                System.Console.ReadLine();
                System.Console.Clear();

                if (startX < 0 | startX > 7)
                {
                    finished = true;
                }

                if (startY < 0 | startY > 7)
                {
                    finished = true;
                }

                if (destX < 0 | destX > 7)
                {
                    finished = true;
                }

                if (destY < 0 | destY > 7)
                {
                    finished = true;
                }

                if (board[startX][startY] == "X")
                {
                    board[destX][destY] = "X";
                    board[startX][startY] = " ";
                }
                
            }

        }

        static void CreateBoard()
        {
            board = new string[size][];

            for (int i = 0; i < size; i++)
            {
                board[i] = new string[size];

                for (int j = 0; j < size; j++)
                {
                    //Fill the top two and bottom two row with "X"
                    board[i][j] = (i < 2 || i > 5) ? "X" : " ";
                }
            }
        }

        static void PrintBoard()
        {
            PrintLine();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    //Print all vertical lines
                    System.Console.Write(" | " + board[i][j]);
                }

                System.Console.Write(" |");
                System.Console.WriteLine();
                PrintLine();
            }
        }

        static void PrintLine()
        {
            //Print horizonatal lines        
            System.Console.WriteLine(" +-------------------------------+");
        }

    }
}

