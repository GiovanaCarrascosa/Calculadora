namespace Calculadora
{
    partial class frmConverterCMtoPLG
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
            button1 = new Button();
            resultado = new Label();
            textoexplicatorio = new Label();
            textBox2 = new TextBox();
            btnSair = new Button();
            btnIgual = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkMagenta;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 333);
            button1.Name = "button1";
            button1.Size = new Size(81, 42);
            button1.TabIndex = 45;
            button1.Text = "CLS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            resultado.Location = new Point(163, 40);
            resultado.Name = "resultado";
            resultado.Size = new Size(111, 19);
            resultado.TabIndex = 44;
            resultado.Text = "CONVERSÃO";
            resultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textoexplicatorio
            // 
            textoexplicatorio.AutoSize = true;
            textoexplicatorio.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textoexplicatorio.Location = new Point(99, 192);
            textoexplicatorio.Name = "textoexplicatorio";
            textoexplicatorio.Size = new Size(230, 19);
            textoexplicatorio.TabIndex = 43;
            textoexplicatorio.Text = "DIGITE UM NÚMERO AQUI:";
            textoexplicatorio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(99, 214);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 73);
            textBox2.TabIndex = 42;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.DarkMagenta;
            btnSair.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(346, 333);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(81, 42);
            btnSair.TabIndex = 41;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.AliceBlue;
            btnIgual.Font = new Font("Swis721 BlkCn BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIgual.Location = new Point(143, 293);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(149, 50);
            btnIgual.TabIndex = 40;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(21, 62);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(403, 54);
            textBox1.TabIndex = 39;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // frmConverterCMtoPLG
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(439, 387);
            Controls.Add(button1);
            Controls.Add(resultado);
            Controls.Add(textoexplicatorio);
            Controls.Add(textBox2);
            Controls.Add(btnSair);
            Controls.Add(btnIgual);
            Controls.Add(textBox1);
            Name = "frmConverterCMtoPLG";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmConverterCMtoPLG";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label resultado;
        private Label textoexplicatorio;
        private TextBox textBox2;
        private Button btnSair;
        private Button btnIgual;
        private TextBox textBox1;
    }
}