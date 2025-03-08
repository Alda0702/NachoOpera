using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NachoOpera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion ope = new operacion();
            ope.lblSigno.Text = "+";
            ope.Show();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion ope = new operacion();
            ope.lblSigno.Text = "-";
            ope.Show();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operacion ope = new operacion();
            ope.lblSigno.Text = "*";
            ope.Show();
        }

        private void btnDivisi_Click(object sender, EventArgs e)
        {
            operacion ope = new operacion();
            ope.lblSigno.Text = "/";
            ope.Show();
        }

        private void lblNachoOperaaa_Click(object sender, EventArgs e)
        {

        }
    }
}
