using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimonThatcher.Properties;
using System.Drawing.Drawing2D;


namespace SimonThatcher
{
    public partial class StartSimon : Form
    {

        RoundedButton rb = new RoundedButton();
        string[] colorArr = { "red_mode_4", "green_mode_4", "blue_mode_4", "yellow_mode_4" };
        Random rnd = new Random();
        int how_much_buttons = 2;
        bool submit_name_tb_click = false;
        int turns = 10;
        string name;


        public StartSimon()
        {
            //Make the form unresizable
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            //sets the panels location
            gRL_play.Location = new Point(0, 0);
            gRL_difficulty.Location = new Point(0, 0);
            gRL_howto.Location = new Point(0, 0);
            pic_circle.Location = new Point(gRL_play.Width - pic_circle.Width - 30, 0);
            b_play.FlatAppearance.MouseOverBackColor = Color.Salmon;

            //sets the menubutoons apearens
            b_play.FlatAppearance.BorderSize = 0;
            b_difficulty.FlatAppearance.BorderSize = 0;
            b_play.FlatAppearance.BorderSize = 0;
            b_howto.FlatAppearance.BorderSize = 0;

            //sets the view and position of the animation
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
            red_mode_4.Top = h / 2 - blue_mode_4.Height + 4;
            green_mode_4.Top = red_mode_4.Top;

            //had a little problems with the picture boxes and the text above it
            Label l_10 = new Label { Name = "l_10" };
            Label l_50 = new Label { Name = "l_50" };
            Label l_100 = new Label { Name = "l_100" };
            Label l_rnd = new Label { Name = "l_rnd" };

            pic_10.Controls.Add(l_10);
            pic_50.Controls.Add(l_50);
            pic_100.Controls.Add(l_100);
            pic_rnd.Controls.Add(l_rnd);

            l_10.Text = "10";
            l_50.Text = "50";
            l_100.Text = "100";
            l_rnd.Text = "Random \n1-100";

        }
        private void StartSimon_Load(object sender, EventArgs e)
        {
            //part of the last comment, this makes a new text on every picture box, so i dont need to click the real text 
            int pic_turns_size = pic_10.Height;

            foreach (Control crl in gRL_difficulty.Controls)
            {
                if (crl is PictureBox && crl.Name.Contains("pic_"))
                    foreach (Control crl_l in crl.Controls)
                    {
                        if (crl_l is Label && crl_l.Name.Contains("l_"))
                        {
                            (crl_l as Label).Size = new Size(pic_turns_size, pic_turns_size);
                            (crl_l as Label).TextAlign = ContentAlignment.MiddleCenter;
                            (crl_l as Label).Enabled = false;
                            (crl_l as Label).Paint += Set_Words;
                            (crl_l as Label).Text = "";
                        }
                    }
            }
        }
        public void Set_Words(object sender, PaintEventArgs e)
        {
            //sets the fake text ontop the picture boxes
            Label l = sender as Label;
            int height = l.Height / 2 - l.Height / 5 - l.Height/20 ;
            int width = l.Width / 2 - l.Width / 5;
            string str = "Random\n  1-100";

            if (l.Name == "l_10")
                str = "\n 10";
            else if (l.Name == "l_50")
                str = "\n 50";
            else if (l.Name == "l_100")
                str = "\n100";
            else
            { height = l.Height / 2 - l.Height / 6; width = l.Width / 2 - l.Width / 3; }

                e.Graphics.DrawString(str, new Font("Microsoft Sans Serif", 8), Brushes.Black, new Point(width, height));

        }
        private async void t_on_off_Tick(object sender, EventArgs e)
        {
            //responsible for the activation and the continuation of the animation in the start panel
            PictureBox curPictureBox;
            string curPicText;
            curPictureBox = pic_circle.Controls[colorArr[rnd.Next(4)]] as PictureBox;

            curPicText = curPictureBox.Name;

            curPictureBox.Image = Resources.ResourceManager.GetObject(curPicText + "_on") as Image;
            await Task.Delay(500);
            curPictureBox.Image = Resources.ResourceManager.GetObject(curPicText + "_off") as Image;
        }



        private void Play_Click(object sender, EventArgs e)
        {
            //if you click on the start button on the menu it will show the play panel and change the buttons color and activates the animation
            b_play.BackColor = Color.Salmon;
            b_difficulty.BackColor = Color.FromArgb(64, 64, 64);
            b_howto.BackColor = Color.FromArgb(64, 64, 64);

            b_difficulty.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
            b_play.FlatAppearance.MouseOverBackColor = Color.Salmon;
            b_howto.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);

            gRL_howto.Visible = false;
            gRL_difficulty.Visible = false;
            gRL_play.Visible = true;

