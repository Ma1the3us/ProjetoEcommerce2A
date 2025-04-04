using MySql.Data.MySqlClient;
using ProjetoEcommerce2A.Models;
using System.Data;

namespace ProjetoEcommerce2A.Repositorio
{

    public class UsuarioRepositorio
    {
        private readonly string _conexaoMySQL;

        public UsuarioRepositorio(IConfiguration configuration)
        {
            _conexaoMySQL = configuration.GetConnectionString("ConexaoMySQL");
        }
        public Usuario ObterUsuario(string email)
        {
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();
                MySqlCommand cmd = new("SELECT * FROM Usuario WHERE Email = @email", conexao);
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                /* cmd.Parameters.AddWithValue("@Email", email);*/

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                MySqlDataReader dr;

                Usuario usuario = new Usuario();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    usuario.Id = Convert.ToInt32(dr["Id"]);
                    usuario.Nome = (string)dr["Nome"];
                    usuario.Email = (string)dr["Email"];
                    usuario.Senha = (string)dr["Senha"];

                }
                return usuario;

            }
        }
    }
}
