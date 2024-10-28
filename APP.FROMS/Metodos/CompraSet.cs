using APP.FROMS.Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace APP.FROMS.Metodos
{
    public class CompraSet
    {
        private Conexao conexao;

        public CompraSet()
        {

            conexao = new Conexao();

        }

        public DataTable CompraaSet()
        {
            DataTable dataTable = new DataTable();

            MySqlConnection con = conexao.Conectar();

            try
            {
                string query = "SELECT * FROM Compras";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dataTable);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }

            return dataTable;
        }

    }
}
