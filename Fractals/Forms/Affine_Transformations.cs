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
    public partial class Affine_Transformations : Form
    {
        private Form1 _sender;

        public Affine_Transformations(Form1 sender)
        {
            InitializeComponent();
            _sender = sender;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            _sender.Show();
            this.Hide();
        }
    }
}
