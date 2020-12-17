using Microsoft.Extensions.Configuration;

namespace Produtivo.Repository
{
    public class RepositoryConnector
    {
        public IConfiguration _configuration;

        public RepositoryConnector(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnection()
        {
            return _configuration.GetSection("ConnectionStrings").GetSection("ProdutivoDb").Value;
        }
    }
}
