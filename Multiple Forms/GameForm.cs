using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_Forms
{
    public partial class GameForm : Form
    {
        //Fields
        private Form1 mainWindow;
        protected bool gameStart;
        protected double time;
        protected int timeLimit;
        protected int number;
        protected int guess;
        protected int low;
        protected int high;



        //Field Properties
        //TimeLimit property
        public int TimeLimit
        {
            get
            {
                return timeLimit;
            }
            set
            {
                timeLimit = value;
            }
        }

        //Number property
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        //Low property
        public int Low
        {
            get
            {
                return low;
            }
            set
            {
                low = value;
            }
        }

        //High property
        public int High
        {
            get
            {
                return high;
            }
            set
            {
                high = value;
            }
        }



        public GameForm(Form1 main)
        {
            //Saving a reference to the main form
            this.mainWindow = main;

            InitializeComponent();
        }

        //When the user closes the window, this prevents the actual "closing" of the form
        private void GameFormClosing(object sender, FormClosingEventArgs e)
        {
            //Stopping the Timer just in case it was still running
            timer.Stop();

            //Canceling the actual "closing" of the form
            e.Cancel = true;

            //Re-hiding the MessageBox and CloseButton
            messageBox.Visible = false;
            closeButton.Visible = false;

            //Enabling the StartButton
            startButton.Enabled = true;

            //Resetting the ProgressBar
            progressBar.Value = 0;

            //Clearing all text boxes
            guessBox.Text = "";
            timeBox.Text = "";
            outBox.Text = "";

            // Instead, simply hide it
            this.Hide();
        }





        // --------------- Methods ---------------



        //Game Start Method
        public void Start(object sender, EventArgs e)
        {
            //Enabling the GuessBox and GuessButton
            guessBox.Enabled = true;
            guessButton.Enabled = true;

            //Creating a Random object
            Random rng = new Random();

            //Generating the number
            number = (int)rng.Next(low, high) + 1;

            //Starting the timer
            time = 0;
            gameStart = true;
            timer.Start();
            this.TimerTick(sender, e);
        }



        //Timer's Tick Event Handler
        private void TimerTick(object sender, EventArgs e)
        {
            //If the progress bar fills, the timer stops
            if (progressBar.Value >= 100)
            {
                timer.Stop();
                gameStart = false;

                //Revealing the MessageBox and CloseButton
                messageBox.Visible = true;
                closeButton.Visible = true;

                //Informing the user that they have failed
                messageBox.Text = "Out of time!  The number was " + number.ToString();

                //Disabling the GuessButton and GuessBox
                guessButton.Enabled = false;
                guessBox.Enabled = false;
            }

            //Incrementing time by lower values to make the time displayed accurate
            time += 0.25;
            timeBox.Text = ((int)time).ToString() + " Seconds";

            if (time % 1 == 0)
            {
                progressBar.Increment(100 / timeLimit);
            }
        }



        //StartButton Click Method
        private void StartClick(object sender, EventArgs e)
        {
            this.Start(sender, e);
            this.TimerTick(sender, e);

            startButton.Enabled = false;
        }



        //GuessBotton Click Method
        private void GuessClick(object sender, EventArgs e)
        {
            //If the input is an int, then it will be parsed into the "low" field
            if (int.TryParse(guessBox.Text, out guess))
            {
                guess = int.Parse(guessBox.Text);

                //If the guess is too high, the appropriate message is printed
                if(guess > number)
                {
                    outBox.Text = "Lower";
                }

                //If the guess is too low, the appropriate message is printed
                else if(guess < number)
                {
                    outBox.Text = "Higher";
                }

                //If the guess is correct, the appropriate message is printed and the timer is stopped
                else
                {
                    timer.Stop();

                    //Clearing the outBox
                    outBox.Text = "";

                    //Revealing the MessageBox and CloseButton
                    messageBox.Visible = true;
                    closeButton.Visible = true;
                    messageBox.Text = "Correct!";

                    //Disabling the GuessButton and GuessBox
                    guessButton.Enabled = false;
                    guessBox.Enabled = false;
                }
            }

            //Otherwise, and error will print in OutBox
            else
            {
                outBox.Text = "Error: Invalid Input";
            }
        }



        //CloseButton Click Method
        private void CloseClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
