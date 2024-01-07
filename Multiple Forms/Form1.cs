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
    public partial class Form1 : Form
    {
        //Fields
        private GameForm game;
        protected int low;
        protected int high;
        protected int time;



        public Form1()
        {
            InitializeComponent();

            //Creating new GameForm, but not showing it yet
            game = new GameForm(this);

            //Creating default values for the fields
            low = 0;
            high = 100;
            time = 60;
        }



        //Methods
        //StartButton Click Method
        private void ReadyClick(object sender, EventArgs e)
        {
            game.Low = low;
            game.High = high;
            game.TimeLimit = time;

            game.Show();
        }



        //EnterLowButton click method
        private void EnterLowClick(object sender, EventArgs e)
        {
            int templow;

            //If the input is an int, then it will be parsed into the "low" field
            if (int.TryParse(lowBox.Text, out templow))
            {
                templow = int.Parse(lowBox.Text);

                //Checking that the value is less than the "high" field and that there are at least 10 numbers between them
                if(templow < high - 10)
                {
                    low = templow;
                    lowErrorBox.Text = "Low: " + low.ToString();
                }

                //Otherwise, an error will print in LowErrorBox
                else
                {
                    lowErrorBox.Text = "Error: Too high";
                }
            }

            //Otherwise, an error will print in LowErrorBox
            else
            {
                lowErrorBox.Text = "Error: Invalid Input";
            }

            //Clearing LowBox
            lowBox.Text = "";
        }



        //EnterHighButton click method
        private void EnterHighClick(object sender, EventArgs e)
        {
            int temphigh;

            //If the input is an int, then it will be parsed into the "time" field
            if (int.TryParse(highBox.Text, out temphigh))
            {
                temphigh = int.Parse(highBox.Text);

                //Checking that the value is greater than the "low" field and that there are at least 10 numbers between them
                if (temphigh > low + 10)
                {
                    high = temphigh;
                    highErrorBox.Text = "High: " + high.ToString();
                }

                //Otherwise, an error will print in LowErrorBox
                else
                {
                    highErrorBox.Text = "Error: Too Low";
                }
            }

            //Otherwise, and error will print in LTimeErrorBox
            else
            {
                highErrorBox.Text = "Error: Invalid Input";
            }

            //Clearing HighBox
            highBox.Text = "";
        }



        //EnterTimeButton click method
        private void EnterTimeClick(object sender, EventArgs e)
        {
            int temptime;

            //If the input is an int, then it will be parsed into the "time" field
            if (int.TryParse(timeBox.Text, out temptime))
            {
                temptime = int.Parse(timeBox.Text);

                //Checks that the value is greater than 0
                if(temptime > 0)
                {
                    time = temptime;
                    timeErrorBox.Text = "Time: " + time.ToString();
                }

                //Otherwise, and error will print in TimeErrorBox
                else
                {
                    timeErrorBox.Text = "Error: Less than 0";
                }
            }

            //Otherwise, and error will print in TimeErrorBox
            else
            {
                timeErrorBox.Text = "Error: Invalid Input";
            }

            //Clearing TimeBox
            timeBox.Text = "";
        }
    }
}
