using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Produtivo.Domain.Entities
{
    [Table("EstadoCivil")]
    public class EstadoCivil : EntityBase<int>
    {
        [Required]
        [Column("Descricao")]
        public string Descricao { get; set; }
    }
}