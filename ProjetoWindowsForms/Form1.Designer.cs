
namespace ProjetoWindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.buttonProcessar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumero1 = new System.Windows.Forms.TextBox();
            this.textBoxNumero2 = new System.Windows.Forms.TextBox();
            this.buttonSomar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxQuantidadeHoras = new System.Windows.Forms.TextBox();
            this.textBoxValorHora = new System.Windows.Forms.TextBox();
            this.labelValorHora = new System.Windows.Forms.Label();
            this.checkBoxAuxilioEducacao = new System.Windows.Forms.CheckBox();
            this.radioButtonNaoFezCompras = new System.Windows.Forms.RadioButton();
            this.radioButtonFezCompras = new System.Windows.Forms.RadioButton();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.richTextBoxResultado = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(88, 10);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(255, 23);
            this.textBoxNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sobrenome";
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(88, 46);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(255, 23);
            this.textBoxSobrenome.TabIndex = 3;
            // 
            // buttonProcessar
            // 
            this.buttonProcessar.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonProcessar.ForeColor = System.Drawing.Color.Red;
            this.buttonProcessar.Location = new System.Drawing.Point(197, 75);
            this.buttonProcessar.Name = "buttonProcessar";
            this.buttonProcessar.Size = new System.Drawing.Size(146, 53);
            this.buttonProcessar.TabIndex = 4;
            this.buttonProcessar.Text = "Processar";
            this.buttonProcessar.UseVisualStyleBackColor = true;
            this.buttonProcessar.Click += new System.EventHandler(this.buttonProcessar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Número 2";
            // 
            // textBoxNumero1
            // 
            this.textBoxNumero1.Location = new System.Drawing.Point(107, 137);
            this.textBoxNumero1.Name = "textBoxNumero1";
            this.textBoxNumero1.Size = new System.Drawing.Size(236, 23);
            this.textBoxNumero1.TabIndex = 7;
            // 
            // textBoxNumero2
            // 
            this.textBoxNumero2.Location = new System.Drawing.Point(107, 166);
            this.textBoxNumero2.Name = "textBoxNumero2";
            this.textBoxNumero2.Size = new System.Drawing.Size(236, 23);
            this.textBoxNumero2.TabIndex = 8;
            // 
            // buttonSomar
            // 
            this.buttonSomar.Location = new System.Drawing.Point(197, 195);
            this.buttonSomar.Name = "buttonSomar";
            this.buttonSomar.Size = new System.Drawing.Size(146, 52);
            this.buttonSomar.TabIndex = 9;
            this.buttonSomar.Text = "Somar";
            this.buttonSomar.UseVisualStyleBackColor = true;
            this.buttonSomar.Click += new System.EventHandler(this.buttonSomar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantidade de horas";
            // 
            // textBoxQuantidadeHoras
            // 
            this.textBoxQuantidadeHoras.Location = new System.Drawing.Point(538, 10);
            this.textBoxQuantidadeHoras.Name = "textBoxQuantidadeHoras";
            this.textBoxQuantidadeHoras.Size = new System.Drawing.Size(188, 23);
            this.textBoxQuantidadeHoras.TabIndex = 11;
            // 
            // textBoxValorHora
            // 
            this.textBoxValorHora.Location = new System.Drawing.Point(538, 42);
            this.textBoxValorHora.Name = "textBoxValorHora";
            this.textBoxValorHora.Size = new System.Drawing.Size(188, 23);
            this.textBoxValorHora.TabIndex = 12;
            // 
            // labelValorHora
            // 
            this.labelValorHora.AutoSize = true;
            this.labelValorHora.Location = new System.Drawing.Point(470, 46);
            this.labelValorHora.Name = "labelValorHora";
            this.labelValorHora.Size = new System.Drawing.Size(62, 15);
            this.labelValorHora.TabIndex = 13;
            this.labelValorHora.Text = "Valor Hora";
            // 
            // checkBoxAuxilioEducacao
            // 
            this.checkBoxAuxilioEducacao.AutoSize = true;
            this.checkBoxAuxilioEducacao.Location = new System.Drawing.Point(538, 75);
            this.checkBoxAuxilioEducacao.Name = "checkBoxAuxilioEducacao";
            this.checkBoxAuxilioEducacao.Size = new System.Drawing.Size(117, 19);
            this.checkBoxAuxilioEducacao.TabIndex = 14;
            this.checkBoxAuxilioEducacao.Text = "Auxílio Educação";
            this.checkBoxAuxilioEducacao.UseVisualStyleBackColor = true;
            // 
            // radioButtonNaoFezCompras
            // 
            this.radioButtonNaoFezCompras.AutoSize = true;
            this.radioButtonNaoFezCompras.Location = new System.Drawing.Point(414, 137);
            this.radioButtonNaoFezCompras.Name = "radioButtonNaoFezCompras";
            this.radioButtonNaoFezCompras.Size = new System.Drawing.Size(114, 19);
            this.radioButtonNaoFezCompras.TabIndex = 15;
            this.radioButtonNaoFezCompras.TabStop = true;
            this.radioButtonNaoFezCompras.Text = "Não fez compras";
            this.radioButtonNaoFezCompras.UseVisualStyleBackColor = true;
            this.radioButtonNaoFezCompras.CheckedChanged += new System.EventHandler(this.radioButtonNaoFezCompras_CheckedChanged);
            // 
            // radioButtonFezCompras
            // 
            this.radioButtonFezCompras.AutoSize = true;
            this.radioButtonFezCompras.Location = new System.Drawing.Point(414, 162);
            this.radioButtonFezCompras.Name = "radioButtonFezCompras";
            this.radioButtonFezCompras.Size = new System.Drawing.Size(91, 19);
            this.radioButtonFezCompras.TabIndex = 16;
            this.radioButtonFezCompras.TabStop = true;
            this.radioButtonFezCompras.Text = "Fez compras";
            this.radioButtonFezCompras.UseVisualStyleBackColor = true;
            this.radioButtonFezCompras.CheckedChanged += new System.EventHandler(this.radioButtonFezCompras_CheckedChanged);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(577, 161);
            this.textBoxValor.MaxLength = 2;
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(149, 23);
            this.textBoxValor.TabIndex = 17;
            this.textBoxValor.Visible = false;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(538, 166);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(33, 15);
            this.labelValor.TabIndex = 18;
            this.labelValor.Text = "Valor";
            this.labelValor.Visible = false;
            this.labelValor.Click += new System.EventHandler(this.labelValor_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(415, 229);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(59, 15);
            this.labelResultado.TabIndex = 19;
            this.labelResultado.Text = "Resultado";
            // 
            // richTextBoxResultado
            // 
            this.richTextBoxResultado.Enabled = false;
            this.richTextBoxResultado.Location = new System.Drawing.Point(415, 247);
            this.richTextBoxResultado.Name = "richTextBoxResultado";
            this.richTextBoxResultado.ReadOnly = true;
            this.richTextBoxResultado.Size = new System.Drawing.Size(311, 138);
            this.richTextBoxResultado.TabIndex = 20;
            this.richTextBoxResultado.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(495, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Limpar Campos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxResultado);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.radioButtonFezCompras);
            this.Controls.Add(this.radioButtonNaoFezCompras);
            this.Controls.Add(this.checkBoxAuxilioEducacao);
            this.Controls.Add(this.labelValorHora);
            this.Controls.Add(this.textBoxValorHora);
            this.Controls.Add(this.textBoxQuantidadeHoras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSomar);
            this.Controls.Add(this.textBoxNumero2);
            this.Controls.Add(this.textBoxNumero1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonProcessar);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Auxílio Educação";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.Button buttonProcessar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumero1;
        private System.Windows.Forms.TextBox textBoxNumero2;
        private System.Windows.Forms.Button buttonSomar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxQuantidadeHoras;
        private System.Windows.Forms.TextBox textBoxValorHora;
        private System.Windows.Forms.Label labelValorHora;
        private System.Windows.Forms.CheckBox checkBoxAuxilioEducacao;
        private System.Windows.Forms.RadioButton radioButtonNaoFezCompras;
        private System.Windows.Forms.RadioButton radioButtonFezCompras;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.RichTextBox richTextBoxResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

