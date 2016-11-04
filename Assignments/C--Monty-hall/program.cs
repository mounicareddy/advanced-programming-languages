/* --------------------------------------------------------------------------------------------------------------------------------
 * Project 2:Monty Hall Problem
 * CMPS 5113 Advanced Programming Languages
 * Team Members: Madireddy Mounika 13
 *               Akuthota Mounika 02
 *               Sheema Rohi 23
 *Description: This program is a simulation of monty hall program which asks the user to pick a door,if they select the choice
 * in which a car is hidden then the user wins a car if not consolation prize of goat is given to the door. 
--------------------------------------------------------------------------------------------------------------------------------*/





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int won = 0;//initializing variables won and lost to 0
        int lost = 0;

  

        static Random _random = new Random();
        int car = _random.Next(1, 4);//picking a random number as a car
        int opendoor;
        int choice;
        //int won=0;
        //int lost=0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        public void randomGoat(int choice, int car)
        {
            while (true)//this loop executes until randomgoat is not choice and car.
            {
                // Random goat can be 0, 1 or 2.
                int randomGoat = _random.Next(1, 4);
                // Random goat cannot be the current choice or a car.
                if (randomGoat == choice ||
                randomGoat == car)
                {
                    continue;
                }
                // Return random goat.
                else
                {
                    opendoor = randomGoat;//This loop is tells which door to open a randomgoat.
                   if (opendoor == 2)
                    {   
                        Door2.Image = WindowsFormsApplication1.Properties.Resources.goat;
                        break;
                    }
                    else if (opendoor == 3)
                    {
                        Door3.Image = WindowsFormsApplication1.Properties.Resources.goat;
                        break;
                    }
                    else
                    {
                        Door1.Image = WindowsFormsApplication1.Properties.Resources.goat;
                        break;
                    }

                }
            }
            label5.Text = "do you want to switch or keep";//This will ask the user whether to switch or keep their choice.
        }

       

        private void showbuttons()
        {
            var Button2 = new Button();//dynamically creates a button  'keep' when this method is called.
            Button2.Text = " keep";
            this.Controls.Add(Button2);
            Button2.Location = new Point(60, 180);//creates a button at particular location
            Button2.Click += (object sender, EventArgs e) =>
            {
                if (choice == car)// if users selected choice and car is in that choice and if they selected keep button then he wins a car.
                {   
                    label5.Text = " congratulations!!! you won a car";
                    won++;
                    wongames.Text = "" + won;
                    

                    //showcar();
                }
                else
                {

                    int i;
                    for (i = 1; i <= 3; i++)
                    {
                        if (i == choice || i == opendoor)
                        {

                        }
                        else
                        {
                            break;
                        }
                    }
                    if (i == 1)
                    {
                        label7.Text="1";
                    }
                    else if (i == 2)
                    {
                        label7.Text = "2";
                    }
                    else
                    {
                        label7.Text = "3";
                    }
                
                label5.Text = "sorry you lost";
                    //if choice is switched and car is not present in it then user will loose.
                    // Button.Visible = false;
                    //Button1.Visible = false;

                    lost++;
                    lostgames.Text = " " + lost;
                    // showgoat();
                }
                
                showcar();
                showgoat();

            };

            var Button1 = new Button();//dynamically creates a button exchange 
            Button1.Text = " exchange";
            this.Controls.Add(Button1);
            Button1.Location = new Point(160, 180);//specifies the location for that button
                                                   // Button.Visible = false;
            Button1.Visible = true;
            Button1.Click += (object sender, EventArgs e) =>
            {
                
                if (choice == car)
                {
                    int i;
                    for (i = 1; i <= 3; i++)
                    {
                        if (i == choice || i == opendoor)
                        {

                        }
                        else
                        {
                            break;
                        }
                    }
                    if (i == 1)
                    {
                        label7.Text = "1";
                    }
                    else if (i == 2)
                    {
                        label7.Text = "2";
                    }
                    else
                    {
                        label7.Text = "3";
                    }


                    label5.Text = "you lost";//if the user exhanges his choice the door which does not have car then user looses.
                    lost++;//incrementing no of lostgames
                    lostgames.Text = " " + lost;
                    //Button1.Visible = false;
                    // Button.Visible = false;
                    //showcar();
                }
                else
                {

                    int i;
                    for (i = 1; i <= 3; i++)
                    {
                        if (i == choice || i == opendoor)
                        {

                        }
                        else
                        {
                            break;
                        }
                    }
                    if (i == 1)
                    {
                        label7.Text = "1";
                    }
                    else if (i == 2)
                    {
                        label7.Text = "2";
                    }
                    else
                    {
                        label7.Text = "3";
                    }
                    label5.Text = "you won";//if the user exchanges his choice to the door which has car in it then he wins. 
                    won++;
                    wongames.Text = "" + won;//incrementing no of gameswon
                    // Button.Visible = false;
                    //Button1.Visible = false;
                    // showgoat();
                }
                showcar();
                showgoat();
            };
             //Button2.Visible = false;
            //Button1.Visible = false;
        }

        private void showgoat()//this method is used to show goat in a doors.
        {
            int i;
            for (i = 1; i <= 3; i++)
            {
                if (i == car || i == opendoor)
                {

                }
                else
                {
                    break;
                }
            }
            if (i == 1)
            {
                Door1.Image = WindowsFormsApplication1.Properties.Resources.goat;
            }
            else if (i == 2)
            {
                Door2.Image = WindowsFormsApplication1.Properties.Resources.goat;
            }
            else
            {
                Door3.Image = WindowsFormsApplication1.Properties.Resources.goat;
            }
        }

        private void showcar()//this method is used to show car in desired doors.
        {
            if (car == 1)
            {
                Door1.Image = WindowsFormsApplication1.Properties.Resources.car;
            }
            else if (car == 2)
            {
                Door2.Image = WindowsFormsApplication1.Properties.Resources.car;
            }
            else
            {
                Door3.Image = WindowsFormsApplication1.Properties.Resources.car;
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)//this method is called when click event is occured on picturebox1.
        {

            choice = 1;
            label7.Text = "1";// Button.Visible = false;

            randomGoat(choice, car);//call to randomGoat();
            showbuttons();//call  to showbutton();


        }

        private void pictureBox2_Click(object sender, EventArgs e)//this method is called when a click event is done on picturebox2
        {
            choice = 2;
            label7.Text = "2";
            randomGoat(choice, car);
            showbuttons();
        }

        private void pictureBox3_Click(object sender, EventArgs e)//this method is called when a click event is done on picturebox3
        {
            choice = 3;
            label7.Text = "3";
            randomGoat(choice, car);
            showbuttons();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           loadagain();
        }

        private void loadagain()
        {
            Door1.Image = WindowsFormsApplication1.Properties.Resources.door1;
            Door2.Image = WindowsFormsApplication1.Properties.Resources.door2;

            Door3.Image = WindowsFormsApplication1.Properties.Resources.door3;
            label7.Text = "";
            label5.Text = "select a door by clicking on it";
            //label10.visible = false;
            //Button1.Visible = false;
            //Button2.Visible = false; 
            
        }
    }
}
