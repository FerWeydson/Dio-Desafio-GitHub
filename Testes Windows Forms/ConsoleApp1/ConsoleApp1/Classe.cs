using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IFuncionario
    {
        void Nome(string nome);
        void Sobrenome(string sobrenome);
        void Salario(float salario);

    }
    class Motorista : IFuncionario
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public float Salario { get; set; }


        void IFuncionario.Nome(string nome)
        {
            this.Nome = nome;
        }
        void IFuncionario.Sobrenome(string sobrenome)
        {
            this.Sobrenome = sobrenome;
        }
        void IFuncionario.Salario(float salario)
        {
            this.Salario = salario;
        }
    }
    
}
