﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SimonThatcher.Properties;
using System.Windows.Forms;
using ColorSlider;
using System.Media;

namespace SimonThatcher
{
    public partial class Mode4 : Form
    {
        string[] colorArr = { "red_mode_4", "green_mode_4", "blue_mode_4", "yellow_mode_4" };
        string[] sequenceArr;
        int curClick = 0;
        int howManyTurns;
        string name;
        bool isSimonTurn = true;
        int turn = 0;
        Random rnd = new Random();
        SoundPlayer player_red = new SoundPlayer(Resources.red);
        SoundPlayer player_blue = new SoundPlayer(Resources.blue);
        SoundPlayer player_green = new SoundPlayer(Resources.green);
        SoundPlayer player_yellow = new SoundPlayer(Resources.green);


        public Mode4(int howManyTurns, string name)
        {
            InitializeComponent();

            //Make the form unresizable
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            turnLabel.Text = "Turn: " + "Simon";
            //Define the turns as per the parameter
            this.howManyTurns = howManyTurns;
            this.name = name;
            sequenceArr = new string[howManyTurns];
            //Create random predetermined game array.
            for (int i = 0; i < howManyTurns; i++)
                sequenceArr[i] = colorArr[rnd.Next(4)];

            //makes it unable to click the game
            DisableButtons();

            //it is responsible for the view and the positions of the buttons
            pic_circle.Controls.Add(red_mode_4);
            pic_circle.Controls.Add(blue_mode_4);
            pic_circle.Controls.Add(green_mode_4);
            pic_circle.Controls.Add(yellow_mode_4);

            int h = pic_circle.Height;
            int w = pic_circle.Width;

            red_mode_4.Left = w / 2;
            blue_mode_4.Left = w / 2;
            green_mode_4.Left = w / 2 - red_mode_4.Width - 4;
            yellow_mode_4.Left = green_mode_4.Left;


            blue_mode_4.Top = h / 2;
            yellow_mode_4.Top = h / 2;
            red_mode_4.Top = h / 2 - blue_mode_4.Height - 4;
            green_mode_4.Top = red_mode_4.Top;

            //the progres bar is set to zero
            panel_progress.Width = 0;
        }
        private void sButClick(object sender, EventArgs e)
        {
            //starts the game
            sButton.Click -= sButClick;
            sButton.Click += Exit;
            sButton.Visible = false;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //sees if the user won, if not continues the game
            if (turn == howManyTurns) { timer1.Stop(); UWin(); }
            if (isSimonTurn)
            {
                timer1.Stop();
                Simon_Flash();
            }
        }
        private async void Simon_Flash()
        {
            
            //Flashes the simon according to given string array.
            PictureBox curPictureBox;
            string curPicText;
            for (int i = 0; i <= turn; i++)
            {
                curPictureBox = pic_circle.Controls[sequenceArr[i]] as PictureBox;
                curPicText = curPictureBox.Name;

                curPictureBox.Image = Resources.ResourceManager.GetObject(curPicText + "_on") as Image;
                if (curPicText[0] == 'r')
                    player_red.Play();
                else if (curPicText[0] == 'b')
                    player_blue.Play();
                else if (curPicText[0] == 'g')
                    player_green.Play();
                else
                    player_yellow.Play();
                await Task.Delay(750);
                curPictureBox.Image = Resources.ResourceManager.GetObject(curPicText + "_off") as Image;
                if (i != turn - 1)
                    await Task.Delay(250);
                else
                    await Task.Delay(750);
            }

            //switches to the user
            turn++;
            isSimonTurn = false;
            turnLabel.Text = "Turn: " + name;
            EnableButtons();
        }
        private async void simonBClick(object sender, EventArgs e)
        {
            
            //Deal with clicks.
            PictureBox p = sender as PictureBox;
            p.Image = Resources.ResourceManager.GetObject(p.Name + "_on") as Image;
            if (p.Name[0] == 'r')
                player_red.Play();
            else if (p.Name[0] == 'b')
                player_blue.Play();
            else if (p.Name[0] == 'g')
                player_green.Play();
            else
                player_yellow.Play();
            await Task.Delay(300);  
            p.Image = Resources.ResourceManager.GetObject(p.Name + "_off") as Image;
            await Task.Delay(300);

            if (sequenceArr[curClick] == p.Name){
                //If right button is pressed.
                curClick++;
                if (curClick == turn)
                {
                    //If all the right buttons have been clicked start simon.
                    panel_progress.Width += (int)(800.0 / howManyTurns); 
                    turnLabel.Text = "Turn: " + "Simon";
                    DisableButtons();
                    isSimonTurn = true;
                    curClick = 0;
                    await Task.Delay(900);
                    timer1.Start();
                }
            }
            else //If the loser loses.  
            { timer1.Stop(); ULose(curClick); }
        }
        private void DisableButtons()
        {
            //Disables all the buttons
            red_mode_4.Enabled = false;
            green_mode_4.Enabled = false;
            blue_mode_4.Enabled = false;
            yellow_mode_4.Enabled = false;
            red_mode_4.Cursor = Cursors.Default;
            green_mode_4.Cursor = Cursors.Default;
            yellow_mode_4.Cursor = Cursors.Default;
            blue_mode_4.Cursor = Cursors.Default;
        }
        private void EnableButtons()
        {
            //Enable all the buttons
            red_mode_4.Enabled = true;
            green_mode_4.Enabled = true;
            blue_mode_4.Enabled = true;
            yellow_mode_4.Enabled = true;
            red_mode_4.Cursor = Cursors.Hand;
            green_mode_4.Cursor = Cursors.Hand;
            yellow_mode_4.Cursor = Cursors.Hand;
            blue_mode_4.Cursor = Cursors.Hand;
        }
        private void ULose(int curClick)
        {
            //shows what image the user should have clicked and displays a message
            PictureBox p= pic_circle.Controls[sequenceArr[curClick]] as PictureBox;
            p.Image = Resources.ResourceManager.GetObject(p.Name + "_on") as Image;
            if (p.Name[0] == 'r')
                player_red.Play();
            else if (p.Name[0] == 'b')
                player_blue.Play();
            else if (p.Name[0] == 'g')
                player_green.Play();
            else
                player_yellow.Play();

            sButton.Visible = true;
            sButton.Text = "Simon won the game click here to return to main menu";

            timer1.Stop();
        }
        private void UWin()
        {
            //tells the user that he won
            sButton.Visible = true;
            sButton.Text = $"{name} won the game click here to return to main menu";
        }
        private void Exit(object sender, EventArgs e)
        {
            //brings the user back to main menu
            this.Hide(); Form newStart = new StartSimon(); this.Close();
            newStart.ShowDialog();
        }
    }

}
