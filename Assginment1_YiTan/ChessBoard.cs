using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment1_YiTan
{
    class ChessBoard
    {
        /*
         * This class is used to generate the chess board which was comprised of 64 squares objects
         * meanwhile it assigns a rate value to each square 
         * 
         */

        public Square[,] GenerateChessBoard()
        {
            int i, j;
            Square[,] chessBoard = new Square[8, 8];
            for (i = 0; i <= 7; i++)
            {
                for (j = 0; j <= 7; j++)
                {

                    if (((i == 0) && (j == 0)) || ((i == 0) && (j == 7)))
                    {

                        chessBoard[i, j] = new Square(i, j, 2);
                    }
                    else if (((i == 7) && (j == 0)) || ((i == 7) && (j == 7)))
                    {
                        chessBoard[i, j] = new Square(i, j, 2);
                    }
                    else if (((i == 0) && (j == 1 || j == 6)) || ((i == 1) && (j == 0 || j == 7)))
                    {
                        chessBoard[i, j] = new Square(i, j, 3);
                    }
                    else if (((i == 7) && (j == 1 || j == 6)) || ((i == 6) && (j == 0 || j == 7)))
                    {
                        chessBoard[i, j] = new Square(i, j, 3);
                    }

                    else if (((i == 1 || i == 6) && (j >= 2 && j <= 5)) || ((i >= 2 && i <= 5) && (j == 1 || j == 6)))
                    {
                        chessBoard[i, j] = new Square(i, j, 6);
                    }

                    else if ((i >= 2 && i <= 5) && (j >= 2 && j <= 5))
                    {
                        chessBoard[i, j] = new Square(i, j, 8);
                    }


                    else
                    {
                        chessBoard[i, j] = new Square(i, j, 4);

                    }


                    Console.Write(chessBoard[i, j].RATE + " ");


                }

                Console.WriteLine();
            }

            return chessBoard;
        }

    }
}
