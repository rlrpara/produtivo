using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Produtivo.Domain.Entities
{
    [Table("Sexo")]
    public class Sexo : EntityBase<int>
    {
        [Required]
        [Column("Descricao")]
        public string Descricao { get; set; }
    }
}