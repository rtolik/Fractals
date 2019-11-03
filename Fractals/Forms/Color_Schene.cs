using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals.Forms
{
    public partial class Color_Schene : Form
    {
        private Form1 _sender;

        private bool _imgChanged = false;
        private string _fileName = "";
        private string _iconPath = "";

        public Color_Schene(Form1 sender)
        {
            InitializeComponent();
            _sender = sender;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SelectImage();
        }

        private void SelectImage()
        {
            _imgChanged = openFileDialog1.ShowDialog(this) == DialogResult.OK;
            if (_imgChanged)
            {

                LeftPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                LeftPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                RightPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                RightPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                _fileName = openFileDialog1.FileName.Split('\\').Last();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SetIcon(RightPictureBox);
        }

        private string SetIcon(PictureBox pictureBox)
        {
            if (_imgChanged)
            {
                _iconPath = "D:\\" + _fileName;
                pictureBox.Image.Save(_iconPath);
            }
            return _iconPath;
        }

        private void Color_Schene_FormClosed(object sender, FormClosedEventArgs e)
        {
            _sender.Close();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            _sender.Show();
            this.Hide();
        }
    }
}
