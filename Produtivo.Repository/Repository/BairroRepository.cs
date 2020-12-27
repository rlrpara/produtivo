using Microsoft.Extensions.Configuration;
using Produtivo.Domain.Entities;
using Produtivo.Domain.Interface;
using System.Collections.Generic;

namespace Produtivo.Repository.Repository
{
    public class BairroRepository : RepositoryConnector, IBairroRepository
    {
        public BairroRepository(IConfiguration configuration) : base(configuration) { }

        public void Add(Bairro entity)
        {
            throw new System.NotImplementedException();
        }

        public Bairro Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Bairro> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Bairro entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Bairro entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
