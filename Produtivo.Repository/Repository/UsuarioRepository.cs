using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Produtivo.Domain.Entities;
using Produtivo.Domain.Interface;
using System.Collections.Generic;
using System.Text;

namespace Produtivo.Repository.Repository
{
    public class UsuarioRepository : RepositoryConnector, IUsuarioRepository
    {
        public UsuarioRepository(IConfiguration configuration) : base(configuration) { }

        public void Add(Usuario entity)
        {
            var pam = new DynamicParameters();
            pam.Add("@Nome", entity.Nome);
            pam.Add("@Email", entity.Email);
            pam.Add("@Celular", entity.Celular);
            pam.Add("@Senha", entity.Senha);
            pam.Add("@Whatsapp", entity.Whatsapp);
            pam.Add("@DataCadastro", entity.DataCadastro);
            pam.Add("@DataAtualizacao", entity.DataAtualizacao);

            var sqlInserir = new StringBuilder();

            sqlInserir.AppendLine("INSERT INTO Usuarios ( Nome,  Email,  Celular,  Senha,  DataCadastro,  DataAtualizacao)");
            sqlInserir.AppendLine("                     (@Nome, @Email, @Celular, @Senha, @DataCadastro, @DataAtualizacao)");

            MySqlConnection conn = new MySqlConnection(GetConnection());
            conn.Execute(sqlInserir.ToString(), pam);
        }

        public Usuario Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Usuario> GetAll()
        {
            MySqlConnection conn = new MySqlConnection(GetConnection());

            return conn.Query<Usuario>("SELECT * FROM Usuario"); ;
        }

        public void Remove(Usuario entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Usuario entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
