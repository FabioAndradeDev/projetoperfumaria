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
using DevExpress.XtraEditors.Filtering;

namespace APP.FROMS.Metodos
{
    public class RemoveProd
    {
        private Conexao conexao;

        public RemoveProd()
        {
            conexao = new Conexao(); 
        }

        public DataTable Estoque(int idProduto)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection con = conexao.Conectar();
            try
            {
                string query = "delete from Produtos where ProdutoID = @idProduto";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idProduto", idProduto);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao remover produto: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return dataTable;
        }
    }
}
