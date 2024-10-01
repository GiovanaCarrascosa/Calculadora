using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class TelaCalculadora : Form
    {
        float valor1 = 0;
        string operacao = "";

        public TelaCalculadora()
        {
            InitializeComponent();
        }


        private void button9_Click(object sender, EventArgs e)
        {
            if (this.operacao == "soma")
            {
                float resultado = valor1 + Convert.ToSingle(textBox1.Text);
                textBox1.Text = resultado.ToString();
            }

            if (this.operacao == "subtracao")
            {
                float resultado = valor1 - Convert.ToSingle(textBox1.Text);
                textBox1.Text = resultado.ToString();
            }

            if (this.operacao == "divisao")
            {
                float resultado = valor1 / Convert.ToSingle(textBox1.Text);
                textBox1.Text = resultado.ToString();
            }

            if (this.operacao == "multiplicacao")
            {
                float resultado = valor1 * Convert.ToSingle(textBox1.Text);
                textBox1.Text = resultado.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(textBox1.Text);
            operacao = "subtracao";
            textBox1.Clear();
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(textBox1.Text);
            operacao = "multiplicacao";
            textBox1.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(textBox1.Text);
            operacao = "divisao";
            textBox1.Clear();
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btnMais_Click_1(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(textBox1.Text);
            operacao = "soma";
            textBox1.Clear();
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btsNove_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CtoF_Click(object sender, EventArgs e)
        {
            ConverterCtoF convertertela = new ConverterCtoF();
            convertertela.ShowDialog();
        }

        private void TelaCalculadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void conversorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConverterCMtoPLG convertercmtela = new frmConverterCMtoPLG();
            convertercmtela.ShowDialog();
        }
    }
}
