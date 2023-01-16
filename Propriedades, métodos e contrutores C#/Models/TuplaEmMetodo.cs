using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades__métodos_e_contrutores_C_.Models
{
    public class TuplaEmMetodo
    {
        // Usando tupla em método - (para mais retornos em um só método)
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho){
            try{
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }catch (Exception){
                return (false, new string[0], 0);
                
            }
        }
    }
}