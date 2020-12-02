using Produtivo.Dominio.Contratos;
using Produtivo.Dominio.Entidades;
using Produtivo.Repositorio.Contexto;

namespace Produtivo.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(ProdutivoContexto contexto) : base(contexto)
        {
        }
    }
}
