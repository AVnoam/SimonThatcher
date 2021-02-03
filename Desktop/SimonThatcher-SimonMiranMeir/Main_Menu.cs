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

namespace SimonThatcher
{
    public partial class SimonMiranMeir : Form
    {
        public SimonMiranMeir()
        {
            InitializeComponent();
            //sButton.FlatAppearance.BorderSize = 0;
            for (int i = 0; i <= sequenceArr.Length; i++)
                sequenceArr[0] = colorArr[rnd.Next(4)];

        }

        string[] colorArr = { "red", "green", "blue", "yellow" };
        string[] sequenceArr = new string[1];
        bool isSimonTurn = true;
        int turn = 0;
        Random rnd = new Random();
        private void sButClick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void  timer1_Tick(object sender, EventArgs e)
        {
            if (isSimonTurn) 
            {
                timer1.Stop();
                Simon_Flash();
                
            }
            else
            {

            }
            //Task.Delay(1000).ContinueWith(t => bar());
            //Console.WriteLine("SEDCOND");
            if (turn == 10) timer1.Enabled = false;
        }

        private async void Simon_Flash()
        {
            //Flashes the simon according to given string array.
            PictureBox curPictureBox;
            string curPicText;
            for (int i = 0; i <= turn; i++)
            {
                //Console.WriteLine($"I: {i}");
                curPictureBox = Controls[sequenceArr[i]] as PictureBox;
                curPicText = curPictureBox.Name ;
                curPictureBox.Image =  Resources.ResourceManager.GetObject(curPicText + "_on") as Image;
                await Task.Delay(1000);
                curPictureBox.Image = Resources.ResourceManager.GetObject(curPicText + "_off") as Image;
                await Task.Delay(1000);
            }
            Array_Turn_Inlarger();
            timer1.Start();
           

        }
        public void make_Array_bigger()
        {
            Array.Resize(ref sequenceArr, turn+1);
            sequenceArr[turn] = colorArr[rnd.Next(4)];
            //Console.WriteLine($"Lengh: { sequenceArr.Length}");
        }

        private void simonBClick(object sender, EventArgs e)
        {

        }

        private void SimonMiranMeir_Load(object sender, EventArgs e)
        {
            
        }
        private void Array_Turn_Inlarger()
        {
            turn++;
            make_Array_bigger();
        }

    }
}
