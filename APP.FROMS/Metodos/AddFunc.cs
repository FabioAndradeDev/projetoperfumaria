using System;
using System.Windows.Forms;
using APP.FROMS.Dal;
using MySql.Data.MySqlClient;

namespace APP.FROMS.Metodos
{
    public class AddFunc
    {
        private readonly string connectionString;

        public AddFunc(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool CadastrarFuncionario(string nome, string perfil, string senha, int id)
        {
            bool cadastradoComSucesso = false;
            MySqlConnection conexao = new Conexao().Conectar(); 

            try
            {
                string query = "INSERT INTO Usuarios (Nome, Perfil, Senha, UsuarioID) VALUES (@Nome, @Perfil, @Senha, @ID)";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Perfil", perfil);
                cmd.Parameters.AddWithValue("@Senha", senha);
                cmd.Parameters.AddWithValue("@ID", id);

                int linhasAfetadas = cmd.ExecuteNonQuery();
                if (linhasAfetadas > 0)
                {
                    cadastradoComSucesso = true;
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar o funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar funcionário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close(); 
            }

            return cadastradoComSucesso;
        }
    }
}
