using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Produtivo.Domain.Entities
{
    public class EntityBase<T> where T : struct
    {
        [Key]
        [Column(name: "Codigo")]
        public T Codigo { get; set; }
    }
}