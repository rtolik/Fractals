namespace Fractals.Forms
{
    partial class Color_Schene
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
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Panel panel2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Panel panel3;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Color_Schene));
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.RightPictureBox = new System.Windows.Forms.PictureBox();
            this.LeftPictureBox = new System.Windows.Forms.PictureBox();
            this.YellowTrackBar = new System.Windows.Forms.TrackBar();
            this.ConvertToCMYBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AskBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPictureBox)).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YellowTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(142)))), ((int)(((byte)(68)))));
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(this.RightPictureBox);
            panel1.Controls.Add(this.LeftPictureBox);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1334, 631);
            panel1.TabIndex = 0;
            // 
            // RightPictureBox
            // 
            this.RightPictureBox.Location = new System.Drawing.Point(733, 249);
            this.RightPictureBox.Name = "RightPictureBox";
            this.RightPictureBox.Size = new System.Drawing.Size(540, 311);
            this.RightPictureBox.TabIndex = 1;
            this.RightPictureBox.TabStop = false;
            // 
            // LeftPictureBox
            // 
            this.LeftPictureBox.Location = new System.Drawing.Point(68, 249);
            this.LeftPictureBox.Name = "LeftPictureBox";
            this.LeftPictureBox.Size = new System.Drawing.Size(540, 311);
            this.LeftPictureBox.TabIndex = 0;
            this.LeftPictureBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(31)))), ((int)(((byte)(9)))));
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(this.AskBtn);
            panel2.Controls.Add(this.HomeBtn);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1334, 233);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(532, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(278, 33);
            label1.TabIndex = 12;
            label1.Text = "Color Models";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(104)))), ((int)(((byte)(158)))));
            panel3.Controls.Add(this.YellowTrackBar);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(this.ConvertToCMYBtn);
            panel3.Controls.Add(this.button2);
            panel3.Controls.Add(this.button1);
            panel3.Location = new System.Drawing.Point(168, 48);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1014, 159);
            panel3.TabIndex = 9;
            // 
            // YellowTrackBar
            // 
            this.YellowTrackBar.Location = new System.Drawing.Point(397, 43);
            this.YellowTrackBar.Name = "YellowTrackBar";
            this.YellowTrackBar.Size = new System.Drawing.Size(320, 45);
            this.YellowTrackBar.TabIndex = 14;
            this.YellowTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(145, 44);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(218, 44);
            label2.TabIndex = 13;
            label2.Text = "Saturation on Yellow";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConvertToCMYBtn
            // 
            this.ConvertToCMYBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConvertToCMYBtn.BackgroundImage")));
            this.ConvertToCMYBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConvertToCMYBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertToCMYBtn.Location = new System.Drawing.Point(369, 108);
            this.ConvertToCMYBtn.Name = "ConvertToCMYBtn";
            this.ConvertToCMYBtn.Size = new System.Drawing.Size(252, 48);
            this.ConvertToCMYBtn.TabIndex = 12;
            this.ConvertToCMYBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(13, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 39);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 39);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AskBtn
            // 
            this.AskBtn.BackColor = System.Drawing.Color.Transparent;
            this.AskBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AskBtn.BackgroundImage")));
            this.AskBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AskBtn.FlatAppearance.BorderSize = 0;
            this.AskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AskBtn.Location = new System.Drawing.Point(1279, 12);
            this.AskBtn.Name = "AskBtn";
            this.AskBtn.Size = new System.Drawing.Size(43, 39);
            this.AskBtn.TabIndex = 8;
            this.AskBtn.UseVisualStyleBackColor = false;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeBtn.BackgroundImage")));
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Location = new System.Drawing.Point(12, 12);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(39, 39);
            this.HomeBtn.TabIndex = 7;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(204, 563);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(218, 44);
            label3.TabIndex = 15;
            label3.Text = "Uploaded Image";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.Location = new System.Drawing.Point(913, 563);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(218, 44);
            label4.TabIndex = 16;
            label4.Text = "Edited Image";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Color_Schene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 631);
            this.Controls.Add(panel2);
            this.Controls.Add(panel1);
            this.Name = "Color_Schene";
            this.Text = "Color_Schene";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Color_Schene_FormClosed);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPictureBox)).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YellowTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AskBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox RightPictureBox;
        private System.Windows.Forms.PictureBox LeftPictureBox;
        private System.Windows.Forms.TrackBar YellowTrackBar;
        private System.Windows.Forms.Button ConvertToCMYBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}