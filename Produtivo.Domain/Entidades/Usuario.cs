using System;
using System.Collections.Generic;

namespace Produtivo.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public Usuario() { }
        public int? Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Whatsapp { get; set; }
        public string Celular { get; set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public virtual ICollection<Lancamento> Lancamentos { get; set; }

        public override void Validar()
        {
            LimparMensagemValidacao();

            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Nome é obrigatório");

            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("O Email é obrigatório");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("A Senha é obrigatório");

            if (string.IsNullOrEmpty(Whatsapp))
                AdicionarCritica("O Whatsapp é obrigatório");

            if (string.IsNullOrEmpty(Celular))
                AdicionarCritica("O Celular é obrigatório");
        }
    }
}
