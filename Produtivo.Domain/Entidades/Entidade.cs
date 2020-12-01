using System.Collections.Generic;
using System.Linq;

namespace Produtivo.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagemValidacao { get; set; }
        private List<string> mensagemValidacao
        {
            get { return _mensagemValidacao ??= new List<string>(); }
        }

        protected void LimparMensagemValidacao()
        {
            mensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            _mensagemValidacao.Add(mensagem);
        }

        public abstract void Validar();

        protected bool EhValido
        {
            get { return mensagemValidacao.Any();  }
        }
    }
}
