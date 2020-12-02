using Produtivo.Dominio.Contratos;
using Produtivo.Dominio.Entidades;
using Produtivo.Repositorio.Contexto;

namespace Produtivo.Repositorio.Repositorios
{
    public class LancamentoRepositorio : BaseRepositorio<Lancamento>, ILancamentoRepositorio
    {
        public LancamentoRepositorio(ProdutivoContexto contexto) : base(contexto)
        {
        }
    }
}
