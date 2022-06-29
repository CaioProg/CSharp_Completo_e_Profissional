﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            #region Contains / ToString
            //string texto = "Este tipo de variavel é alfanumerica.";

            //if (texto.Contains("tipo de v"))
            //{
            //    label1.Text = "Contém.";
            //}
            //else
            //{
            //    label1.Text = "Não Contém.";
            //}

            //int num = 5400;
            //bool res = true;

            //label1.Text = res.ToString();
            #endregion

            #region ToUpper / ToLower
            //string nome = "Teste";

            //nome.ToUpper();

            //label1.Text = nome.ToLower();
            #endregion

            #region IndexOf / LastIndexOf
            //string nome = "Caio Lucas";

            ////int indice = nome.IndexOf('a', 2, 4);
            //int indice = nome.LastIndexOf('a');

            //label1.Text = "Indice: " + indice;
            #endregion

            #region Insert / Replace
            //string nome = "Caio Lucas";

            ////string nomeFinal = nome.Insert(9, " Silva");

            //string nomeFinal = nome.Replace("Lucas", "Silva");

            //label1.Text = nomeFinal;
            #endregion

            #region Length / Substring
            //string nome = "Caio Lucas";

            //for (int i = 0; i < nome.Length; i++)
            //{
            //    label1.Text += nome[i] + "\n";
            //}

            //int tam = nome.Length;
            //label1.Text = $"O nome {nome} contém {tam} letras";

            //string parte = nome.Substring(nome.IndexOf(" "));

            //label1.Text = parte;
            #endregion

            #region Split
            //string nomes = "Gabriel Danny-Arthur_Caio_Glória-Bia Flavio";

            //char[] separador = { ' ', '-', '_' }; 

            //string[] resultado = nomes.Split(separador, StringSplitOptions.None);

            //foreach (string nome in resultado)
            //{
            //    label1.Text += nome + "\n"; 
            //}
            #endregion

            #region StartsWith / EndsWith
            //string nome = "Caio";

            //nome.StartsWith("G");

            //bool res = nome.StartsWith("ca", StringComparison.OrdinalIgnoreCase);

            //bool res = nome.EndsWith("AIO", StringComparison.OrdinalIgnoreCase);

            //if (res)
            //{
            //    label1.Text = "Positivo.";
            //}
            //else
            //{
            //    label1.Text = "Negativo.";
            //}
            #endregion

            string mensagem = "     Olá Caio  -_ - 5   ";

            char[] c = { ' ', '-', '_', '5' };
            //string nova = mensagem.Trim(c);
            //mensagem.TrimStart()

            label1.Text = ">" + mensagem.TrimEnd(c) + "<";
        }
    }
}