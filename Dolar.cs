using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class Dolar : Moeda
    {
        public override decimal CalcularValorMensal(decimal valor)
        {
            return 1500;
        }
        public override decimal CalcularValorDia(decimal valor)
        {
            return ((decimal)5.6) * 2;
        }

    }

}
