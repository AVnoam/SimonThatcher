using System;
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
    public partial class Mode2 : Form
    {
        string[] colorArr = { "red_mode_2", "blue_mode_2" };
        string[] sequenceArr;
        int curClick = 0;
        int howManyTurns;
        string name;
        bool isSimonTurn = true;
        int turn = 0;
        Random rnd = new Random();
        SoundPlayer player_red = new SoundPlayer(Resources.red);
        SoundPlayer player_blue = new SoundPlayer(Resources.blue);


        public Mode2(int howManyTurns, string name)
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
                sequenceArr[i] = colorArr[rnd.Next(2)];

            //makes the pictureboxes disabled
            DisableButtons();

            //responsible for the view and position of the pictureboxes
            pic_circle.Controls.Add(red_mode_2);
            pic_circle.Controls.Add(blue_mode_2);

            int h = pic_circle.Height;
            int w = pic_circle.Width;

            red_mode_2.Left = w / 2 - blue_mode_2.Width - 4;
            blue_mode_2.Left = w / 2;


            blue_mode_2.Top = h / 5;
            red_mode_2.Top = h / 5;

            //sets the progressbar to zero
            panel_progress.Width = 0;
        }
        private void sButClick(object sender, EventArgs e)
        {
            //starts the game
            timer1.Start();
            sButton.Click -= sButClick;
            sButton.Click += Exit;
            sButton.Visible = false;
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
                else
                    player_blue.Play();
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
            else
                player_blue.Play();
            await Task.Delay(300);
            p.Image = Resources.ResourceManager.GetObject(p.Name + "_off") as Image;
            await Task.Delay(300);

            if (sequenceArr[curClick] == p.Name)
            {
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
            red_mode_2.Enabled = false;
            blue_mode_2.Enabled = false;
            red_mode_2.Cursor = Cursors.Default;
            blue_mode_2.Cursor = Cursors.Default;
        }
        private void EnableButtons()
        {
            //Enable all the buttons
            red_mode_2.Enabled = true;
            blue_mode_2.Enabled = true;
            red_mode_2.Cursor = Cursors.Hand;
            blue_mode_2.Cursor = Cursors.Hand;
        }
        private void ULose(int curClick)
        {
            //shows what image the user should have clicked and displays a message
            PictureBox p = pic_circle.Controls[sequenceArr[curClick]] as PictureBox;
            p.Image = Resources.ResourceManager.GetObject(p.Name + "_on") as Image;
            if (p.Name[0] == 'r')
                player_red.Play();
            else
                player_blue.Play();

            sButton.Visible = true;
            sButton.Text = $"Simon won the game click here to return to main menu";

            timer1.Stop();
        }
        private void UWin()
        {
            // tells the user that he won
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
