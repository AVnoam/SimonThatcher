namespace SimonThatcher
{
    partial class SimonMiranMeir
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
            this.sButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.green = new System.Windows.Forms.PictureBox();
            this.blue = new System.Windows.Forms.PictureBox();
            this.yellow = new System.Windows.Forms.PictureBox();
            this.red = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            this.SuspendLayout();
            // 
            // sButton
            // 
            this.sButton.BackColor = System.Drawing.Color.Lime;
            this.sButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sButton.Location = new System.Drawing.Point(318, 313);
            this.sButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sButton.Name = "sButton";
            this.sButton.Size = new System.Drawing.Size(136, 74);
            this.sButton.TabIndex = 1;
            this.sButton.TabStop = false;
            this.sButton.Text = "START";
            this.sButton.UseVisualStyleBackColor = false;
            this.sButton.Click += new System.EventHandler(this.sButClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Transparent;
            this.green.Image = global::SimonThatcher.Properties.Resources.green_off;
            this.green.Location = new System.Drawing.Point(274, 53);
            this.green.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(114, 106);
            this.green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.green.TabIndex = 3;
            this.green.TabStop = false;
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Transparent;
            this.blue.Image = global::SimonThatcher.Properties.Resources.blue_off;
            this.blue.Location = new System.Drawing.Point(393, 165);
            this.blue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(117, 106);
            this.blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blue.TabIndex = 3;
            this.blue.TabStop = false;
            // 
            // yellow
            // 
            this.yellow.Image = global::SimonThatcher.Properties.Resources.yellow_off;
            this.yellow.Location = new System.Drawing.Point(274, 165);
            this.yellow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(114, 106);
            this.yellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yellow.TabIndex = 2;
            this.yellow.TabStop = false;
            this.yellow.Click += new System.EventHandler(this.simonBClick);
            // 
            // red
            // 
            this.red.Image = global::SimonThatcher.Properties.Resources.red_off;
            this.red.Location = new System.Drawing.Point(393, 53);
            this.red.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(117, 106);
            this.red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.red.TabIndex = 2;
            this.red.TabStop = false;
            this.red.Click += new System.EventHandler(this.simonBClick);
            // 
            // SimonMiranMeir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.green);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.red);
            this.Controls.Add(this.sButton);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SimonMiranMeir";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SimonMiranMeir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button sButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.PictureBox yellow;
        private System.Windows.Forms.PictureBox blue;
        private System.Windows.Forms.PictureBox green;
    }
}

