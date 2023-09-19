using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBesiktas_Click(object sender, EventArgs e)
        {
            lblTakim.BackColor = Color.White;
            lblTakim.ForeColor = Color.Black;
        }

        private void btnGsaray_Click(object sender, EventArgs e)
        {
            lblTakim.BackColor = Color.Yellow;
            lblTakim.ForeColor = Color.Red;
        }

        private void btnTrabzonsp_Click(object sender, EventArgs e)
        {
            lblTakim.BackColor = Color.Red;
            lblTakim.ForeColor = Color.Blue;
        }

        private void btnFenerbahce_Click(object sender, EventArgs e)
        {
            lblTakim.BackColor = Color.Yellow;
            lblTakim.ForeColor = Color.Blue;
        }
    }
}
