using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIngressoExpressFestivalCidade
{
    class ClienteFestival
    {
        public string NomeFa { get; set; } = string.Empty;
        public int QtdDias { get; set; }

        public string CDesconto { get; set; }

        public int PontosClube { get; set; }

        public double TaxaServico = 15.0;




        public double CalculaBruto()
        {

            return TaxaServico + 120 * QtdDias;
        }


        public double CalculaLiquido()
        {
            if (CDesconto.ToUpper() == "ROCK10")
            {

                return CalculaBruto() - CalculaBruto() * 0.1;


            }
            else {

                return CalculaBruto();
            }

            
        }







    }
}
