using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public double Salario { get; set; }
       
        public Funcionario() 
        {
        
        }
        public Funcionario(string nome, string cpf, string matricula, DateTime dataNascimento, string sexo, double salario) 
        {
             nome = Nome;
             cpf = Cpf;
             matricula = Matricula;
             dataNascimento = DataNascimento;
             sexo = Sexo;
             salario = Salario;
        }

        

    }
}
