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

            if (page == 4)
            {
                page = 8;
            }
            else if (page == 11)
            {
                page = 12;
            }

            /// Display text and game options to screen based on the 
            /// current page
            /// 

            switch (page)
            {
                case 8:
                    topLabel.Text = "The dark figure gets lonely and kills you";
                    bottomLabel.Text = "";
                    button1.Text = "Play again";
                    button2.Text = "";
                    button3.Text = "Quit";
                    break;
                case 12:
                    topLabel.Text = "The store explodes and you die...wait...You wake up and realize it was all a dream";
                    bottomLabel.Text = "You look up and see a dark figure staring at you from the doorway. Investigate?";
                    button1.Text = "Yes";
                    button2.Text = "";
                    button3.Text = "No";
                    break;

            }
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
            else if (page == 11)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 4;
            }
            else if (page == 12)
            {
                page = 4;
            }
            else if (page == 10)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 5;
            }
            else if (page == 5)
            {
                randomvalue = randGen.Next(5, 11);
                if (randomvalue < 5)
                {
                    page = 6;
                }
                else
                {
                    page = 2;
                }
            }

            /// Display text and game options to screen based on the 
            /// current page
            switch (page)
            {

                // case 1:
                // topLabel.Text = "";
                // bottomLabel.Text = "";
                // button1.Text = "";
                // button2.Text = "";
                // button3.Text = "";
                // break;


                //application.exit

                case 2:
                    topLabel.Text = "The firgure got nervous and killed you";
                    bottomLabel.Text = "";
                    button1.Text = "Play again";
                    button2.Text = "";
                    button3.Text = "Quit";
                    break;
                case 4:
                    topLabel.Text = "You enter the hall and dont see anything.";
                    bottomLabel.Text = " Where do you go? ";
                    button1.Text = "Go down the hall";
                    button2.Text = "Go back to sleep";
                    button3.Text = "Take the stairs";
                    break;
                case 5:
                    topLabel.Text = "You come across the dark figure in the hallway";
                    bottomLabel.Text = "Interacti with him?";
                    button1.Text = "Yes";
                    button2.Text = "";
                    button3.Text = "No";
                    break;
                case 6:
                    topLabel.Text = "The figure falls deeply in love with you stepping into the light revealing that it was Ryan Reynolds the entire time";
                    bottomLabel.Text = "You live happily ever after";
                    button1.Text = "Play again";
                    button2.Text = "";
                    button3.Text = "Quit";
                    break;
                case 9:
                    topLabel.Text = "You leave to get some milk";
                    bottomLabel.Text = "Do you take your car or take your bike to the store?";
                    button1.Text = "Take the car";
                    button2.Text = "";
                    button3.Text = "Take the bike";
                    pictureBox1.Image = Properties.Resources.carbike;
                    break;
                case 11:
                    topLabel.Text = "You hit a biker on the way but make it to the store safely and enter to buy the milk";
                    bottomLabel.Text = "Buy the milk?";
                    button1.Text = "Buy chocolate milk";
                    button2.Text = "Dont buy milk";
                    button3.Text = "Buy normal milk";
                    pictureBox1.Image = Properties.Resources.milk;
                    break;
                case 14:
                    topLabel.Text = "You purchase some chocolate milk and begin to drive home encountering a homeless man.";
                    bottomLabel.Text = "Give him  some chocolate milk?";
                    button1.Text = "Give him the milk";
                    button2.Text = "";
                    button3.Text = "Dont give him the milk";
                    pictureBox1.Image = Properties.Resources.carbike;
                    break;
                case 15:
                    topLabel.Text = "He gets visibly disappointed in you";
                    bottomLabel.Text = "Change your mind?";
                    button1.Text = "Yes";
                    button2.Text = "";
                    button3.Text = "No";
                    pictureBox1.Image = Properties.Resources.carbike;
                    break;
                case 16:
                    topLabel.Text = "The man gratefully drinks the milk and reveals he is actually Mr.Beast (You just won $10M)";
                    bottomLabel.Text = "Buy more milk?";
                    button1.Text = "Yes";
                    button2.Text = "";
                    button3.Text = "No";
                    pictureBox1.Image = Properties.Resources.carbike;
                    break;
                case 17:
                    topLabel.Text = "You drink too much milk and die due to overconsumption...wait...You wake up and realize it was all a dream";
                    bottomLabel.Text = "You look up and see a dark figure staring at you from the doorway. Investigate?";
                    button1.Text = "Yes";
                    button2.Text = "";
                    button3.Text = "No";
                    pictureBox1.Image = Properties.Resources.carbike;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 3
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 5)
            {
                page = 8;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 11)
            {
                page = 12;
            }
            else if (page == 14)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 18;
            }
            else if (page == 16)
            {
                page = 2;
            }
            else if (page == 18)
            {
                page = 2;
            }
            /// Display text and game options to screen based on the 
            /// current page

            // case 1:
            // topLabel.Text = "";
            // bottomLabel.Text = "";
            // button1.Text = "";
            // button2.Text = "";
            // button3.Text = "";
            // break;

            switch (page)
            {

                case 1:
                    topLabel.Text = "Your fridge has ran out of milk";
                    bottomLabel.Text = "Do you get some from the store?";
                    button1.Text = "Yes";
                    button2.Text = "";
                    button3.Text = "No";
                    break;
                case 2:
                    topLabel.Text = "You die of dehydration ...wait...You wake up and realize it was all a dream";
                    bottomLabel.Text = "You look up and see a dark figure staring at\nyou from the doorway.  Investigate?";
                    button1.Text = "Yes";
                    button2.Text = "";
                    button3.Text = "No";
                    break;
                case 3:
                    topLabel.Text = "You close your eyes to go back to sleep and are killed by the figure almost instantly.";
                    bottomLabel.Text = "";
                    button1.Text = "Play again";
                    button2.Text = "";
                    button3.Text = "Quit";
                    break;
                case 7:
                    topLabel.Text = "You notice a light and investigate. Your fridge has been left open so you check it and notice...Your fridge has ran out of milk";
                    bottomLabel.Text = "Do you get some from the store?";
                    button1.Text = "Yes";
                    button2.Text = "";
                    button3.Text = "No";
                    break;
                case 8:
                    topLabel.Text = "The dark figure gets lonely and kills you";
                    bottomLabel.Text = "";
                    button1.Text = "Play again";
                    button2.Text = "";
                    button3.Text = "Quit";
                    break;
                case 10:
                    topLabel.Text = "You get hit by a car and die...wait...You wake up and realize it was all a dream";
                    bottomLabel.Text = "You look up and see a dark figure staring at you from the doorway. Investigate?";
                    button1.Text = "Yes";
                    button2.Text = "";
                    button3.Text = "No";
                    break;
                case 12:
                    topLabel.Text = "The store explodes and you die....wait...You wake up and realize it was all a dream";
                    bottomLabel.Text = "You look up and see a dark figure staring at you from the doorway. Investigate?";
                    button1.Text = "Yes";
                    button2.Text = "";
                    button3.Text = "No";
                    break;
                case 15:
                    topLabel.Text = "He gets visibly disappointed in you";
                    bottomLabel.Text = "Change your mind?";
                    button1.Text = "Yes";
                    button2.Text = "";
                    button3.Text = "No";
                    break;
                case 16:
                    topLabel.Text = "The man gratefully drinks the milk and reveals he is actually Mr.Beast (You just won $10M)";
                    bottomLabel.Text = "Buy more milk?";
                    button1.Text = "Yes";
                    button2.Text = "";
                    button3.Text = "No";
                    break;
                case 17:
                    topLabel.Text = "You drink too much milk and die due to overconsumption";
                    bottomLabel.Text = "";
                    button1.Text = "Play again";
                    button2.Text = "";
                    button3.Text = "Quit";
                    break;
                case 18:
                    topLabel.Text = "You drink the milk in his face then drive home with no milk...Your fridge has ran out of milk";
                    bottomLabel.Text = "Do you get some from the store?";
                    button1.Text = "Yes";
                    button2.Text = "";
                    button3.Text = "No";
                    break;

            }
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            topLabel.Text = "Im the biggest bird";
            bottomLabel.Text = "Im the biggest bird";
            button1.Text = "Im the biggest bird";
            button2.Text = "Im the biggest bird";
            button3.Text = "Im the biggest bird";
            pictureBox1.Image = Properties.Resources.bird;
        }
    }
}

