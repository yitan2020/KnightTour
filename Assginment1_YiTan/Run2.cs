using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment1_YiTan
{
    /**
 * This file is a partial class of run. 
 * The class Run is abstract class which was implemented by class RunRandom and class RunSmart 
 * This class includes the generateRandomNum method to generate random numbers, the PrintOutSteps
 * method to convert the elements number stored in the occupiedSquare to a string, EmptyOccupiedSquare
 * method  
 * 
 * 
 * **/
    abstract partial class Run
    {
        /**
         * This method is used to generate random numbers 
         */
        public int generateRandomNum(int max)
        {
            Random random = new Random();
            return random.Next(0, max - 1);
        }


        /**
         * 
         * this method accept the array of the occupied squares 
         * the value of each element is the sequence of each step 
         * print out the steps in order, no return value 
         * **/
        public string PrintOutSteps(int[,] occupiedSquare)
        {
            var resultString = new System.Text.StringBuilder();
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    resultString.Append(Convert.ToString(occupiedSquare[i, j]).PadLeft(8));                    
                }
                resultString.AppendLine( Environment.NewLine);
            }

            return resultString.ToString();
        }

        /**
         * This method accept the array of the occupied squares
         * and remove all the elements in the array after each run
         */
        public int[,] EmptyOccupiedSquare(int[,] occupiedSquare)
        {
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    occupiedSquare[i, j] = 0;
                }
            }
            return occupiedSquare;
        }
    }
}
