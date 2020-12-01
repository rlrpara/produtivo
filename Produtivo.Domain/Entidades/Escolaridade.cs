using System.Collections.Generic;

namespace Produtivo.Dominio.Entidades
{
    public class Escolaridade : Entidade
    {
        public Escolaridade() {}
        public int? Codigo { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Municipe> Municipe { get; set; }

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