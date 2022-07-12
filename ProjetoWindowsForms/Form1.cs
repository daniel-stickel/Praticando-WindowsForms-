using ProjetoWindowsForms.Calculos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonProcessar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text.Trim();
            string sobrenome = textBoxSobrenome.Text.Trim();

            if (nome.Length < 3)
            {
                ApresentarMensagemDeErro(
                    "Nome deve conter no mínimo 3 caracteres");
                return;
            }

            if (nome.Length < 4)
            {
                ApresentarMensagemDeErro(
                    "Sobrenome deve conter no mínimo 3 caracteres");
                return;
            }

            string nomeCompleto = nome + " " + sobrenome;

            MessageBox.Show("Nome completo: " + nomeCompleto);
        }

        private void ApresentarMensagemDeErro(string texto)
        {
            MessageBox.Show(
                    texto,
                    "Erro",
                    MessageBoxButtons.OK,
                    (MessageBoxIcon)16);
        }

        private void buttonSomar_Click(object sender, EventArgs e)
        {
            // Forma antiga
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero1 = 0;
            int numero2 = 0;
            try
            {
                numero1 = Convert.ToInt32(textBoxNumero1.Text.Trim());

                textBoxNumero1.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                textBoxNumero1.ForeColor = Color.Red;

                MessageBox.Show(
                    "Número 1 deve conter número inteiro",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                textBoxNumero1.Focus();

                return;
            }
            try
            {
                numero2 = Convert.ToInt32(textBoxNumero2.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Número 2 deve conter número inteiro",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                textBoxNumero2.Focus();

                return;
            }
            var soma = numero1 + numero2;
            MessageBox.Show($"Soma: {soma}");
        }

        private void labelValor_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonFezCompras_CheckedChanged(object sender, EventArgs e)
        {
            labelValor.Visible = true;
            textBoxValor.Visible = true;
        }

        private void radioButtonNaoFezCompras_CheckedChanged(object sender, EventArgs e)
        {
            labelValor.Visible = false;
            textBoxValor.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxValorHora.Clear();
            textBoxQuantidadeHoras.Clear();
            checkBoxAuxilioEducacao.Checked = false;
            radioButtonNaoFezCompras.Checked = false;
            radioButtonNaoFezCompras.Checked = true;
            textBoxValor.Clear();
            richTextBoxResultado.Clear();

            textBoxQuantidadeHoras.Focus();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quantidadeHoras = Convert.ToInt32(textBoxQuantidadeHoras.Text);
            double ValorHora = Convert.ToDouble(textBoxValorHora.Text);
            double valorCompras = Convert.ToDouble(textBoxValor.Text);
            bool fezCompras;

            if (radioButtonFezCompras.Checked == true)
            {
                fezCompras = true;
                valorCompras = Convert.ToDouble(textBoxValor.Text);
            }
            else
            {
                fezCompras = false;
                valorCompras = 0;
            }

            bool auxilioEducacao = checkBoxAuxilioEducacao.Checked;

            CalculoFolhaDePagamento calculoFolhaDePagamento = new CalculoFolhaDePagamento();
            calculoFolhaDePagamento.AuxilioEducacao = auxilioEducacao;
            calculoFolhaDePagamento.FezCompras = fezCompras;
            calculoFolhaDePagamento.ValorCompras = valorCompras;
            calculoFolhaDePagamento.ValorHoras = Convert.ToDouble(textBoxValorHora.Text);
            calculoFolhaDePagamento.QuantidadeHoras = quantidadeHoras;

            var salarioBruto = calculoFolhaDePagamento.CalcularSalarioBruto();
            var salarioLiquido = calculoFolhaDePagamento.CalcularSalarioLiquido();

            richTextBoxResultado.Text = $@"Salário Bruto: R$ {salarioBruto}
            Salário Líquido: R$ " + (salarioLiquido);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
