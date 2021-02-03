namespace SimonThatcher
{
    partial class StartSimon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartSimon));
            this.t_on_off = new System.Windows.Forms.Timer(this.components);
            this.p_menu = new System.Windows.Forms.Panel();
            this.b_howto = new System.Windows.Forms.Button();
            this.b_difficulty = new System.Windows.Forms.Button();
            this.b_play = new System.Windows.Forms.Button();
            this.gRL_play = new SimonThatcher.Gradient_RL();
            this.roundedButton1 = new SimonThatcher.RoundedButton();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tx_name = new System.Windows.Forms.TextBox();
            this.gRL_howto = new SimonThatcher.Gradient_RL();
            this.l_HT5 = new System.Windows.Forms.Label();
            this.l_HT4 = new System.Windows.Forms.Label();
            this.l_HT3 = new System.Windows.Forms.Label();
            this.l_HT2 = new System.Windows.Forms.Label();
            this.l_HT1 = new System.Windows.Forms.Label();
            this.gRL_difficulty = new SimonThatcher.Gradient_RL();
            this.l_turns = new System.Windows.Forms.Label();
            this.l_amounmt = new System.Windows.Forms.Label();
            this.nup_hm_turns = new System.Windows.Forms.NumericUpDown();
            this.bt_submit = new System.Windows.Forms.Button();
            this.pic_Exit = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.red_mode_4 = new System.Windows.Forms.PictureBox();
            this.blue_mode_4 = new System.Windows.Forms.PictureBox();
            this.yellow_mode_4 = new System.Windows.Forms.PictureBox();
            this.green_mode_4 = new System.Windows.Forms.PictureBox();
            this.pic_circle = new System.Windows.Forms.PictureBox();
            this.pic_50 = new System.Windows.Forms.PictureBox();
            this.pic_100 = new System.Windows.Forms.PictureBox();
            this.pic_rnd = new System.Windows.Forms.PictureBox();
            this.pic_10 = new System.Windows.Forms.PictureBox();
            this.cS_difficulty = new ColorSlider.ColorSlider();
            this.p_menu.SuspendLayout();
            this.gRL_play.SuspendLayout();
            this.gRL_howto.SuspendLayout();
            this.gRL_difficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_hm_turns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_mode_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_mode_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow_mode_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_mode_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_circle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_10)).BeginInit();
            this.SuspendLayout();
            // 
            // t_on_off
            // 
            this.t_on_off.Enabled = true;
            this.t_on_off.Interval = 550;
            this.t_on_off.Tick += new System.EventHandler(this.t_on_off_Tick);
            // 
            // p_menu
            // 
            this.p_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_menu.Controls.Add(this.pic_Exit);
            this.p_menu.Controls.Add(this.b_howto);
            this.p_menu.Controls.Add(this.b_difficulty);
            this.p_menu.Controls.Add(this.b_play);
            this.p_menu.Controls.Add(this.pic_logo);
            this.p_menu.Location = new System.Drawing.Point(548, 0);
            this.p_menu.Name = "p_menu";
            this.p_menu.Size = new System.Drawing.Size(258, 451);
            this.p_menu.TabIndex = 16;
            // 
            // b_howto
            // 
            this.b_howto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b_howto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_howto.FlatAppearance.BorderSize = 0;
            this.b_howto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.b_howto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_howto.Location = new System.Drawing.Point(-4, 234);
            this.b_howto.Name = "b_howto";
            this.b_howto.Size = new System.Drawing.Size(262, 68);
            this.b_howto.TabIndex = 3;
            this.b_howto.Text = "HOW TO PLAY";
            this.b_howto.UseVisualStyleBackColor = false;
            this.b_howto.Click += new System.EventHandler(this.How_To_Click);
            // 
            // b_difficulty
            // 
            this.b_difficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b_difficulty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_difficulty.FlatAppearance.BorderSize = 0;
            this.b_difficulty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.b_difficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_difficulty.Location = new System.Drawing.Point(-4, 166);
            this.b_difficulty.Name = "b_difficulty";
            this.b_difficulty.Size = new System.Drawing.Size(265, 68);
            this.b_difficulty.TabIndex = 2;
            this.b_difficulty.Text = "DIFFICULTY";
            this.b_difficulty.UseVisualStyleBackColor = false;
            this.b_difficulty.Click += new System.EventHandler(this.Difficulty_Click);
            // 
            // b_play
            // 
            this.b_play.BackColor = System.Drawing.Color.Salmon;
            this.b_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_play.FlatAppearance.BorderSize = 0;
            this.b_play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.b_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_play.Location = new System.Drawing.Point(0, 101);
            this.b_play.Name = "b_play";
            this.b_play.Size = new System.Drawing.Size(258, 68);
            this.b_play.TabIndex = 1;
            this.b_play.Text = "PLAY";
            this.b_play.UseVisualStyleBackColor = false;
            this.b_play.Click += new System.EventHandler(this.Play_Click);
            // 
            // gRL_play
            // 
            this.gRL_play.ColorLeft = System.Drawing.Color.Salmon;
            this.gRL_play.ColorRight = System.Drawing.Color.Brown;
            this.gRL_play.Controls.Add(this.roundedButton1);
            this.gRL_play.Controls.Add(this.tb_name);
            this.gRL_play.Controls.Add(this.red_mode_4);
            this.gRL_play.Controls.Add(this.blue_mode_4);
            this.gRL_play.Controls.Add(this.yellow_mode_4);
            this.gRL_play.Controls.Add(this.green_mode_4);
            this.gRL_play.Controls.Add(this.pic_circle);
            this.gRL_play.Controls.Add(this.tx_name);
            this.gRL_play.Location = new System.Drawing.Point(40, 3);
            this.gRL_play.Name = "gRL_play";
            this.gRL_play.Size = new System.Drawing.Size(550, 452);
            this.gRL_play.TabIndex = 0;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.White;
            this.roundedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton1.Degree = 20;
            this.roundedButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.ForeColor = System.Drawing.Color.Black;
            this.roundedButton1.Location = new System.Drawing.Point(358, 25);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(90, 32);
            this.roundedButton1.TabIndex = 28;
            this.roundedButton1.Text = "Submit";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tb_name.Location = new System.Drawing.Point(108, 25);
            this.tb_name.MaxLength = 10;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(232, 30);
            this.tb_name.TabIndex = 27;
            this.tb_name.Text = "Name";
            this.tb_name.Click += new System.EventHandler(this.tb_name_click);
            // 
            // tx_name
            // 
            this.tx_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tx_name.Location = new System.Drawing.Point(81, 101);
            this.tx_name.Name = "tx_name";
            this.tx_name.Size = new System.Drawing.Size(367, 56);
            this.tx_name.TabIndex = 22;
            // 
            // gRL_howto
            // 
            this.gRL_howto.ColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(95)))));
            this.gRL_howto.ColorRight = System.Drawing.Color.Gold;
            this.gRL_howto.Controls.Add(this.l_HT5);
            this.gRL_howto.Controls.Add(this.l_HT4);
            this.gRL_howto.Controls.Add(this.l_HT3);
            this.gRL_howto.Controls.Add(this.l_HT2);
            this.gRL_howto.Controls.Add(this.l_HT1);
            this.gRL_howto.Location = new System.Drawing.Point(9, 3);
            this.gRL_howto.Name = "gRL_howto";
            this.gRL_howto.Size = new System.Drawing.Size(550, 452);
            this.gRL_howto.TabIndex = 23;
            this.gRL_howto.Visible = false;
            // 
            // l_HT5
            // 
            this.l_HT5.BackColor = System.Drawing.Color.Transparent;
            this.l_HT5.Location = new System.Drawing.Point(49, 353);
            this.l_HT5.Name = "l_HT5";
            this.l_HT5.Size = new System.Drawing.Size(493, 60);
            this.l_HT5.TabIndex = 4;
            this.l_HT5.Text = "If you fail to repeat a sequence exactly, a message will aoear and you lose, you " +
    "can play and you can play again.\r\n";
            // 
            // l_HT4
            // 
            this.l_HT4.BackColor = System.Drawing.Color.Transparent;
            this.l_HT4.Location = new System.Drawing.Point(49, 276);
            this.l_HT4.Name = "l_HT4";
            this.l_HT4.Size = new System.Drawing.Size(493, 58);
            this.l_HT4.TabIndex = 3;
            this.l_HT4.Text = "Continue playing as long as you can repeat each sequence of signals correctly unt" +
    "il you win by compliting all the turns\r\n";
            // 
            // l_HT3
            // 
            this.l_HT3.BackColor = System.Drawing.Color.Transparent;
            this.l_HT3.Location = new System.Drawing.Point(49, 202);
            this.l_HT3.Name = "l_HT3";
            this.l_HT3.Size = new System.Drawing.Size(493, 43);
            this.l_HT3.TabIndex = 2;
            this.l_HT3.Text = "Simon will duplicate these first two signals and add one.";
            // 
            // l_HT2
            // 
            this.l_HT2.BackColor = System.Drawing.Color.Transparent;
            this.l_HT2.Location = new System.Drawing.Point(49, 119);
            this.l_HT2.Name = "l_HT2";
            this.l_HT2.Size = new System.Drawing.Size(493, 55);
            this.l_HT2.TabIndex = 1;
            this.l_HT2.Text = "Simon will duplicate the first signal and add one. Repeat these two signals by pr" +
    "essing the same color lenses, in order.";
            // 
            // l_HT1
            // 
            this.l_HT1.BackColor = System.Drawing.Color.Transparent;
            this.l_HT1.Location = new System.Drawing.Point(49, 35);
            this.l_HT1.Name = "l_HT1";
            this.l_HT1.Size = new System.Drawing.Size(493, 53);
            this.l_HT1.TabIndex = 0;
            this.l_HT1.Text = "Press the START button. Simon will give the first signal. Repeat the signal by pr" +
    "essing the same color lens.";
            // 
            // gRL_difficulty
            // 
            this.gRL_difficulty.ColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gRL_difficulty.ColorRight = System.Drawing.Color.Teal;
            this.gRL_difficulty.Controls.Add(this.l_turns);
            this.gRL_difficulty.Controls.Add(this.l_amounmt);
            this.gRL_difficulty.Controls.Add(this.nup_hm_turns);
            this.gRL_difficulty.Controls.Add(this.pic_50);
            this.gRL_difficulty.Controls.Add(this.pic_100);
            this.gRL_difficulty.Controls.Add(this.pic_rnd);
            this.gRL_difficulty.Controls.Add(this.pic_10);
            this.gRL_difficulty.Controls.Add(this.bt_submit);
            this.gRL_difficulty.Controls.Add(this.cS_difficulty);
            this.gRL_difficulty.Location = new System.Drawing.Point(12, 9);
            this.gRL_difficulty.Name = "gRL_difficulty";
            this.gRL_difficulty.Size = new System.Drawing.Size(550, 452);
            this.gRL_difficulty.TabIndex = 22;
            this.gRL_difficulty.Visible = false;
            // 
            // l_turns
            // 
            this.l_turns.BackColor = System.Drawing.Color.Transparent;
            this.l_turns.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F);
            this.l_turns.Location = new System.Drawing.Point(22, 214);
            this.l_turns.Name = "l_turns";
            this.l_turns.Size = new System.Drawing.Size(206, 38);
            this.l_turns.TabIndex = 20;
            this.l_turns.Text = "Turns:";
            // 
            // l_amounmt
            // 
            this.l_amounmt.BackColor = System.Drawing.Color.Transparent;
            this.l_amounmt.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_amounmt.Location = new System.Drawing.Point(28, 44);
            this.l_amounmt.Name = "l_amounmt";
            this.l_amounmt.Size = new System.Drawing.Size(352, 38);
            this.l_amounmt.TabIndex = 19;
            this.l_amounmt.Text = "Button Amount:";
            // 
            // nup_hm_turns
            // 
            this.nup_hm_turns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nup_hm_turns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nup_hm_turns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nup_hm_turns.Location = new System.Drawing.Point(31, 381);
            this.nup_hm_turns.Name = "nup_hm_turns";
            this.nup_hm_turns.Size = new System.Drawing.Size(349, 26);
            this.nup_hm_turns.TabIndex = 18;
            this.nup_hm_turns.ValueChanged += new System.EventHandler(this.nup_hm_turns_ValueChanged);
            // 
            // bt_submit
            // 
            this.bt_submit.BackColor = System.Drawing.Color.Transparent;
            this.bt_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_submit.FlatAppearance.BorderSize = 2;
            this.bt_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_submit.Location = new System.Drawing.Point(386, 379);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(123, 28);
            this.bt_submit.TabIndex = 13;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = false;
            this.bt_submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // pic_Exit
            // 
            this.pic_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Exit.Image = global::SimonThatcher.Properties.Resources.Exit;
            this.pic_Exit.Location = new System.Drawing.Point(0, 385);
            this.pic_Exit.Name = "pic_Exit";
            this.pic_Exit.Size = new System.Drawing.Size(255, 67);
            this.pic_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Exit.TabIndex = 4;
            this.pic_Exit.TabStop = false;
            this.pic_Exit.Click += new System.EventHandler(this.pic_Exit_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Image = global::SimonThatcher.Properties.Resources.סמל;
            this.pic_logo.Location = new System.Drawing.Point(3, 0);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(247, 85);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 0;
            this.pic_logo.TabStop = false;
            // 
            // red_mode_4
            // 
            this.red_mode_4.BackColor = System.Drawing.Color.Transparent;
            this.red_mode_4.Image = global::SimonThatcher.Properties.Resources.red_mode_4_off;
            this.red_mode_4.Location = new System.Drawing.Point(277, 77);
            this.red_mode_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.red_mode_4.Name = "red_mode_4";
            this.red_mode_4.Size = new System.Drawing.Size(153, 149);
            this.red_mode_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.red_mode_4.TabIndex = 24;
            this.red_mode_4.TabStop = false;
            // 
            // blue_mode_4
            // 
            this.blue_mode_4.BackColor = System.Drawing.Color.Transparent;
            this.blue_mode_4.Image = global::SimonThatcher.Properties.Resources.blue_mode_4_off;
            this.blue_mode_4.Location = new System.Drawing.Point(277, 226);
            this.blue_mode_4.Margin = new System.Windows.Forms.Padding(4);
            this.blue_mode_4.Name = "blue_mode_4";
            this.blue_mode_4.Size = new System.Drawing.Size(153, 149);
            this.blue_mode_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blue_mode_4.TabIndex = 26;
            this.blue_mode_4.TabStop = false;
            // 
            // yellow_mode_4
            // 
            this.yellow_mode_4.BackColor = System.Drawing.Color.Transparent;
            this.yellow_mode_4.Image = global::SimonThatcher.Properties.Resources.yellow_mode_4_off;
            this.yellow_mode_4.Location = new System.Drawing.Point(120, 226);
            this.yellow_mode_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yellow_mode_4.Name = "yellow_mode_4";
            this.yellow_mode_4.Size = new System.Drawing.Size(153, 149);
            this.yellow_mode_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yellow_mode_4.TabIndex = 23;
            this.yellow_mode_4.TabStop = false;
            // 
            // green_mode_4
            // 
            this.green_mode_4.BackColor = System.Drawing.Color.Transparent;
            this.green_mode_4.Image = global::SimonThatcher.Properties.Resources.green_mode_4_off;
            this.green_mode_4.Location = new System.Drawing.Point(120, 77);
            this.green_mode_4.Margin = new System.Windows.Forms.Padding(4);
            this.green_mode_4.Name = "green_mode_4";
            this.green_mode_4.Size = new System.Drawing.Size(153, 149);
            this.green_mode_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.green_mode_4.TabIndex = 25;
            this.green_mode_4.TabStop = false;
            // 
            // pic_circle
            // 
            this.pic_circle.BackColor = System.Drawing.Color.Transparent;
            this.pic_circle.Image = global::SimonThatcher.Properties.Resources.white_circle;
            this.pic_circle.Location = new System.Drawing.Point(28, 3);
            this.pic_circle.Name = "pic_circle";
            this.pic_circle.Size = new System.Drawing.Size(478, 451);
            this.pic_circle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_circle.TabIndex = 21;
            this.pic_circle.TabStop = false;
            // 
            // pic_50
            // 
            this.pic_50.BackColor = System.Drawing.Color.Transparent;
            this.pic_50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_50.Image = global::SimonThatcher.Properties.Resources.white_circle;
            this.pic_50.Location = new System.Drawing.Point(157, 270);
            this.pic_50.Name = "pic_50";
            this.pic_50.Size = new System.Drawing.Size(90, 90);
            this.pic_50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_50.TabIndex = 17;
            this.pic_50.TabStop = false;
            this.pic_50.Click += new System.EventHandler(this.Select_Deficulty);
            // 
            // pic_100
            // 
            this.pic_100.BackColor = System.Drawing.Color.Transparent;
            this.pic_100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_100.Image = global::SimonThatcher.Properties.Resources.white_circle;
            this.pic_100.Location = new System.Drawing.Point(290, 270);
            this.pic_100.Name = "pic_100";
            this.pic_100.Size = new System.Drawing.Size(90, 90);
            this.pic_100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_100.TabIndex = 16;
            this.pic_100.TabStop = false;
            this.pic_100.Click += new System.EventHandler(this.Select_Deficulty);
            // 
            // pic_rnd
            // 
            this.pic_rnd.BackColor = System.Drawing.Color.Transparent;
            this.pic_rnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_rnd.Image = global::SimonThatcher.Properties.Resources.white_circle;
            this.pic_rnd.Location = new System.Drawing.Point(419, 270);
            this.pic_rnd.Name = "pic_rnd";
            this.pic_rnd.Size = new System.Drawing.Size(90, 90);
            this.pic_rnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_rnd.TabIndex = 15;
            this.pic_rnd.TabStop = false;
            this.pic_rnd.Click += new System.EventHandler(this.Select_Deficulty);
            // 
            // pic_10
            // 
            this.pic_10.BackColor = System.Drawing.Color.Transparent;
            this.pic_10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_10.Image = global::SimonThatcher.Properties.Resources.gray_circle;
            this.pic_10.Location = new System.Drawing.Point(31, 270);
            this.pic_10.Name = "pic_10";
            this.pic_10.Size = new System.Drawing.Size(90, 90);
            this.pic_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_10.TabIndex = 14;
            this.pic_10.TabStop = false;
            this.pic_10.Click += new System.EventHandler(this.Select_Deficulty);
            // 
            // cS_difficulty
            // 
            this.cS_difficulty.BackColor = System.Drawing.Color.Transparent;
            this.cS_difficulty.BarInnerColor = System.Drawing.Color.White;
            this.cS_difficulty.BarPenColorBottom = System.Drawing.Color.White;
            this.cS_difficulty.BarPenColorTop = System.Drawing.Color.White;
            this.cS_difficulty.BorderRoundRectSize = new System.Drawing.Size(1, 1);
            this.cS_difficulty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cS_difficulty.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cS_difficulty.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cS_difficulty.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cS_difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cS_difficulty.ForeColor = System.Drawing.Color.Black;
            this.cS_difficulty.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cS_difficulty.Location = new System.Drawing.Point(31, 95);
            this.cS_difficulty.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.cS_difficulty.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cS_difficulty.MouseWheelBarPartitions = 1;
            this.cS_difficulty.Name = "cS_difficulty";
            this.cS_difficulty.ScaleDivisions = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cS_difficulty.ScaleSubDivisions = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cS_difficulty.ShowDivisionsText = true;
            this.cS_difficulty.ShowSmallScale = false;
            this.cS_difficulty.Size = new System.Drawing.Size(478, 92);
            this.cS_difficulty.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cS_difficulty.TabIndex = 7;
            this.cS_difficulty.TabStop = false;
            this.cS_difficulty.ThumbImage = global::SimonThatcher.Properties.Resources.mode_2_logo;
            this.cS_difficulty.ThumbInnerColor = System.Drawing.Color.Transparent;
            this.cS_difficulty.ThumbOuterColor = System.Drawing.Color.Transparent;
            this.cS_difficulty.ThumbPenColor = System.Drawing.Color.Transparent;
            this.cS_difficulty.ThumbRoundRectSize = new System.Drawing.Size(42, 25);
            this.cS_difficulty.ThumbSize = new System.Drawing.Size(25, 25);
            this.cS_difficulty.TickAdd = 0F;
            this.cS_difficulty.TickColor = System.Drawing.SystemColors.WindowText;
            this.cS_difficulty.TickDivide = 0F;
            this.cS_difficulty.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cS_difficulty.Scroll += new System.Windows.Forms.ScrollEventHandler(this.cS_difficulty_Scroll);
            // 
            // StartSimon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p_menu);
            this.Controls.Add(this.gRL_play);
            this.Controls.Add(this.gRL_howto);
            this.Controls.Add(this.gRL_difficulty);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartSimon";
            this.Text = " Simon Says";
            this.Load += new System.EventHandler(this.StartSimon_Load);
            this.p_menu.ResumeLayout(false);
            this.gRL_play.ResumeLayout(false);
            this.gRL_play.PerformLayout();
            this.gRL_howto.ResumeLayout(false);
            this.gRL_difficulty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nup_hm_turns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_mode_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_mode_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow_mode_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_mode_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_circle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer t_on_off;
        private Gradient_RL gRL_play;
        private System.Windows.Forms.PictureBox pic_circle;
        private System.Windows.Forms.Panel p_menu;
        private System.Windows.Forms.PictureBox pic_Exit;
        private System.Windows.Forms.Button b_howto;
        private System.Windows.Forms.Button b_difficulty;
        private System.Windows.Forms.Button b_play;
        private System.Windows.Forms.PictureBox pic_logo;
        private Gradient_RL gRL_difficulty;
        private Gradient_RL gRL_howto;
        private System.Windows.Forms.TextBox tx_name;
        private ColorSlider.ColorSlider cS_difficulty;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Label l_HT5;
        private System.Windows.Forms.Label l_HT4;
        private System.Windows.Forms.Label l_HT3;
        private System.Windows.Forms.Label l_HT2;
        private System.Windows.Forms.Label l_HT1;
        private System.Windows.Forms.PictureBox pic_rnd;
        private System.Windows.Forms.PictureBox pic_10;
        private System.Windows.Forms.PictureBox pic_50;
        private System.Windows.Forms.PictureBox pic_100;
        private System.Windows.Forms.PictureBox red_mode_4;
        private System.Windows.Forms.PictureBox blue_mode_4;
        private System.Windows.Forms.PictureBox yellow_mode_4;
        private System.Windows.Forms.PictureBox green_mode_4;
        private System.Windows.Forms.NumericUpDown nup_hm_turns;
        private System.Windows.Forms.Label l_turns;
        private System.Windows.Forms.Label l_amounmt;
        private System.Windows.Forms.TextBox tb_name;
        private RoundedButton roundedButton1;
    }
}