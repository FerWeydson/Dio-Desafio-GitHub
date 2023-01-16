using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades__métodos_e_contrutores_C_.Models
{
    public class Pessoa
    {
        // Criando constructor
        public Pessoa()
        {

        }
        public Pessoa(string name, int age)
        {
            Name = name;
            Age = age;
        }
        // Fazendo validações no get e set
        
        private string _name; // Campo
        private int _age;
        public string Name // propriedade (get e set)
        {
            get => _name.ToUpper();

            set
            {

                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _name = value;
            }
        }
        public int Age
        {
            get => _age;

            set {
                if(value < 0 ) {
                    throw new ArgumentException("Idade não pode ser menor do que 0");
                }
                _age = value;
            }
         }
        public void apresentar(){
            System.Console.WriteLine($"Nome: {Name} Idade: {Age}");
        }
    }
}