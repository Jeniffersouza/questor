﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class Carro : Veiculo
    {
        public override string Combustivel()
        {
            return "Gasolina";
        }

        public override string Marca()
        {
            return "Honda";
        }
    }
}
