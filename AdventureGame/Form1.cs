using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        int page = 1;
        
        Random randGen = new Random();
        int randomvalue;

        public Form1()
        {
            InitializeComponent();

            // Display initial message and options
            topLabel.Text = "Your fridge has ran out of milk";
            bottomLabel.Text = "Do you get some from the store?";
            button1.Text = "Yes";
            button2.Text = "";
            button3.Text = "No";
            pictureBox1.Image = Properties.Resources.fridge;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 2


            /// Display text and game options to screen based on the 
            /// current page
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1
            if (page == 1)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 11;
            }
            else if (page == 14)

                /// Display text and game options to screen based on the 
                /// current page
                switch (page)
                {
                    case 9:
                        topLabel.Text = "You leave to get some milk";
                        bottomLabel.Text = "Do you take your car or take your bike to the store?";
                        button1.Text = "Take the car";
                        button2.Text = "";
                        button3.Text = "Take the bike";
                        pictureBox1.Image = Properties.Resources.carbike;
                        break;
                    case 11:
                        topLabel.Text = "You hit a biker on the way but make it to the store safely";
                        bottomLabel.Text = "Do you take your car or take your bike to the store?";
                        break;
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 3


            /// Display text and game options to screen based on the 
            /// current page
        }
    }
}
