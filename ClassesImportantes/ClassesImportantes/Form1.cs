using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Olá!");
            //MessageBox.Show("Mensagem a ser impressa", "Titulo da mensagem");

            //DialogResult res = MessageBox.Show("Texto da msg", "Titulo", MessageBoxButtons.YesNo);

            //if (res == DialogResult.Yes)
            //{
            //    lblResultado.Text = "Clicou em Ok";
            //}
            //else if (res == DialogResult.No)
            //{
            //    lblResultado.Text = "Clicou em Cancelar";
            //}

            //MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            Random r = new Random(DateTime.Now.Millisecond);

            int valor = r.Next(100);
            double valor2 = r.NextDouble() * 100;

            lblResultado.Text = $"Número : {valor2}";
        }

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            //lblResultado.Text = TimeSpan.FromTicks(100000000000).ToString();

            //lblResultado.Text = TimeSpan.TicksPerMinute.ToString();

            TimeSpan inicio = new TimeSpan(1, 0, 0);

            TimeSpan fim = new TimeSpan(3, 30, 0);

            //TimeSpan intervalo = fim + inicio;

            TimeSpan intervalo = fim.Subtract(inicio);

            lblResultado.Text = intervalo.ToString();
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            //lblResultado.Text = DateTime.Now.ToString();
            //lblResultado.Text = DateTime.Today.ToString();
            //lblResultado.Text = DateTime.DaysInMonth(2022, 09).ToString();
            //lblResultado.Text = DateTime.IsLeapYear(2020).ToString();
            //lblResultado.Text = DateTime.Now.ToLongDateString();
            //lblResultado.Text = DateTime.Now.ToShortDateString();
            //lblResultado.Text = DateTime.Now.ToLongTimeString();
            //lblResultado.Text = DateTime.Now.ToShortTimeString();
            //lblResultado.Text = DateTime.Now.ToUniversalTime().ToString();
            //lblResultado.Text = DateTime.Now.ToString("dd-MM-yy HH:mm:ss");

            DateTime data = new DateTime(1985, 01, 10, 14, 35, 30);

            //lblResultado.Text =  data.AddYears(2).ToString();

            //TimeSpan tempo = new TimeSpan(5, 10, 5, 20);
            //lblResultado.Text = data.Add(tempo).ToString();

            //lblResultado.Text = data.DayOfWeek.ToString();
            lblResultado.Text = data.DayOfYear.ToString();

        }
    }
}