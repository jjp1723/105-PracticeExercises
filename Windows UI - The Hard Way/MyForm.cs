using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Windows_UI___The_Hard_Way
{
    class MyForm : Form
    {
        //Constructor
        public MyForm()
        {
            //Changing the properties of the window
            this.Text = "A Whole New Window!";
            this.Size = new System.Drawing.Size(550, 550);



            //Creating nested loops that adds 100 buttons in a 10x10 grid
            for (int row = 0; row < 10; row++)
            {
                for(int collumn = 0; collumn < 10; collumn++)
                {
                    //Setting x and y coordiantes for the button using "row" and "collumn" variables
                    int x = collumn * 50;
                    int y = row * 50;

                    //Create a button to interact with
                    Button button = new Button();
                    button.Size = new Size(50, 50);
                    button.Location = new Point(x, y);
                    button.Text = "Click me!";

                    button.Click += ButtonClick;

                    //Add the button to the borm's list of Controls
                    this.Controls.Add(button);
                }
            }
        }

        //Code for clicking the button
        private void ButtonClick(object clicker, EventArgs e)
        {
            // The "clicker" object is the event
            if (clicker is Button)
            {
                // Cast the user back to a button
                Button OGButton = (Button)clicker;

                // Change the color
                OGButton.BackColor = Color.Red;
            }

        }
    }
}
