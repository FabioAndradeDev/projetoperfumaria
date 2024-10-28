using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP.FROMS.Dal
{


    public class Conexao
    {
        private MySqlConnection con;
        private string connectionString = @"server=localhost;user=root;password='';database=EmpresaCosmeticos";

        public Conexao()
        {
            con = new MySqlConnection(connectionString);
        }

        public MySqlConnection Conectar()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}

