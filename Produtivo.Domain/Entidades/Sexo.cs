using System;
using System.Collections.Generic;

namespace Produtivo.Dominio.Entidades
{
    public class Sexo : Entidade
    {
        public Sexo() {}
        public int? Codigo { get; set; }
        public string Descricao { get; set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public override void Validar()
        {
            LimparMensagemValidacao();

            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarCritica("A Descrição é obrigatória");
            }
        }
    }
}