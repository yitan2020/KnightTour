using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment1_YiTan
{

    /**
     * This class is mainly handling the store the result of each round
     * calculate the average steps, standard deviation and also implement the interface WriteFile
     * 
     * There are two fields: int round - the number of runs user input, int[] record - store the 
     * number of touched squares each run
     * 
     * */ 
    class ResultStats : WriteFile
    {

        private int round;
        private int[] record;

        public int[] Record { get; set; }



        public ResultStats(int round)
        {
            this.round = round;
            record = new int[round];
        }

        /**
         * this method used to find the total number of touched squares in each run. 
         * accept the occupiedSquare array, iterate and find the maximun value which is the 
         * total number of touched squares 
         * 
         * return the max value 
         * 
         * **/
        public int FindSteps(int[,] occupiedSquare)
        {
            int max = 0;
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    if (occupiedSquare[i, j] > max)
                    {
                        max = occupiedSquare[i, j];
                    }
                }
            }

            return max;
        }

        /**
         * This method take the parameters steps - the total number of touched squares and roundNum 
         * - the number of round user inputs 
         * roundNum-1 is the index of the int[] record, the steps is the value of the array 
         * **/

        public void StoreRecord(int maxSteps, int roundNum)
        {
            record[roundNum - 1] = maxSteps;

        }

        /**
         * This method is used to calculaate the average touched squares after the number of runs 
         * user inputs 
         * 
         * return the average (double type) 
         * **/ 
        public double CalculateAverage()
        {
            int sum = 0;
            for (int i = 0; i < record.Length; i++)
            {
                sum += record[i];
            }
            double average = sum / record.Length;

            return average;

        }

        /**
         * This method is used to calculate the standard deviation of the result after the number of runs user inputs 
         * return the value of standard deviation (double type) 
         * **/
        public double CalculateSd()
        {
            double average = CalculateAverage();
            double sum = 0;
            for (int i = 0; i < record.Length; i++)
            {
                sum += Math.Pow((average - record[i]), 2);
            }
            double sd = Math.Sqrt(sum / record.Length);

            return sd;
        }

        /**
         * when user selects the non-intelligent version
         * This method is used to write the result to a text file named YiTanNonIntelligentMethod.
         * the text file path is D:\C#\Assignment1
         * 
         *  
         */
        public void WriteResultNonIntelligent()

        {
            //referece: https://docs.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=netcore-3.1
            using (System.IO.StreamWriter file =
          new System.IO.StreamWriter(@"D:\C#\Assginment1_YiTan\YiTanNonIntelligentMethod.txt"))
            {
                for (int i = 0; i < round; i++)
                {

                    file.WriteLine("Trial {0}: The knight was able to successfully touch {1} squares.", i + 1, record[i]);

                }

            }

        }

        /**
       * when user selects the smart version 
       * This method is used to write the result to a text file named YiTanHeuristicsMethod.
       * the text file path is D:\C#\Assignment1
       */
        public void WriteResultIntelligent()

        {

            using (System.IO.StreamWriter file =
          new System.IO.StreamWriter(@"D:\C#\Assginment1_YiTan\YiTanHeuristicsMethod.txt"))
            {
                for (int i = 0; i < round; i++)
                {

                    file.WriteLine("Trial {0}: The knight was able to successfully touch {1} squares.", i + 1, record[i]);

                }

            }

        }
    }
}
