using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulaNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region TryParse
            //int num;
            //bool res = int.TryParse("2002aa",out num);

            //if (int.TryParse("2002", out num))
            //{
            //    lblResultado.Text = num.ToString();
            //}
            //else
            //{
            //    lblResultado.Text = "Erro na conversão";
            //}
            #endregion

            #region ToString / Convert.ToString
            //double num = 120.5524;
            //lblResultado.Text = num.ToString("#.00");

            //int num = 254;
            //lblResultado.Text = num.ToString("X"); // Hex
            //lblResultado.Text = num.ToString("D"); // Dec
            //lblResultado.Text = num.ToString("X2"); // Hex min 2 digitos
            //lblResultado.Text = num.ToString("D2"); // Dec min 2 digitos
            //lblResultado.Text = num.ToString("C"); // Monetario

            //lblResultado.Text = Convert.ToString(num, 8);
            #endregion

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
