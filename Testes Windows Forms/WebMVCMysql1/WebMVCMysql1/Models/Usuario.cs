using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVCMysql1.Models
{
    [Table("TB_Usuario")]
    public class Usuario
    {
        [Display(Name = "Códiogo")]
        [Column("Id")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }    
    }
}
