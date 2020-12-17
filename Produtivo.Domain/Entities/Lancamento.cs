using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Produtivo.Domain.Entities
{
    [Table("Lancamento")]
    public class Lancamento : EntityBase<int>
    {
        [Required]
        [Column("Documento")]
        public string Documento { get; set; }

        [Required]
        [Column("Referencia")]
        public string Referencia { get; set; }

        [Required]
        [Column("Vencimento")]
        [DataType(DataType.Date)]
        public DateTime Vencimento { get; set; }

        [Column("EnviadoFinanceiro")]
        [DataType(DataType.Date)]
        public DateTime? EnviadoFinanceiro { get; set; }

        [Required]
        [Column("Responsavel")]
        public string Responsavel { get; set; }

        [Required]
        [Column("Valor")]
        public decimal Valor { get; set; }

        [Column("Pagamento")]
        [DataType(DataType.Date)]
        public DateTime? Pagamento { get; set; }

        [Required]
        [Column("Pago")]
        public bool Pago { get; set; }

        [Required]
        [Column("UsuarioId")]
        public int CodigoUsuarioCadastrou { get; set; }
    }
}
