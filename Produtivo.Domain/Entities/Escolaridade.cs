using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Produtivo.Domain.Entities
{
    [Table("Escolaridade")]
    public class Escolaridade : EntityBase<int>
    {
        [Required]
        [Column("Descricao")]
        public string Descricao { get; set; }
    }
}