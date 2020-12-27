using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Produtivo.Domain.Entities
{
    [Table("Usuario")]
    public class Login
    {
        [Key]
        [Column("Codigo")]
        public int Codigo { get; set; }

        [Required]
        [Column("Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Column("Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }
    }
}
