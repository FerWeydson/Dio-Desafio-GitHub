using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp_Pottencial_dotNET_Developer.Models
{
    public class Pessoa
    {
        public string Name { get; set; }
        public string Sobrenome { get; set; }
        public int Age { get; set; }

        public void apresentar() {
            Console.WriteLine($"Olá, meu nome é {Name} {Sobrenome}, e tenho {Age} anos");
            
        }
    }
}