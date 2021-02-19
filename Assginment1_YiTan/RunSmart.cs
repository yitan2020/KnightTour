using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment1_YiTan
{
    /**
     * 
     *this class extends the parent class Run 
     *ovrride the RunOneRound method 
     *implement the smart move strategy 
     **/
    class RunSmart : Run
    {
        private Square startP;

        public RunSmart(Square startP)
        {
            this.startP = startP;
        }
        public override int[,] RunOneRound(int[,] occupiedSquare)
        {
            EmptyOccupiedSquare(occupiedSquare);
            int step = 1;
            bool flag = true;
            List<Square> possibleMoves = new List<Square>();

            do
            {
                possibleMoves.Clear(); //reset the list to empty 

                occupiedSquare[startP.X, startP.Y] = step; //  copy the occupied square to the array of occupiedSquare 

                possibleMoves = checkPossibleMoves(startP, occupiedSquare, possibleMoves, chessBoardInterface);  //check all the possible solutions 

                //print out the elements in the list possibleMoves 
                possibleMoves.ForEach(el => Console.WriteLine(el.X + " " + el.Y + " " + el.RATE));


                if (possibleMoves.Count != 0)
                {
                    if (possibleMoves.Count == 1)
                    {
                        //re-set the new start point 
                        startP.X = possibleMoves[0].X;
                        startP.Y = possibleMoves[0].Y;
                        startP.RATE = possibleMoves[0].RATE;

                        Console.WriteLine("randomly select " + startP.X + " " + startP.Y + " " + startP.RATE);

                    }
                    else  // if the possible moves options are more than 1, choose one move by 
                    //the smart strategy 
                    {
                        Square selectedSq = selectMoveSmart(possibleMoves);
                        startP.X = selectedSq.X;
                        startP.Y = selectedSq.Y;
                        startP.RATE = selectedSq.RATE;
                        Console.WriteLine("smartly select " + startP.X + " " + startP.Y + " " + startP.RATE);
                    }

                    step++;
                }
                else
                {
                    flag = false;
                }

            } while (flag);

            return occupiedSquare;
        }

        /**
         * This method is unique to the smart strategy.
         * It's used to find the lowest rate value of square stored in the list
         * and count the occurance of the lowest rate 
         * Then randomly select a square from the tied lowest rate value of squares        * 
         * return the square that is selected 
         */
        public Square selectMoveSmart(List<Square> possibleMoves)
        {
            int min = possibleMoves[0].RATE;
            int count = 0;
            List<Square> minList = new List<Square>();
            //find the min value 
            for (int i = 0; i < possibleMoves.Count; i++)
            {
                if (possibleMoves[i].RATE < min)
                {
                    min = possibleMoves[i].RATE;
                }
            }


            //find the occurance of the min value, and add to the minList List 
            for (int i = 0; i < possibleMoves.Count; i++)
            {
                if (possibleMoves[i].RATE == min)
                {
                    count++;
                    minList.Add(possibleMoves[i]);
                }
            }

            if (minList.Count == 1)
            {
                return minList[0];
            }
            else
            {
                //randomly select a min if there are ties 

                return minList[generateRandomNum(minList.Count - 1)];
            }


        }
    }
}
