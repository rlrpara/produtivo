using Produtivo.Dominio.Contratos;
using Produtivo.Repositorio.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace Produtivo.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly ProdutivoContexto Contexto;
        public BaseRepositorio(ProdutivoContexto contexto)
        {
            Contexto = contexto;
        }
        public void Adicionar(TEntity entity)
        {
            Contexto.Set<TEntity>().Add(entity);
            Contexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            Contexto.Set<TEntity>().Update(entity);
            Contexto.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return Contexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return Contexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            Contexto.Set<TEntity>().Remove(entity);
            Contexto.SaveChanges();
        }

        public void Dispose()
        {
            Contexto.Dispose();
        }
    }
}
