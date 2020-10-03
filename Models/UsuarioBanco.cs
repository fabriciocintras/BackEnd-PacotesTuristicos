using System.Collections.Generic;
using MySqlConnector;
namespace Viagem.Models
{
    public class UsuarioBanco
    {
        private const string dadosConexao = "Database=Viagem; Data Source= localhost;User Id= root";

        public void Inserir(Usuario novoUsuario)
        {
            MySqlConnection Conexao = new MySqlConnection(dadosConexao);

            Conexao.Open();

            string query = "INSERT INTO Usuario(Nome,DataNascimento,Login, Senha, Tipo) VALUES (@Nome,@DataNascimento, @Login, @Senha, @Tipo)";

            MySqlCommand comando = new MySqlCommand(query,Conexao);

            comando.Parameters.AddWithValue("@Nome", novoUsuario.Nome);
            comando.Parameters.AddWithValue("@DataNascimento", novoUsuario.DataNascimento);
            comando.Parameters.AddWithValue("@Login", novoUsuario.Login);
            comando.Parameters.AddWithValue("@Senha", novoUsuario.Senha);
            comando.Parameters.AddWithValue("@Tipo", novoUsuario.Tipo);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public List<Usuario> BuscarTodos()
        {
            MySqlConnection Conexao = new MySqlConnection(dadosConexao);
            Conexao.Open();
            string query = "SELECT * FROM Usuario";
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            MySqlDataReader reader = comando.ExecuteReader();

            List<Usuario> lista = new List<Usuario>();
            while (reader.Read())
            {
                Usuario user = new Usuario();
                user.Id = reader.GetInt32("id");
                user.Tipo = reader.GetInt32("Tipo");

                if(!reader.IsDBNull(reader.GetOrdinal("Nome")))
                {
                    user.Nome = reader.GetString("Nome");
                }
                if(!reader.IsDBNull(reader.GetOrdinal("DataNascimento")))
                {
                    user.DataNascimento = reader.GetDateTime("DataNascimento");
                }
                if(!reader.IsDBNull(reader.GetOrdinal("Login")))
                {
                    user.Login = reader.GetString("Login");
                }
                if(!reader.IsDBNull(reader.GetOrdinal("Senha")))
                {
                    user.Senha = reader.GetString("Senha");
                }
                lista.Add(user);
                
            }
            Conexao.Close();
            return lista;
        }

        public Usuario BuscaUsuario(Usuario usuario)
        {
            MySqlConnection Conexao = new MySqlConnection(dadosConexao);
            Conexao.Open();
            string sql = " SELECT * FROM Usuario WHERE Login = @Login AND Senha = @Senha";

            MySqlCommand comandoQuery = new MySqlCommand(sql, Conexao);
            comandoQuery.Parameters.AddWithValue("@Login",usuario.Login );
            comandoQuery.Parameters.AddWithValue("@Senha",usuario.Senha );
            MySqlDataReader reader = comandoQuery.ExecuteReader();
            Usuario novoUsuario = null;
            if(reader.Read())
            {
                novoUsuario = new Usuario();
                novoUsuario.Id = reader.GetInt32("Id");
                novoUsuario.Tipo = reader.GetInt32("Tipo");

                if(!reader.IsDBNull(reader.GetOrdinal("Nome")))
                    novoUsuario.Nome = reader.GetString("Nome");
                
                if(!reader.IsDBNull(reader.GetOrdinal("DataNascimento")))
                    novoUsuario.DataNascimento = reader.GetDateTime("DataNascimento");

                if(!reader.IsDBNull(reader.GetOrdinal("Login")))
                    novoUsuario.Login = reader.GetString("Login");

                if(!reader.IsDBNull(reader.GetOrdinal("Senha")))
                    novoUsuario.Senha= reader.GetString("Senha");
                
            }
            Conexao.Close();
            return novoUsuario;

        }

    }
}