namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;

            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;

                this.Hide();

                TelaCalculadora calculadoratela = new TelaCalculadora();
                calculadoratela.ShowDialog();
                
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
