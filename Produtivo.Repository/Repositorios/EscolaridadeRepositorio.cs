using Produtivo.Dominio.Contratos;
using Produtivo.Dominio.Entidades;
using Produtivo.Repositorio.Contexto;

namespace Produtivo.Repositorio.Repositorios
{
    public class EscolaridadeRepositorio : BaseRepositorio<Escolaridade>, IEscolaridadeRepositorio
    {
        public EscolaridadeRepositorio(ProdutivoContexto contexto) : base(contexto)
        {
        }
    }
}
