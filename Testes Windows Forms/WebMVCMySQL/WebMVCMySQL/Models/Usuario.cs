using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVCMySQL.Models
{
    [Table("Usuario")]                 //alterar o nome da tabela no banco
    public class Usuario
    {
        [Display(Name="Código")]       //nome que vai aparecer na tela
        [Column("Id")]                 //funciona igual o table
        public int Id { get; set; }

        [Display(Name = "Nome")]     //nome que vai aparecer na tela
        [Column("Nome")]
        public string Nome { get; set; }
    }
}
