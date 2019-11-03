using Fractals.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Fractal_Builder fractal = new Fractal_Builder(this);
            fractal.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Color_Schene color_Schene = new Color_Schene(this);
            color_Schene.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Affine_Transformations affine_Transformations  = new Affine_Transformations(this);
            affine_Transformations.Show();
            this.Hide();
        }
    }
}
