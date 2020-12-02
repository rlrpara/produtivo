using System;

namespace Produtivo.Dominio.Entidades
{
    public class Lancamento : Entidade
    {
        public Lancamento() { }
        public int Codigo { get; set; }
        public string Documento { get; set; }
        public string Referencia { get; set; }
        public DateTime Vencimento { get; set; }
        public DateTime? EnviadoFinanceiro { get; set; }
        public string Responsavel { get; set; }
        public decimal Valor { get; set; }
        public DateTime? Pagamento { get; set; }
        public bool Pago { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuarios { get; set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public override void Validar()
        {
            LimparMensagemValidacao();

            if (string.IsNullOrEmpty(Documento))
                AdicionarCritica("O Documento é obrigatório");
            if (string.IsNullOrEmpty(Referencia))
                AdicionarCritica("A Referencia é obrigatória");
            if (Vencimento == null)
                AdicionarCritica("A Data de Vencimento é obrigatória");
        }
    }
}
