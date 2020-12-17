using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Produtivo.Domain.Entities
{
    [Table(name: "Bairro")]
    public class Bairro : EntityBase<int>
    {
        [Required]
        [Column(name: "Descricao")]
        public string Descricao { get; set; }
    }
}