using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Produtivo.Domain.Entities;
using Produtivo.Domain.Interface;
using System.Collections.Generic;
using System.Linq;
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
            pam.Add("@Senha", entity.Senha);
            pam.Add("@Celular", entity.Celular);
            pam.Add("@Whatsapp", entity.Whatsapp);
            pam.Add("@DataCadastro", entity.DataCadastro);
            pam.Add("@DataAtualizacao", entity.DataAtualizacao);

            var sqlInserir = new StringBuilder();

            sqlInserir.AppendLine("INSERT INTO Usuario ( Nome,  Email,  Senha, Celular,   Whatsapp,     CreatedAt,        UpdatedAt)");
            sqlInserir.AppendLine("             VALUES (@Nome, @Email, @Senha, @Celular, @Whatsapp, @DataCadastro, @DataAtualizacao)");

            using MySqlConnection conn = new MySqlConnection(GetConnection());
            conn.Execute(sqlInserir.ToString(), pam);
        }

        public Usuario Get(int id)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine("SELECT Codigo,");
            sqlPesquisa.AppendLine("       Nome,");
            sqlPesquisa.AppendLine("       Email,");
            sqlPesquisa.AppendLine("       Senha,");
            sqlPesquisa.AppendLine("       Whatsapp,");
            sqlPesquisa.AppendLine("       Celular,");
            sqlPesquisa.AppendLine("       CreatedAt as DataCadastro,");
            sqlPesquisa.AppendLine("       UpdatedAt as DataAtualizacao");
            sqlPesquisa.AppendLine("  FROM Usuario");
            sqlPesquisa.AppendLine($"WHERE Codigo = {id}");

            using MySqlConnection conn = new MySqlConnection(GetConnection());
            return conn.Query<Usuario>(sqlPesquisa.ToString()).FirstOrDefault();
        }

        public Login logar(Login login)
        {
            var pam = new DynamicParameters();

            pam.Add("@Email", login.Email);
            pam.Add("@Senha", login.Senha);

            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine("SELECT Codigo,");
            sqlPesquisa.AppendLine("       Nome,");
            sqlPesquisa.AppendLine("       Email,");
            sqlPesquisa.AppendLine("       Senha,");
            sqlPesquisa.AppendLine("       Whatsapp,");
            sqlPesquisa.AppendLine("       Celular,");
            sqlPesquisa.AppendLine("       CreatedAt as DataCadastro,");
            sqlPesquisa.AppendLine("       UpdatedAt as DataAtualizacao");
            sqlPesquisa.AppendLine("  FROM Usuario");
            sqlPesquisa.AppendLine($"WHERE Email = @Email AND Senha = @Senha");

            using MySqlConnection conn = new MySqlConnection(GetConnection());
            return conn.Query<Login>(sqlPesquisa.ToString(), pam).FirstOrDefault();
        }

        public IEnumerable<Usuario> GetAll()
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine("SELECT Codigo,");
            sqlPesquisa.AppendLine("       Nome,");
            sqlPesquisa.AppendLine("       Email,");
            sqlPesquisa.AppendLine("       Senha,");
            sqlPesquisa.AppendLine("       Whatsapp,");
            sqlPesquisa.AppendLine("       Celular,");
            sqlPesquisa.AppendLine("       CreatedAt as DataCadastro,");
            sqlPesquisa.AppendLine("       UpdatedAt as DataAtualizacao");
            sqlPesquisa.AppendLine("  FROM Usuario");

            using MySqlConnection conn = new MySqlConnection(GetConnection());
            return conn.Query<Usuario>(sqlPesquisa.ToString());
        }

        public void Remove(Usuario entity)
        {
            var pam = new DynamicParameters();
            pam.Add("@Codigo", entity.Codigo);

            var sqlExcluir = new StringBuilder();

            sqlExcluir.AppendLine("DELETE FROM Usuario WHERE Codigo = @Codigo");

            using MySqlConnection conn = new MySqlConnection(GetConnection());
            conn.Execute(sqlExcluir.ToString(), pam);
        }

        public void Update(Usuario entity)
        {
            var pam = new DynamicParameters();
            pam.Add("@Codigo", entity.Codigo);
            pam.Add("@Nome", entity.Nome);
            pam.Add("@Email", entity.Email);
            pam.Add("@Celular", entity.Celular);
            pam.Add("@Senha", entity.Senha);
            pam.Add("@Whatsapp", entity.Whatsapp);
            pam.Add("@DataAtualizacao", entity.DataAtualizacao);

            var sqlAtualizar = new StringBuilder();
            sqlAtualizar.AppendLine("UPDATE Usuario ");
            sqlAtualizar.AppendLine("   SET Nome = @Nome,");
            sqlAtualizar.AppendLine("       Email = @Email,");
            sqlAtualizar.AppendLine("       Senha = @Senha,");
            sqlAtualizar.AppendLine("       Whatsapp = @Whatsapp,");
            sqlAtualizar.AppendLine("       Celular = @Celular,");
            sqlAtualizar.AppendLine("       UpdatedAt = @DataAtualizacao");
            sqlAtualizar.AppendLine(" WHERE Codigo = @Codigo");

            using MySqlConnection conn = new MySqlConnection(GetConnection());
            conn.Execute(sqlAtualizar.ToString(), pam);
        }
    }
}
