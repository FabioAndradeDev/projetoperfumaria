using APP.FROMS.Dal;
using APP.FROMS;
using APP.FROMS.Telas;
using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils.Colors;
using APP.FROMS.Class;
using System.ServiceModel.Channels;
using System.Windows.Forms;

namespace APP.FROMS.Metodos
{
    public class AddProduto
    {
        private Conexao conexao;

        public AddProduto()
        {
            conexao = new Conexao();
        }

        public DataTable Estoque(int idProduto, string nome, string descricao, decimal preco, int qntdEstoque, string categoria)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = conexao.Conectar();
            try
            {
                string query = "INSERT INTO Produtos (Nome, Descricao, Preco, QuantidadeEstoque, Categoria) VALUES (@Nome, @Descricao, @Preco, @QuantidadeEstoque, @Categoria)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Descricao", descricao);
                cmd.Parameters.AddWithValue("@Preco", preco);
                cmd.Parameters.AddWithValue("@QuantidadeEstoque", qntdEstoque);
                cmd.Parameters.AddWithValue("@Categoria", categoria);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao inserir produto: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return dataTable;
        }
    }
}
