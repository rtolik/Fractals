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
    public partial class Fractal_Builder : Form
    {
        Form1 _sender;

        public Fractal_Builder(Form1 sender)
        {
            InitializeComponent();
            _sender = sender;
        }

        private void Fractal_Builder_FormClosed(object sender, FormClosedEventArgs e)
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
