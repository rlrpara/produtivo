using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Produtivo.Domain.Entities
{
    [Table("Usuario")]
    public class Usuario : EntityBase<int>
    {
        [Required]
        [Column("Nome")]
        public string Nome { get; set; }

        [Required]
        [Column("Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Column("Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required]
        [Column("Whatsapp")]
        [DataType(DataType.PhoneNumber)]
        public string Whatsapp { get; set; }

        [Required]
        [Column("Whatsapp")]
        [DataType(DataType.PhoneNumber)]
        public string Celular { get; set; }
    }
}
