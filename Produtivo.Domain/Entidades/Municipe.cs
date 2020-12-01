using Produtivo.Dominio.ObjetoValor;
using System;

namespace Produtivo.Dominio.Entidades
{
    public class Municipe : Entidade
    {
        public Municipe() { }
        public int? Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime? Nascimento { get; set; }
        public string Email { get; set; }
        public int? EnderecoId { get; set; }
        public Endereco Enderecos { get; set; }
        public int? SexoId { get; set; }
        public Sexo Sexos { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public int? EscolaridadeId { get; set; }
        public Escolaridade Esscolaridades { get; set; }
        public string Naturalidade { get; set; }
        public string NaturalidadeUF { get; set; }
        public string Nacionalidade { get; set; }
        public string Foto { get; set; }
        public int? EstadoCivilId { get; set; }
        public EstadoCivil EstadoCivis { get; set; }
        public bool Ativo { get; set; }

        public override void Validar()
        {
            LimparMensagemValidacao();

            if (EnderecoId == 0)
                AdicionarCritica("Não foi identificado o Endereço");
        }
    }
}
