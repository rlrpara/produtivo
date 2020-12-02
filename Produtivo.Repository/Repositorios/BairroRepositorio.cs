using Produtivo.Dominio.Contratos;
using Produtivo.Dominio.Entidades;
using Produtivo.Repositorio.Contexto;

namespace Produtivo.Repositorio.Repositorios
{
    public class BairroRepositorio : BaseRepositorio<Bairro>, IBairroRepositorio
    {
        public BairroRepositorio(ProdutivoContexto contexto) : base(contexto)
        {
        }
    }
}
