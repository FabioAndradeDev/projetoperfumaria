using System;
using System.Windows.Forms;
using APP.FROMS.Dal;
using MySql.Data.MySqlClient;

namespace APP.FROMS.Metodos
{
    public class VendaRepository
    {
        private readonly Conexao conexao; 

        public VendaRepository(Conexao conexao)
        {
            this.conexao = conexao;
        }

        public bool InserirVenda(int usuarioId, DateTime dataVenda, decimal totalVenda)
        {
            try
            {
                using (MySqlConnection con = conexao.Conectar()) 
                {
                    string query = "INSERT INTO Vendas (UsuarioID, DataVenda, TotalVenda) VALUES (@UsuarioID, @DataVenda, @TotalVenda)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UsuarioID", usuarioId);
                    cmd.Parameters.AddWithValue("@DataVenda", dataVenda);
                    cmd.Parameters.AddWithValue("@TotalVenda", totalVenda);

                    int linhasAfetadas = cmd.ExecuteNonQuery();
                    return linhasAfetadas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}