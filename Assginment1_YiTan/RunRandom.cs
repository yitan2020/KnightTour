using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assginment1_YiTan
{

    /**
 * 
 *This class extends the parent class Run 
 *ovrride the RunOneRound method 
 *process the randomly move strategy.
 *
 **/
    class RunRandom : Run
    {
        private Square startP;

        public RunRandom(Square startP)
        {
            this.startP = startP;
        }
        /**
         * This method simulate the process of one run 
         * 
         * return the occupiedSquare rate value 
         */
        public override int[,] RunOneRound(int[,] occupiedSquare)
        {
            int step = 1;
            bool flag = true;
            List<Square> possibleMoves = new List<Square>();
            EmptyOccupiedSquare(occupiedSquare); //empty all the elements saved in the occupiedSquare array

            //randomly pick up the square to proceed 
            do
            {
                possibleMoves.Clear(); //reset the list to empty before saving new squares in the new run

                //  copy the starting square to the array of occupiedSquare 
                //the x coordinate of the new square is the row index of occupiedSquare, the y coordinate is the 
                //the column index of occupiedSquare, the value of the step is the value of element. 
                occupiedSquare[startP.X, startP.Y] = step;

                //check all the possible solutions 
                possibleMoves = checkPossibleMoves(startP, occupiedSquare, possibleMoves, chessBoardInterface);  

                //print out the elements in the list possibleMoves in the console for reference
                possibleMoves.ForEach(el => Console.WriteLine(el.X + " " + el.Y + " " + el.RATE));

                if (possibleMoves.Count != 0)
                {
                    //count the possible moves options
                    int countPossibleMoves = possibleMoves.Count;

                    //randomly select one number represent the index of element in the possibleMoves list
                    int index = generateRandomNum(countPossibleMoves);

                    //re-set the new start point 
                    startP.X = possibleMoves[index].X;
                    startP.Y = possibleMoves[index].Y;
                    //print out the new starting point in the console for reference 
                    Console.WriteLine("randomly select " + startP.X + " " + startP.Y + " " + startP.RATE);
                    step++;
                }
                else  //if no possible moves, it means the run ends. 
                {
                    flag = false;
                }
            } while (flag);

            return occupiedSquare;
        }







    }
}
