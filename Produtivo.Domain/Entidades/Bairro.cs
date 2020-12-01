using System;
using System.Collections.Generic;

namespace Produtivo.Dominio.Entidades
{
    public class Bairro : Entidade
    {
        public Bairro() { }
        public int? Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal Fator { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<Municipe> Municipe { get; set; }

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