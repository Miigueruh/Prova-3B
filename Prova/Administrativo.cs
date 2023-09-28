using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class Administrativo:Funcionario
    {
        public string Funcao { get; set; }

        public double Acrescimo()
        {
            double acrescimo = ((Salario / 100) * 17) + 250;
            return acrescimo;
        }

    }
}
