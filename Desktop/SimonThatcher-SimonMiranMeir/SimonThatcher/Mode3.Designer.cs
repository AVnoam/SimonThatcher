
namespace SimonThatcher
{
    partial class Mode3
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
            this.blue_mode_3 = new System.Windows.Forms.PictureBox();
            this.red_mode_3 = new System.Windows.Forms.PictureBox();
            this.pic_circle = new System.Windows.Forms.PictureBox();
            this.green_mode_3 = new System.Windows.Forms.PictureBox();
            this.gradient1 = new SimonThatcher.Gradient();
            this.panel_progress = new System.Windows.Forms.Panel();
            this.turnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.blue_mode_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_mode_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_circle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_mode_3)).BeginInit();
            this.gradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sButton
            // 
            this.sButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.sButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sButton.FlatAppearance.BorderSize = 0;
            this.sButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sButton.ForeColor = System.Drawing.Color.Black;
            this.sButton.Location = new System.Drawing.Point(-3, 334);
            this.sButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sButton.Name = "sButton";
            this.sButton.Size = new System.Drawing.Size(807, 123);
            this.sButton.TabIndex = 17;
            this.sButton.TabStop = false;
            this.sButton.Text = "START";
            this.sButton.UseVisualStyleBackColor = false;
            this.sButton.Click += new System.EventHandler(this.sButClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // blue_mode_3
            // 
            this.blue_mode_3.BackColor = System.Drawing.Color.Transparent;
            this.blue_mode_3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.blue_mode_3.Enabled = false;
            this.blue_mode_3.Image = global::SimonThatcher.Properties.Resources.blue_mode_3_off;
            this.blue_mode_3.Location = new System.Drawing.Point(402, 88);
            this.blue_mode_3.Name = "blue_mode_3";
            this.blue_mode_3.Size = new System.Drawing.Size(139, 81);
            this.blue_mode_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blue_mode_3.TabIndex = 21;
            this.blue_mode_3.TabStop = false;
            this.blue_mode_3.Click += new System.EventHandler(this.simonBClick);
            // 
            // red_mode_3
            // 
            this.red_mode_3.BackColor = System.Drawing.Color.Transparent;
            this.red_mode_3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.red_mode_3.Enabled = false;
            this.red_mode_3.Image = global::SimonThatcher.Properties.Resources.red_mode_3_off;
            this.red_mode_3.Location = new System.Drawing.Point(261, 88);
            this.red_mode_3.Name = "red_mode_3";
            this.red_mode_3.Size = new System.Drawing.Size(135, 81);
            this.red_mode_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.red_mode_3.TabIndex = 20;
            this.red_mode_3.TabStop = false;
            this.red_mode_3.Click += new System.EventHandler(this.simonBClick);
            // 
            // pic_circle
            // 
            this.pic_circle.Image = global::SimonThatcher.Properties.Resources.white_circle;
            this.pic_circle.Location = new System.Drawing.Point(233, -7);
            this.pic_circle.Name = "pic_circle";
            this.pic_circle.Size = new System.Drawing.Size(335, 340);
            this.pic_circle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_circle.TabIndex = 18;
            this.pic_circle.TabStop = false;
            // 
            // green_mode_3
            // 
            this.green_mode_3.BackColor = System.Drawing.Color.Transparent;
            this.green_mode_3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.green_mode_3.Enabled = false;
            this.green_mode_3.Image = global::SimonThatcher.Properties.Resources.green_mode_3_off;
            this.green_mode_3.Location = new System.Drawing.Point(333, 187);
            this.green_mode_3.Name = "green_mode_3";
            this.green_mode_3.Size = new System.Drawing.Size(135, 84);
            this.green_mode_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.green_mode_3.TabIndex = 22;
            this.green_mode_3.TabStop = false;
            this.green_mode_3.Click += new System.EventHandler(this.simonBClick);
            // 
            // gradient1
            // 
            this.gradient1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gradient1.ColorBottom = System.Drawing.Color.Teal;
            this.gradient1.ColorTop = System.Drawing.Color.LightSeaGreen;
            this.gradient1.Controls.Add(this.panel_progress);
            this.gradient1.Controls.Add(this.turnLabel);
            this.gradient1.Location = new System.Drawing.Point(-3, 334);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(799, 123);
            this.gradient1.TabIndex = 19;
            // 
            // panel_progress
            // 
            this.panel_progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(200)))), ((int)(((byte)(32)))));
            this.panel_progress.Location = new System.Drawing.Point(0, 0);
            this.panel_progress.Name = "panel_progress";
            this.panel_progress.Size = new System.Drawing.Size(800, 30);
            this.panel_progress.TabIndex = 5;
            // 
            // turnLabel
            // 
            this.turnLabel.BackColor = System.Drawing.Color.Transparent;
            this.turnLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLabel.Location = new System.Drawing.Point(3, 33);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(744, 77);
            this.turnLabel.TabIndex = 4;
            this.turnLabel.Text = "Turn: ";
            this.turnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Mode3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.green_mode_3);
            this.Controls.Add(this.sButton);
            this.Controls.Add(this.gradient1);
            this.Controls.Add(this.blue_mode_3);
            this.Controls.Add(this.red_mode_3);
            this.Controls.Add(this.pic_circle);
            this.Name = "Mode3";
            this.Text = "Mode3";
            ((System.ComponentModel.ISupportInitialize)(this.blue_mode_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_mode_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_circle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_mode_3)).EndInit();
            this.gradient1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sButton;
        private Gradient gradient1;
        private System.Windows.Forms.Panel panel_progress;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pic_circle;
        private System.Windows.Forms.PictureBox red_mode_3;
        private System.Windows.Forms.PictureBox blue_mode_3;
        private System.Windows.Forms.PictureBox green_mode_3;
    }
}