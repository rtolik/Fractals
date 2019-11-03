namespace Fractals.Forms
{
    partial class Affine_Transformations
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Affine_Transformations));
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AskBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.YellowTrackBar = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.RenderBtn = new System.Windows.Forms.Button();
            this.ParallelogrammCoordinatesTextBox = new System.Windows.Forms.TextBox();
            this.CoeficientsTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YellowTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.AskBtn);
            this.panel2.Controls.Add(this.HomeBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1334, 631);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(446, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 58);
            this.label1.TabIndex = 8;
            this.label1.Text = "Affine Transformations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AskBtn
            // 
            this.AskBtn.BackColor = System.Drawing.Color.Transparent;
            this.AskBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AskBtn.BackgroundImage")));
            this.AskBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AskBtn.FlatAppearance.BorderSize = 0;
            this.AskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AskBtn.Location = new System.Drawing.Point(1279, 3);
            this.AskBtn.Name = "AskBtn";
            this.AskBtn.Size = new System.Drawing.Size(43, 39);
            this.AskBtn.TabIndex = 10;
            this.AskBtn.UseVisualStyleBackColor = false;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeBtn.BackgroundImage")));
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Location = new System.Drawing.Point(12, 3);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(39, 39);
            this.HomeBtn.TabIndex = 9;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(39)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1334, 231);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(104)))), ((int)(((byte)(158)))));
            this.panel3.Controls.Add(label5);
            this.panel3.Controls.Add(label4);
            this.panel3.Controls.Add(this.CoeficientsTextBox);
            this.panel3.Controls.Add(this.ParallelogrammCoordinatesTextBox);
            this.panel3.Controls.Add(this.RenderBtn);
            this.panel3.Controls.Add(label3);
            this.panel3.Controls.Add(label2);
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.YellowTrackBar);
            this.panel3.Location = new System.Drawing.Point(62, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1215, 170);
            this.panel3.TabIndex = 0;
            // 
            // YellowTrackBar
            // 
            this.YellowTrackBar.Location = new System.Drawing.Point(986, 36);
            this.YellowTrackBar.Name = "YellowTrackBar";
            this.YellowTrackBar.Size = new System.Drawing.Size(193, 45);
            this.YellowTrackBar.TabIndex = 15;
            this.YellowTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(986, 122);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(193, 45);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(991, 5);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(188, 28);
            label2.TabIndex = 17;
            label2.Text = "Scale";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(986, 84);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(193, 28);
            label3.TabIndex = 18;
            label3.Text = "Move";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RenderBtn
            // 
            this.RenderBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RenderBtn.BackgroundImage")));
            this.RenderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RenderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RenderBtn.Location = new System.Drawing.Point(523, 122);
            this.RenderBtn.Name = "RenderBtn";
            this.RenderBtn.Size = new System.Drawing.Size(165, 49);
            this.RenderBtn.TabIndex = 19;
            this.RenderBtn.UseVisualStyleBackColor = true;
            // 
            // ParallelogrammCoordinatesTextBox
            // 
            this.ParallelogrammCoordinatesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParallelogrammCoordinatesTextBox.Location = new System.Drawing.Point(317, 52);
            this.ParallelogrammCoordinatesTextBox.Name = "ParallelogrammCoordinatesTextBox";
            this.ParallelogrammCoordinatesTextBox.Size = new System.Drawing.Size(150, 29);
            this.ParallelogrammCoordinatesTextBox.TabIndex = 20;
            // 
            // CoeficientsTextBox
            // 
            this.CoeficientsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoeficientsTextBox.Location = new System.Drawing.Point(317, 101);
            this.CoeficientsTextBox.Name = "CoeficientsTextBox";
            this.CoeficientsTextBox.Size = new System.Drawing.Size(150, 29);
            this.CoeficientsTextBox.TabIndex = 21;
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.Location = new System.Drawing.Point(35, 29);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(220, 52);
            label4.TabIndex = 22;
            label4.Text = "Enter coordinates for 3 vertices of a parallelogram";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.Location = new System.Drawing.Point(35, 91);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(220, 52);
            label5.TabIndex = 23;
            label5.Text = "Enter the coefficients k and b";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Affine_Transformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 631);
            this.Controls.Add(this.panel2);
            this.Name = "Affine_Transformations";
            this.Text = "Affine_Transformations";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YellowTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AskBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox CoeficientsTextBox;
        private System.Windows.Forms.TextBox ParallelogrammCoordinatesTextBox;
        private System.Windows.Forms.Button RenderBtn;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar YellowTrackBar;
    }
}