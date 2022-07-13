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
            int num;
            //bool res = int.TryParse("2002aa",out num);

            if (int.TryParse("2002", out num))
            {
                lblResultado.Text = num.ToString();
            }
            else
            {
                lblResultado.Text = "Erro na conversão";
            }
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
