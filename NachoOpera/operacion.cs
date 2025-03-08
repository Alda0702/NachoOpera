using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NachoOperaResta;
using NachoOperaSuma;
using NachoOperaDivision;
using NachoOperaMultiplicacion;


namespace NachoOpera
{
    public partial class operacion : Form
    {
        public operacion()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);

            if (lblSigno.Text == "+")
            {
                long SUM;
                SUM = NachoOperaSuma.Class1.Sum(num1, num2);
                Resultado asw = new Resultado();
                asw.lblResultado.Text = "La Suma es: " + SUM;
                asw.Show();
            }
            if (lblSigno.Text == "-")
            {
                long REST;
                REST = NachoOperaResta.Class1.Resta(num1, num2);
                Resultado asw = new Resultado();
                asw.lblResultado.Text = "La Resta es: " + REST;
                asw.Show();
            }
            if (lblSigno.Text == "*")
            {
                long MULT;
                MULT = NachoOperaMultiplicacion.Class1.Mul(num1, num2);
                Resultado asw = new Resultado();
                asw.lblResultado.Text = "La Multiplicación es: " + MULT;
                asw.Show();
            }
            if (lblSigno.Text == "/")
            {
                long DIV;
                DIV = NachoOperaDivision.Class1.Div(num1, num2);
                Resultado asw = new Resultado();
                asw.lblResultado.Text = "La División es: " + DIV;
                asw.Show();
            }


        }

        private void lblIngrese_Click(object sender, EventArgs e)
        {

        }

        private void operacion_Load(object sender, EventArgs e)
        {

        }
    }
}
