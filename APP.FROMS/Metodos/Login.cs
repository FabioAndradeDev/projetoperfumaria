using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using APP.FROMS.Dal;
using System.Linq;

namespace APP.FROMS.Metodos
{
    public class LoginForm : Form
    {
        private Conexao conexao;

        public LoginForm()
        {
            conexao = new Conexao();
        }

        public bool VerificaLogin(string id, string senha)
        {
            bool resultado = false;
           
            MySqlConnection con = conexao.Conectar();
            try
            {
                string query = "SELECT * FROM Usuarios WHERE UsuarioID = @id AND Senha = @senha";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@senha", senha);
                MySqlDataReader reader = cmd.ExecuteReader();
                

                if (reader.HasRows)
                {
                    resultado = true;
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao verificar o login: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Desconectar();
            }
            return resultado;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            
            this.ClientSize = new System.Drawing.Size(1842, 253);
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}