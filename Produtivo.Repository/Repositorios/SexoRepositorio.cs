using Produtivo.Dominio.Contratos;
using Produtivo.Dominio.Entidades;
using Produtivo.Repositorio.Contexto;

namespace Produtivo.Repositorio.Repositorios
{
    public class SexoRepositorio : BaseRepositorio<Sexo>, ISexoRepositorio
    {
        public SexoRepositorio(ProdutivoContexto contexto) : base(contexto)
        {
        }
    }
}
