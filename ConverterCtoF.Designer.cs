namespace Calculadora
{
    partial class ConverterCtoF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSair = new Button();
            btnIgual = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textoexplicatorio = new Label();
            resultado = new Label();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.DarkMagenta;
            btnSair.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(363, 283);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(81, 42);
            btnSair.TabIndex = 34;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.AliceBlue;
            btnIgual.Font = new Font("Swis721 BlkCn BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIgual.Location = new Point(147, 271);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(149, 50);
            btnIgual.TabIndex = 33;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(24, 40);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(403, 54);
            textBox1.TabIndex = 32;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(115, 192);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 73);
            textBox2.TabIndex = 35;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textoexplicatorio
            // 
            textoexplicatorio.AutoSize = true;
            textoexplicatorio.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textoexplicatorio.Location = new Point(115, 170);
            textoexplicatorio.Name = "textoexplicatorio";
            textoexplicatorio.Size = new Size(230, 19);
            textoexplicatorio.TabIndex = 36;
            textoexplicatorio.Text = "DIGITE UM NÚMERO AQUI:";
            textoexplicatorio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            resultado.Location = new Point(174, 18);
            resultado.Name = "resultado";
            resultado.Size = new Size(111, 19);
            resultado.TabIndex = 37;
            resultado.Text = "CONVERSÃO";
            resultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ConverterCtoF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(456, 337);
            Controls.Add(resultado);
            Controls.Add(textoexplicatorio);
            Controls.Add(textBox2);
            Controls.Add(btnSair);
            Controls.Add(btnIgual);
            Controls.Add(textBox1);
            Name = "ConverterCtoF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConverterCtoF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSair;
        private Button btnIgual;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label textoexplicatorio;
        private Label resultado;
    }
}