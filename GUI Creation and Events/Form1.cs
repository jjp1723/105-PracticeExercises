using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Creation_and_Events
{
    public partial class Form1 : Form
    {
        //Fields
        protected List<Button> wires;
        protected double time;
        protected bool gameStart;
        protected bool redWire;
        protected bool lastWhite;
        protected int moreBlue;



        public Form1()
        {
            InitializeComponent();

            gameStart = false;

            //Instantiating the List of buttons and adding the buttons to the list
            wires = new List<Button>();
            wires.Add(wire1);
            wires.Add(wire2);
            wires.Add(wire3);
            wires.Add(wire4);
            wires.Add(wire5);

            ruleBox1.Text = "Rule #1: If there are no red wires, cut the second wire";
            ruleBox2.Text = "Rule #2: Otherwise, if the last wire is white, cut the last wire";
            ruleBox3.Text = "Rule #3: Otherwise, if there is more than one blue wire, cut the last blue wire";
            ruleBox4.Text = "Rule #4: Otherwise, cut the last wire";
        }


        //Event Handlers
        //Wire button click Event Handler
        private void WireCut(object sender, EventArgs e)
        {
            //The event only functions if the game is being played
            if(gameStart)
            {
                // --------------- Code that will be referenced later for Rule #3 ---------------

                //Creating an int that will count the amount of blue wires
                moreBlue = 0;
                Button lastBlueForThisDumbMethodThatWontAcceptTheExistingOne = startButton;

                //Determining if there is more than 1 blue, and whether the button selected is
                foreach (Button wire in wires)
                {
                    //Increments the moreBlue variable if wire is blue
                    if (wire.BackColor == Color.Blue)
                    {
                        moreBlue++;
                    }

                    //If there are multiple blue wires, the current blue wire is set as the last blue wire
                    if (moreBlue > 1 && wire.BackColor == Color.Blue)
                    {
                        lastBlueForThisDumbMethodThatWontAcceptTheExistingOne = wire;
                    }
                }






                // --------------- Code for Rule #1 ---------------

                //Determining if there are no reds
                if (!redWire)
                {
                    //Determining that the wire picked is the second wire
                    if (sender == wire2)
                    {
                        timer1.Stop();
                        resultBox.Text = "Congradulations!  You defused the bomb in " + time.ToString() + " seconds!";

                        //Reactivating the start button and changing its text
                        startButton.Enabled = true;
                        startButton.Text = "Reset";
                    }

                    //If the wire picked is not the second wire, the bomb is set off
                    else
                    {
                        timer1.Stop();
                        resultBox.Text = "Oh no!  Cut the wrong wire and set off the bomb!";

                        //Reactivating the start button and changing its text
                        startButton.Enabled = true;
                        startButton.Text = "Reset";
                    }
                }



                // --------------- Code for Rule #2 ---------------

                //Determining if the last wire is white
                else if(lastWhite)
                {
                    //Determining that the wire picked is the last wire
                    if(sender == wire5)
                    {
                        timer1.Stop();
                        resultBox.Text = "Congradulations!  You defused the bomb in " + time.ToString() + " seconds!";

                        //Reactivating the start button and changing its text
                        startButton.Enabled = true;
                        startButton.Text = "Reset";
                    }
                    
                    //If the wire picked is not the last wire, the bomb is set off
                    else
                    {
                        timer1.Stop();
                        resultBox.Text = "Oh no!  You cut the wrong wire and set off the bomb!";

                        //Reactivating the start button and changing its text
                        startButton.Enabled = true;
                        startButton.Text = "Reset";
                    }
                }



                // --------------- Code for Rule #3 ---------------

                //Determining if there is more than one blue wire
                else if (moreBlue > 1)
                {
                    //Determining that the wire picked is the last blue wire
                    if (sender == lastBlueForThisDumbMethodThatWontAcceptTheExistingOne)
                    {
                        timer1.Stop();
                        resultBox.Text = "Congradulations!  You defused the bomb in " + time.ToString() + " seconds!";

                        //Reactivating the start button and changing its text
                        startButton.Enabled = true;
                        startButton.Text = "Reset";
                    }

                    //If the wire picked is not the last blue wire, the bomb is set iff
                    else
                    {
                        timer1.Stop();
                        resultBox.Text = "Oh no!  You cut the wrong wire and set off the bomb!";

                        //Reactivating the start button and changing its text
                        startButton.Enabled = true;
                        startButton.Text = "Reset";
                    }
                }



                // ---------------Code for Rule #4 ---------------

                //Determining that the wire picked is the last wire as long as the other conditions haven't been met
                else if(sender == wire5)
                {
                    timer1.Stop();
                    resultBox.Text = "Congradulations!  You defused the bomb in " + time.ToString() + " seconds!";

                    //Reactivating the start button and changing its text
                    startButton.Enabled = true;
                    startButton.Text = "Reset";
                }



                //If the user does not pick the last wire, the bomb is set off
                //If the wire picked is not the last wire, the bomb is set off
                else
                {
                    timer1.Stop();
                    resultBox.Text = "Oh no!  You cut the wrong wire and set off the bomb!";

                    //Reactivating the start button and changing its text
                    startButton.Enabled = true;
                    startButton.Text = "Reset";
                }
            }
        }





        //Start button's Click Event Handler
        private void StartButtonClick(object sender, EventArgs e)
        {
            //Creating a random variable to generat colors for the buttons
            Random rng = new Random();

            //Initially setting color-related booleans to false
            redWire = false;
            lastWhite = false;



            //Generating random colors for each wire buttons
            foreach (Button wire in wires)
            {
                int colorNumber = (int)rng.Next(5);

                switch (colorNumber)
                {
                    //Sets the button's color to red
                    case 0:
                        wire.BackColor = Color.Red;
                        redWire = true;
                        break;

                    //Sets the button's color to blue
                    case 1:
                        wire.BackColor = Color.Blue;
                        break;

                    //Sets the button's color to yellow
                    case 2:
                        wire.BackColor = Color.Yellow;
                        break;

                    //Sets the button's color to black
                    case 3:
                        wire.BackColor = Color.Black;
                        break;

                    //Sets the button's color to white
                    case 4:
                        wire.BackColor = Color.White;

                        //If the current wire is the last wire, lastWhite is set to true
                        if(wire == wire5)
                        {
                            lastWhite = true;
                        }
                        break;
                }

                //Activating the wire
                wire.Enabled = true;
            }

            //Starting the timer
            time = 0;
            progressBar.Value = 0;
            timer1.Start();
            this.TimerTick(sender, e);

            //Clears the text of the Start Game button
            startButton.Text = "";

            //Setting the gameStart boolean to true
            gameStart = true;

            //Clearing the Results textbox
            resultBox.Text = "";

            //Deactivating the start button
            startButton.Enabled = false;
        }




		/// The Form Load event occurs after the form and all
		/// of its components are created, and just before
		/// the user can interact with it for the first time
        /// 
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }



        //Timer's Tick Event Handler
        private void TimerTick(object sender, EventArgs e)
        {
            //If the progress bar fills, the timer stops
            if (progressBar.Value == 100)
            {
                timer1.Stop();
                gameStart = false;

                //Informing the user that they have failed
                resultBox.Text = "Oh no!  You ran out of time and the bomb went off!";

                //Reactivating the start button and changing its text
                startButton.Enabled = true;
                startButton.Text = "Reset";
            }

            //Incrementing time by lower values to make the time displayed accurate
            time += 0.25;
            timeBox.Text = ((int)time).ToString() + " Seconds";

            if(time % 1 == 0)
            {
                progressBar.Value += 10;
            }
        }
    }
}
