using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class Medico:Funcionario
    {
        public string Crm { get; set; }
        public double ValorHoraExtra { get; set; }
        public string Especialidade { get; set; }

        public double Beneficio()
        {
            double auxilioPeri = (Salario / 100) * 22;
            return auxilioPeri;
        }

    }
}
