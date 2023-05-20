using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class Caminhao : Veiculo
    {
        public override string Combustivel()
        {
            return "Diesel";
        }

        public override string Marca()
        {
            return "Volvo";
        }
    }
}
