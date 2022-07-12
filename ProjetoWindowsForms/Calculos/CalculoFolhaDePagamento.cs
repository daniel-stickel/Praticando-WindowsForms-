using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWindowsForms.Calculos
{
    public class CalculoFolhaDePagamento
    {
        public int QuantidadeHoras { get; set; }

        public double ValorHoras { get; set; }

        public bool AuxilioEducacao { get; set; }

        public bool FezCompras { get; set; }

        public double ValorCompras { get; set; }

        // Método con retorno do tipo double
        public double CalcularSalarioBruto()
        {
            var salarioBruto = ValorHoras * QuantidadeHoras;

            return salarioBruto;
        }

        //Método sem retorno do tipo double
        public double CalcularSalarioLiquido()
        {

            var salarioBruto = CalcularSalarioBruto();

            var auxilioEducacao = 0;

                if (AuxilioEducacao == true)
            {
                auxilioEducacao = 500;
            }

            var salarioliquido = salarioBruto - ValorCompras + auxilioEducacao;



            return salarioliquido;
        }
    }

}

    
