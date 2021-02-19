using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment1_YiTan
{

    /**
     * This file is a partial class of run. 
     * The class Run is abstract class which was implemented by class RunRandom and class RunSmart 
     * This class is used to generate the chessboard - the 64 squares, the abstract method -RunOneRound to simulate a run
     * checkPossibleMoves method to validate moves 
     * 
     * 
     * **/

    abstract partial class Run
    {
        static ChessBoard csb = new ChessBoard();
        public static Square[,] chessBoardInterface = csb.GenerateChessBoard();


        public abstract int[,] RunOneRound(int[,] occupiedSquare);


        /**
        * this method accept the current square the knight lands and the occupiedSquare array
        * will check possible moves by validating the boundary of the new square and if it exists in the occupiedSquare array 
        * if it is a possible move, the coordinate of the new square will be stored in the Square List named possibleMoves.  
        * will check the possible moves through the eight methods in the Move class. 
        * 
        * return possibleMove List
        * **/
        public List<Square> checkPossibleMoves(Square sq, int[,] occupiedSquare, List<Square> possibleMoves, Square[,] chessBoardInterface)
        {
            Move mv = new Move();
            //based on the passed parameter Square sq, create a new square to represent the new position
            //that the knight can land 
            Square sq0 = new Square(sq.X, sq.Y, sq.RATE);
            sq0 = mv.moveZero(sq0); //get the new square after moving via the moveZero method 

            if ((sq0.X >= 0 && sq0.X <= 7) && (sq0.Y >= 0 && sq0.Y <= 7))  //check the boundary 
            {
                if ((occupiedSquare[sq0.X, sq0.Y] == 0))  //check if it's occupied
                {
                    sq0.RATE = chessBoardInterface[sq0.X, sq0.Y].RATE; //check the rate value of the new square from the chess board 
                    possibleMoves.Add(sq0); //if the new square meets the conditions, save to the Square List possibleMoves

                }
            }

            //check the validation of the new square after moving via the moveOne method 
            Square sq1 = new Square(sq.X, sq.Y, sq.RATE);
            sq1 = mv.moveOne(sq1);

            if ((sq1.X >= 0 && sq1.X <= 7) && (sq1.Y >= 0 && sq1.Y <= 7))
            {
                if ((occupiedSquare[sq1.X, sq1.Y] == 0))
                {
                    sq1.RATE = chessBoardInterface[sq1.X, sq1.Y].RATE;
                    possibleMoves.Add(sq1);
                }
            }

            Square sq2 = new Square(sq.X, sq.Y, sq.RATE);
            sq2 = mv.moveTwo(sq2);
            if ((sq2.X >= 0 && sq2.X <= 7) && (sq2.Y >= 0 && sq2.Y <= 7))
            {
                if ((occupiedSquare[sq2.X, sq2.Y] == 0))
                {
                    sq2.RATE = chessBoardInterface[sq2.X, sq2.Y].RATE;
                    possibleMoves.Add(sq2);
                }
            }

            Square sq3 = new Square(sq.X, sq.Y, sq.RATE);
            sq3 = mv.moveThree(sq3);
            if ((sq3.X >= 0 && sq3.X <= 7) && (sq3.Y >= 0 && sq3.Y <= 7))
            {
                if ((occupiedSquare[sq3.X, sq3.Y] == 0))
                {
                    sq3.RATE = chessBoardInterface[sq3.X, sq3.Y].RATE;
                    possibleMoves.Add(sq3);
                }
            }

            Square sq4 = new Square(sq.X, sq.Y, sq.RATE);
            sq4 = mv.moveFour(sq4);
            if ((sq4.X >= 0 && sq4.X <= 7) && (sq4.Y >= 0 && sq4.Y <= 7))
            {
                if ((occupiedSquare[sq4.X, sq4.Y] == 0))
                {
                    sq4.RATE = chessBoardInterface[sq4.X, sq4.Y].RATE;
                    possibleMoves.Add(sq4);
                }
            }

            Square sq5 = new Square(sq.X, sq.Y, sq.RATE);
            sq5 = mv.moveFive(sq5);
            if ((sq5.X >= 0 && sq5.X <= 7) && (sq5.Y >= 0 && sq5.Y <= 7))
            {
                if ((occupiedSquare[sq5.X, sq5.Y] == 0))
                {
                    sq5.RATE = chessBoardInterface[sq5.X, sq5.Y].RATE;
                    possibleMoves.Add(sq5);
                }
            }


            Square sq6 = new Square(sq.X, sq.Y, sq.RATE);
            sq6 = mv.moveSix(sq6);
            if ((sq6.X >= 0 && sq6.X <= 7) && (sq6.Y >= 0 && sq6.Y <= 7))
            {
                if ((occupiedSquare[sq6.X, sq6.Y] == 0))
                {
                    sq6.RATE = chessBoardInterface[sq6.X, sq6.Y].RATE;
                    possibleMoves.Add(sq6);
                }
            }

            Square sq7 = new Square(sq.X, sq.Y, sq.RATE);
            sq7 = mv.moveSeven(sq7);
            if ((sq7.X >= 0 && sq7.X <= 7) && (sq7.Y >= 0 && sq7.Y <= 7))
            {
                if ((occupiedSquare[sq7.X, sq7.Y] == 0))
                {
                    sq7.RATE = chessBoardInterface[sq7.X, sq7.Y].RATE;
                    possibleMoves.Add(sq7);
                }
            }

            return possibleMoves;

        }




    }
}
