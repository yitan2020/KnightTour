using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Assginment1_YiTan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /**
         * 
         * once the the run button is clicked, it will fire
         * this event handler:
         * a. collect the value from the textboxes (starting point coordinates X & Y, the number of round, checkbox)
         * b. valid the input from the textboxes
         * c. in each round, the coorindate of each touched squared will be stored in the int[,] occupiedSquare
         * d. counting the length of occupiedSquare is the total number of squares that are touched
         * e. the value of each index of occupiedSquare is the sequence of that square being touched. 
         * f. the result of each round will be stored in rs - a ResultStats object 
         * g. the results of all the rounds will be written to text file. 
         * **/

        private void btnRun_Click(object sender, EventArgs e)
        {
            resultBox.Visible = true;


            //get the value of the starting point 
            // the textboxex cannot be empty 
            //reference from 
            //https://stackoverflow.com/questions/10611615/
            //checking-textbox-for-valid-input-in-a-loop-or-try-catch-c-sharp
            if (string.IsNullOrEmpty(pointX.Text) || string.IsNullOrEmpty(pointY.Text) || string.IsNullOrEmpty(numOfRd.Text))
            {
                string message = "The input is not valid. Please enter a number";
                string caption = "fail";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int temp, x, y,rd;

            //validate the pointX value, cannot be non integer or integer out of range (2,7) included
            if(Int32.TryParse(pointX.Text, out temp) && temp <8 && temp >-1)
            {
                x = temp;
            }
            else
            {
                string message = "point X coordinate input is not valid!";
                string caption = "fail";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //validate the pointY value, cannot be non integer or integer out of range (2,7) included
            if (Int32.TryParse(pointY.Text, out temp) && temp <8 && temp >-1)
            {
                y = temp;
            }
            else
            {
                string message = "point Y coordinate input is not valid!";
                string caption = "fail";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //validate the round value, cannot be non integer or integer less than 1
            if (Int32.TryParse(numOfRd.Text, out temp) && temp>0)
            {
                rd = temp;
            }
            else
            {
                string message = "The number of times input is not valid! Please enter an integer greater than 0.";
                string caption = "fail";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
            
        
            //validate the checkboxes
            int choice = 0;
            if(nonInteligentBtn.Checked)
            {
                choice = 1;
            }
            else if(smartBtn.Checked)
            {
                choice = 2;
            }
            else
            {
                string message = "Please select a version you would like to run!";
                string caption = "fail";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            int[,] occupiedSquare = new int[8, 8];  // to save the coordinates of each square that is touched

            ResultStats rs = new ResultStats(rd); //create an instance of ResultStats object 
            Run rn;  //create an instance of Run object 

            if (rd == 1)  // if rd ==1, needs to show the detailed steps in the UI 
            {
               
                Square startP = new Square(x, y);


                if (choice == 1)  // run the random version 
                {
                    
                    rn = new RunRandom(startP);
                    rn.RunOneRound(occupiedSquare); 
                    resultBox.Text = rn.PrintOutSteps(occupiedSquare); //show the detailed steps in UI 
                    int maxSteps = rs.FindSteps(occupiedSquare); //find the total steps of the round
                    rs.StoreRecord(maxSteps, rd); //store the result 
                    rs.WriteResultNonIntelligent();  // write the result to text file 
                }

                else  // run the smart version 
                {
                    rn = new RunSmart(startP);
                    rn.RunOneRound(occupiedSquare);
                    resultBox.Text =rn.PrintOutSteps(occupiedSquare);
                    int maxSteps = rs.FindSteps(occupiedSquare);
                    rs.StoreRecord(maxSteps, rd);
                    rs.WriteResultIntelligent();  // write the result to text file
                }


            }
            else   // if rd more than 1, no need to show the detailed steps but show the stats (average, std) 
            {   
               
                Square startP = new Square(x, y);

                int maxSteps = 0;
                while (rd > 0)  //loop all the rounds 
                {

                    if (choice == 1)  // random version 
                    {
                        rn = new RunRandom(startP);
                        occupiedSquare = rn.RunOneRound(occupiedSquare);
                        maxSteps = rs.FindSteps(occupiedSquare);
                        rs.StoreRecord(maxSteps, rd);
                        rs.WriteResultNonIntelligent();

                    }
                    else  //smart version 
                    {
                        rn = new RunSmart(startP);
                        rn.RunOneRound(occupiedSquare);
                        maxSteps = rs.FindSteps(occupiedSquare);
                        rs.StoreRecord(maxSteps, rd);
                        rs.WriteResultIntelligent();
                    }

                    rd--;
                }


                // show the stats in the textbox in UI 
                resultBox.Text = "The average number of touched squares are " + string.Format("{0:00}", rs.CalculateAverage()) +System.Environment.NewLine
                                  + "The standard deviation is " + string.Format("{0:0.00}",rs.CalculateSd())+".";


            }











        }

    }
}
