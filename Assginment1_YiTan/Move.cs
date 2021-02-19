using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assginment1_YiTan
{
    /**
     * 
     * this class is used to create the method of each move 
     * when the knight reaches a square, there are 8 ways it may move
     * There are 8 methods in this class, each method simulate one move. 
     * 
     * accept the parameter Square instance 
     * return the square with the new coordinate 
     * 
     * **/ 


    class Move
    {


        public Square moveZero(Square sq)
        {
            sq.X = sq.X + 2;
            sq.Y = sq.Y - 1;

            return sq;

        }
        public Square moveOne(Square sq)
        {
            sq.X = sq.X + 1;
            sq.Y = sq.Y - 2;
            return sq;

        }
        public Square moveTwo(Square sq)
        {
            sq.X = sq.X - 1;
            sq.Y = sq.Y - 2;
            return sq;

        }
        public Square moveThree(Square sq)
        {
            sq.X = sq.X - 2;
            sq.Y = sq.Y - 1;
            return sq;
        }
        public Square moveFour(Square sq)
        {
            sq.X = sq.X - 2;
            sq.Y = sq.Y + 1;
            return sq;
        }

        public Square moveFive(Square sq)
        {
            sq.X = sq.X - 1;
            sq.Y = sq.Y + 2;
            return sq;
        }
        public Square moveSix(Square sq)
        {
            sq.X = sq.X + 1;
            sq.Y = sq.Y + 2;
            return sq;
        }
        public Square moveSeven(Square sq)
        {
            sq.X = sq.X + 2;
            sq.Y = sq.Y + 1;
            return sq;
        }


    }
}
