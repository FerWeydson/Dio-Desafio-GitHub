using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades__métodos_e_contrutores_C_.Models
{
    public class Curso
    {
        public string Name { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeAluno(){
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool RemoverAluno(Pessoa aluno){
            return Alunos.Remove(aluno);
        }
        public void ListarAlunos(){
            System.Console.WriteLine($"Os alunos do curso de {Name} são");

            for (int i = 0; i < Alunos.Count; i++)
            {
                string texto = $"N° {i} - {Alunos[i].Name}";
                System.Console.WriteLine(texto);
            } 
        }
    }
}