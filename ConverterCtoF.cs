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
    public partial class ConverterCtoF : Form
    {
        float valor1 = 0;

        public ConverterCtoF()
        {
            InitializeComponent();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double resultado = valor1 * 1.8 + 32;
            textBox1.Text = resultado.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(textBox2.Text);
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
