namespace Produtivo.Dominio.ObjetoValor
{
    public class Endereco
    {
        public Endereco(int? codigo, string cep, string logradouro, string complemento, string numero, string bairro, string localidade, string uf)
        {
            this.Codigo = codigo;
            this.CEP = cep;
            this.Logradouro = logradouro;
            this.Complemento = complemento;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Localidade = localidade;
            this.Uf = uf;
        }
        public int? Codigo { get; private set; }
        public string CEP { get; private set; }
        public string Logradouro { get; private set; }
        public string Complemento { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Localidade { get; private set; }
        public string Uf { get; private set; }
    }
}
