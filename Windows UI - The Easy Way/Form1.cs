using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_UI___The_Easy_Way
{
    public partial class Form1 : Form
    {
        //Fields
        protected int counter;



        public Form1()
        {
            //Always keep this method
            InitializeComponent();

            //Instantiat Fields
            counter = 0;
        }



        //Button Click Methods
        //Increment Button Method
        private void ButtonIncrementClick(object sender, EventArgs e)
        {
            counter++;
            textCounter.Text = counter.ToString();
        }

        //Decrement Button Method
        private void ButtonDecrementClick(object sender, EventArgs e)
        {
            counter--;
            textCounter.Text = counter.ToString();
        }

        //Reset Button Method
        private void ButtonResetMethod(object sender, EventArgs e)
        {
            counter = 0;
            textCounter.Text = counter.ToString();
        }
    }
}
