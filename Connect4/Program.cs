
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Connect4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initalize
            bool isGameRunning = true;
            string move = "";
            int position1 = 0;
            int position2 = 0;
            int position3 = 0;
            int position4 = 0;
            int position5 = 0;
            int position6 = 0;
            string[,] gameboard = new string[6, 6] { { "|_|", "|_|", "|_|", "|_|", "|_|", "|_|" },
                                                    { "|_|", "|_|", "|_|", "|_|", "|_|", "|_|" },
                                                    { "|_|", "|_|", "|_|", "|_|", "|_|", "|_|" },
                                                    { "|_|", "|_|", "|_|", "|_|", "|_|", "|_|" },
                                                    { "|_|", "|_|", "|_|", "|_|", "|_|", "|_|" },
                                                    { "|_|", "|_|", "|_|", "|_|", "|_|", "|_|" },};

           
            //Game loop
            while (isGameRunning)
            {


                //x and o turn output
                printBoard();
                
                move = Console.ReadLine();          //TODO:Check valid input
                for (int spaces = 0; spaces < 18; spaces++)
                {
                    if (move.ToCharArray()[spaces] != ' ')
                    {
                        if (spaces == 0 || spaces == 1 || spaces == 2)
                        {
                            for (int i = 5; i > position1; i--)
                            {
                                if (i != 5) { gameboard[i + 1, 0] = "|_|"; }
                                gameboard[i, 0] = "|" + move.ToCharArray()[spaces].ToString() + "|";
                                printBoard();
                                Thread.Sleep(500);
                            }
                            if (position1 != 5) { gameboard[position1 + 1, 0] = "|_|"; }
                            gameboard[position1, 0] = "|" + move.ToCharArray()[spaces].ToString() + "|";
                            position1++;
                        }
                        else if (spaces == 3 || spaces == 4 || spaces == 5)
                        {
                            for (int i = 5; i > position2; i--)
                            {
                                if (i != 5) { gameboard[i + 1, 1] = "|_|"; }
                                gameboard[i, 1] = "|" + move.ToCharArray()[spaces].ToString() + "|";
                                printBoard();
                                Thread.Sleep(500);
                            }
                            gameboard[position2 + 1, 1] = "|_|";
                            gameboard[position2, 1] = "|" + move.ToCharArray()[spaces].ToString() + "|";
                            position2++;
                        }
                        else if (spaces == 6 || spaces == 7 || spaces == 8)
                        {
                            for (int i = 5; i > position3; i--)
                            {
                                if (i != 5) { gameboard[i + 1, 2] = "|_|"; }
                                gameboard[i, 2] = "|" + move.ToCharArray()[spaces].ToString() + "|";
                                printBoard();
                                Thread.Sleep(500);
                            }
                            gameboard[position3 + 1, 2] = "|_|";
                            gameboard[position3, 2] = "|" + move.ToCharArray()[spaces].ToString() + "|";
                            position3++;
                        }
                        else if (spaces == 9 || spaces == 10 || spaces == 11)
                        {
                            for (int i = 5; i > position4; i--)
                            {
                                if (i != 5) { gameboard[i + 1, 3] = "|_|"; }
                                gameboard[i, 3] = "|" + move.ToCharArray()[spaces].ToString() + "|";
                                printBoard();
                                Thread.Sleep(500);
                            }
                            gameboard[position4 + 1, 3] = "|_|";
                            gameboard[position4, 3] = "|" + move.ToCharArray()[spaces].ToString() + "|";
                            position4++;
                        }
                        else if (spaces == 12 || spaces == 13 || spaces == 14)
                        {
                            for (int i = 5; i > position5; i--)
                            {
                                if (i != 5) { gameboard[i + 1, 4] = "|_|"; }
                                gameboard[i, 4] = "|" + move.ToCharArray()[spaces].ToString() + "|";
                                printBoard();
                                Thread.Sleep(500);
                            }
                            gameboard[position5 + 1, 4] = "|_|";
                            gameboard[position5, 4] = "|" + move.ToCharArray()[spaces].ToString() + "|";
                            position5++;
                        }
                        else if (spaces == 15 || spaces == 16 || spaces == 17)
                        {
                            for (int i = 5; i > position6; i--)
                            {
                                if (i != 5) { gameboard[i + 1, 5] = "|_|"; }
                                gameboard[i, 5] = "|" + move.ToCharArray()[spaces].ToString() + "|";
                                printBoard();
                                Thread.Sleep(500);
                            }
                            gameboard[position6 + 1, 5] = "|_|";
                            gameboard[position6, 5] = "|" + move.ToCharArray()[spaces].ToString() + "|";
                            position6++;
                        }
                        spaces = 19;

                    }
                }
                


            }

            void printBoard()
            {
                Console.Clear();

                Console.WriteLine("Hello, welcome to connect 4!");
                Console.WriteLine("Use spaces to move to a slot. Then type your character and press ENTER.");         //TODO: add rules

                for (int rows = 0; rows < 6; rows++)
                {
                    for (int columns = 0; columns < 6; columns++)
                    {
                        Console.Write(gameboard[rows, columns]);
                    }
                    Console.WriteLine();
                }

            }
            //Restart?
        }
    }
}
*/