            t_on_off.Start();
        }
        private void tb_name_click(object sender, EventArgs e)
        {
            //if you click to set your name it will delete the defult name already there
            if (!submit_name_tb_click)
                tb_name.Clear();
            submit_name_tb_click = true;
        }
        private void roundedButton1_Click(object sender, EventArgs e)
        {
            //checks your name and if it is not a lasy one it will show you a button that will send you to the game
            if (tb_name.Text == "Name" || tb_name.Text == "Be Original" || tb_name.Text == "Try Again")
            {
                tb_name.Text = "Be Original";
                submit_name_tb_click = false;
            }
            else if (tb_name.Text.Length > 1)
            {
                t_on_off.Stop();
                name = tb_name.Text;
                CreatButton();
            }
            else
            {
                tb_name.Text = "Try Again";
                submit_name_tb_click = false;
            }
        }
        private void CreatButton()
        {
            //sets the play button
            rb.Degree = 240;
            rb.Size = new Size(240, 240);
            rb.Name = "rb_play";
            pic_circle.Controls.Add(rb);
            rb.FlatStyle = FlatStyle.Flat;
            rb.FlatAppearance.BorderSize = 0;
            rb.Left = green_mode_4.Left - 5;
            rb.Top = green_mode_4.Top;
            rb.Cursor = Cursors.Hand;
            rb.BackColor = Color.FromArgb(208, 38, 68);
            rb.Text = "Play";
            rb.Font = new Font("Microsoft Sans Serif", 40);
            rb.BringToFront();
            rb.Click += Change_To_Game;
        }
        private void Change_To_Game(object sender, EventArgs e)
        {
            //after you clicked 'start' it will send you to the forms with the amount of buttons you choose
            this.Hide();
            Form mode2 = new Mode2(turns, name);
            Form mode3 = new Mode3(turns, name);
            Form mode4 = new Mode4(turns, name);
            if (how_much_buttons == 2)
                mode2.ShowDialog();
            else if(how_much_buttons == 3)
                mode3.ShowDialog();
            else if (how_much_buttons == 4)
                mode4.ShowDialog();
            this.Close();
        }


        private void Difficulty_Click(object sender, EventArgs e)
        {
            //if you click on the difficulty button on the menu it will show the difficulty panel and change the buttons color and deactivates the animation
            b_play.BackColor = Color.FromArgb(64, 64, 64);
            b_difficulty.BackColor = Color.FromArgb(0, 192, 192);
            b_howto.BackColor = Color.FromArgb(64, 64, 64);

            b_play.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
            b_difficulty.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            b_howto.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);

            gRL_howto.Visible = false;
            gRL_difficulty.Visible =true;
            gRL_play.Visible = false;

            t_on_off.Stop();
        }
        private void Select_Deficulty(object sender, EventArgs e)
        {
            //sets how many turns you want
            PictureBox p = sender as PictureBox;
            nup_hm_turns.BackColor = Color.White;
            pic_10.Image = Resources.white_circle;
            pic_50.Image = Resources.white_circle;
            pic_100.Image = Resources.white_circle;
            pic_rnd.Image = Resources.white_circle;

            p.Image = Resources.gray_circle;
            if (p.Name.Substring(4) == "rnd")
                turns = rnd.Next(1, 101);
            else
                turns = int.Parse(p.Name.Substring(4));
        }
        private void cS_difficulty_Scroll(object sender, ScrollEventArgs e)
        {
            //changes the amount of buttons that will apear if you click play, and displays a picture of what it will look like
            if (cS_difficulty.Value == 2)
                cS_difficulty.ThumbImage = Resources.mode_2_logo;
            else if (cS_difficulty.Value== 3)
                cS_difficulty.ThumbImage = Resources.mode_3_logo;
            else if (cS_difficulty.Value == 4)
                cS_difficulty.ThumbImage = Resources.mode_4_logo;
            how_much_buttons = Convert.ToInt32(cS_difficulty.Value);
        }
        private void nup_hm_turns_ValueChanged(object sender, EventArgs e)
        {
            //responsible for how many turns you want also
            NumericUpDown nup = sender as NumericUpDown;
            pic_10.Image = Resources.white_circle;
            pic_50.Image = Resources.white_circle;
            pic_100.Image = Resources.white_circle;
            pic_rnd.Image = Resources.white_circle;

            nup.BackColor = Color.LightGray;
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            //sets the amount of turns you wrote
            if (nup_hm_turns.BackColor == Color.Gray)
                turns = Convert.ToInt32(nup_hm_turns.Value);
        }
        

        private void How_To_Click(object sender, EventArgs e)
        {
            //if you click on the how to button on the menu it will show the how to panel and change the buttons color and deactivates the animation
            b_howto.BackColor = Color.FromArgb(220, 214, 95);
            b_play.BackColor = Color.FromArgb(64, 64, 64);
            b_difficulty.BackColor = Color.FromArgb(64, 64, 64);

            b_howto.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 214, 95);
            b_difficulty.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
            b_play.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);

            gRL_howto.Visible = true;
            gRL_difficulty.Visible = false;
            gRL_play.Visible = false;

            t_on_off.Stop();
        }


        private void pic_Exit_Click(object sender, EventArgs e)
        {
            //exits the game
            Application.Exit();
        }
    }
}
