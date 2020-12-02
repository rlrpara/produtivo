using Produtivo.Dominio.Contratos;
using Produtivo.Dominio.Entidades;
using Produtivo.Repositorio.Contexto;

namespace Produtivo.Repositorio.Repositorios
{
    public class EstadoCivilRepositorio : BaseRepositorio<EstadoCivil>, IEstadoCivilRepositorio
    {
        public EstadoCivilRepositorio(ProdutivoContexto contexto) : base(contexto)
        {
        }
    }
}
