using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Connect4
{
    class EFFICENT
    {
        static bool isPlayerOneTurn = true;
        static char playerOneCharacter = 'X';
        static char playerTwoCharacter = 'O';
        static int[] positions = new int[6] { 0, 0, 0, 0, 0, 0 };
        static string[,] gameboard = new string[6, 6] { { "|_|", "|_|", "|_|", "|_|", "|_|", "|_|" },
                                                { "|_|", "|_|", "|_|", "|_|", "|_|", "|_|" },
                                                { "|_|", "|_|", "|_|", "|_|", "|_|", "|_|" },
                                                { "|_|", "|_|", "|_|", "|_|", "|_|", "|_|" },
                                                { "|_|", "|_|", "|_|", "|_|", "|_|", "|_|" },
                                                { "|_|", "|_|", "|_|", "|_|", "|_|", "|_|" },};

        static void Main(string[] args)
        {
            //Initalize
            bool isGameRunning = true;
            string move = "";

            Console.WriteLine("NOTE: This game will break if you press the ENTER key before typing a character.");   //TODO: Handle error thrown when nothing is entered
            Console.WriteLine("Choose the character to represent player one: ");
            playerOneCharacter = Console.ReadLine().ToCharArray()[0];
            Console.WriteLine("Choose the character to represent player two: ");
            playerTwoCharacter = Console.ReadLine().ToCharArray()[0];

            //Turn output
            PrintBoard();

            //Game loop
            while (isGameRunning)
            {
                move = Console.ReadLine();          //TODO:Check if the input is on the board
                for (int spaces = 0; spaces < 18; spaces++)
                {
                    if (move.ToCharArray()[spaces] != ' ')
                    {
                        if (spaces == 0 || spaces == 1 || spaces == 2)
                        {
                            if (positions[0] <= 5)
                            {
                                FallingAnimation(spaces, 0, 0);
                            }
                        }
                        else if (spaces == 3 || spaces == 4 || spaces == 5)
                        {
                            if (positions[1] <= 5)
                            {
                                FallingAnimation(spaces, 1, 1);
                            }
                        }
                        else if (spaces == 6 || spaces == 7 || spaces == 8)
                        {
                            if (positions[2] <= 5)
                            {
                                FallingAnimation(spaces, 2, 2);
                            }
                        }
                        else if (spaces == 9 || spaces == 10 || spaces == 11)
                        {
                            if (positions[3] <= 5)
                            {
                                FallingAnimation(spaces, 3, 3);
                            }
                        }
                        else if (spaces == 12 || spaces == 13 || spaces == 14)
                        {
                            if (positions[4] <= 5)
                            {
                                FallingAnimation(spaces, 4, 4);
                            }
                        }
                        else if (spaces == 15 || spaces == 16 || spaces == 17)
                        {
                            if (positions[5] <= 5)
                            {
                                FallingAnimation(spaces, 5, 5);
                            }
                        }
                        spaces = 19;

                    }
                }

                //Turn output
                PrintBoard();


                //Check for win horizontal
                for (int y = 0; y < 5; y++)
                {
                    for (int x = 0; x < 2; x++)
                    {
                        if (gameboard[x, y] != "|_|" && gameboard[x, y] == gameboard[x+1, y] && gameboard[x, y] == gameboard[x + 2, y] && gameboard[x, y] == gameboard[x + 3, y])
                        {
                            isGameRunning = false;
                            EndGame();
                        }
                    }
                }
                //Check for win vertical
                for (int y = 0; y < 2; y++)
                {
                    for (int x = 0; x < 5; x++)
                    {
                        if (gameboard[x, y] != "|_|" && gameboard[x, y] == gameboard[x, y+1] && gameboard[x, y] == gameboard[x, y+2] && gameboard[x, y] == gameboard[x, y + 3])
                        {
                            isGameRunning = false;
                            EndGame();
                        }
                    }
                }

                if (isPlayerOneTurn)
                {
                    isPlayerOneTurn = false;
                }
                else
                {
                    isPlayerOneTurn = true;
                }

            }
        }

        public static void PrintBoard()
        {
            Console.Clear();

            Console.WriteLine("Hello, welcome to connect 4!");
            Console.WriteLine("Created by Caleb Brett.");
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

        public static void FallingAnimation(int spaces, int row, int column)
        {
            for (int i = 5; i > positions[row]; i--)
            {
                if (i != 5) { gameboard[i + 1, column] = "|_|"; }
                if (isPlayerOneTurn)
                {
                    gameboard[i, column] = "|" + playerOneCharacter + "|";
                }
                else
                {
                    gameboard[i, column] = "|" + playerTwoCharacter + "|";
                }
                PrintBoard();
                Thread.Sleep(500);
            }
            if (positions[row] != 5)
            {
                gameboard[positions[row] + 1, column] = "|_|";
            }
            if (isPlayerOneTurn)
            {
                gameboard[positions[row], column] = "|" + playerOneCharacter + "|";
            }
            else
            {
                gameboard[positions[row], column] = "|" + playerTwoCharacter + "|";
            }
            positions[row]++;
        }

        public static void EndGame()
        {
            if (isPlayerOneTurn)
            {
                Console.WriteLine(playerOneCharacter + " IS THE WINNER!");
            }
            else
            {
                Console.WriteLine(playerTwoCharacter + " IS THE WINNER!");
            }
            Console.ReadLine();
        }
    }
}
