using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades__métodos_e_contrutores_C_.Models
{
    public class Vendas
    {
        public Vendas (int id, string produto, decimal preco, DateTime dataVenda){
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
        }

        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }   
        public DateTime DataVenda { get; set; } 
    }
}