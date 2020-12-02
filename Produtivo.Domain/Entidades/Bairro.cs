using System;

namespace Produtivo.Dominio.Entidades
{
    public class Bairro : Entidade
    {
        public Bairro() { }
        public int? Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal Fator { get; set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public override void Validar()
        {
            LimparMensagemValidacao();

            if(string.IsNullOrEmpty(Descricao))
                AdicionarCritica("Critica: A descrição é obrigatória.");

            if (Fator == 0)
                AdicionarCritica("Critica: O Fator de conversão não pode ser zerado.");

        }
    }
}