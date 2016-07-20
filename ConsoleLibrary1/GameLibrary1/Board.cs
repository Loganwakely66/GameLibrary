using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary1
{
    class Board
    {
        char[,] board = new char[3, 3]; // this is part of board

          
        public Board()
        {
          //  board[position[0], position[1]] = activePlayer.Token;
        }
        public int[] ConvertToArrayLocation(string boardPosition) //Also part of board
        {
            int position = Int32.Parse(boardPosition);
            position--; //reduce position to account for 1-based board map (done for user experience)
            int row = position / 3;
            int column = position % 3;
            return new int[] { row, column }; //inline array initialization
        }

        private void PrintBoardMap()//this is also part of board
        {
            int position = 1; //1-based board map (done for user experience)

            for (int row = 0; row <= board.GetUpperBound(0); row++)
            {
                for (int column = 0; column <= board.GetUpperBound(1); column++)
                {
                    Console.Write(position++);
                    if (column < board.GetUpperBound(1))
                    {
                        Console.Write(" - ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void PrintBoard()//this is also part of board
        {
            Console.WriteLine();
            for (int row = 0; row <= board.GetUpperBound(0); row++)
            {
                for (int column = 0; column <= board.GetUpperBound(1); column++)
                {
                    Console.Write(board[row, column]);

                    //only print the dashes for the inner columns
                    if (column < board.GetUpperBound(1))
                    {
                        Console.Write(" - ");
                    }
                    {
                        {                                                                                                                                                                                                                                                                                                                                                                 /*Congrats!  You found the easter egg!  Weren't those useless curly brackets annoying? Plus one was missing.... way out here on column 500+*/                                                         }
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
