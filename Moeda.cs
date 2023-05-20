using Projeto1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public abstract class Moeda
    {
        public abstract decimal CalcularValorMensal(decimal valor);

        public virtual decimal CalcularValorDia(decimal valor)
        { 
        return 0;
        }

    }
}
