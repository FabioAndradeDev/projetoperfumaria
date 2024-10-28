using APP.FROMS.Dal;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace APP.FROMS.Metodos
{
    public class SetRecibo
    {
        private Conexao conexao;

        public SetRecibo()
        {
            conexao = new Conexao();
        }

        public void GerarRecibo(int compraID)
        {
            MySqlConnection con = conexao.Conectar();
            try
            {
              
                string queryCompra = "SELECT CompraID, DataCompra, TotalCompra FROM Compras WHERE CompraID = @CompraID";
                MySqlCommand cmdCompra = new MySqlCommand(queryCompra, con);
                cmdCompra.Parameters.AddWithValue("@CompraID", compraID);

              
                MySqlDataReader readerCompra = cmdCompra.ExecuteReader();

                if (readerCompra.Read())
                {
                    string recibo = "Recibo de Compra\n";
                    recibo += "ID da Compra: " + readerCompra["CompraID"] + "\n";
                    recibo += "Data da Compra: " + Convert.ToDateTime(readerCompra["DataCompra"]).ToString("dd/MM/yyyy HH:mm") + "\n";
                    recibo += "Total da Compra: R$ " + readerCompra["TotalCompra"] + "\n\n";

                    readerCompra.Close();

                   
                    string queryItens = @"
                        SELECT p.Nome, ic.Quantidade, ic.PrecoUnitario 
                        FROM ItensCompra ic 
                        INNER JOIN Produtos p ON ic.ProdutoID = p.ProdutoID 
                        WHERE ic.CompraID = @CompraID";

                    MySqlCommand cmdItens = new MySqlCommand(queryItens, con);
                    cmdItens.Parameters.AddWithValue("@CompraID", compraID);

                
                    MySqlDataReader readerItens = cmdItens.ExecuteReader();

                    
                    while (readerItens.Read())
                    {
                        recibo += readerItens["Nome"] + " - ";
                        recibo += "Quantidade: " + readerItens["Quantidade"] + ", ";
                        recibo += "Preço Unitário: R$ " + readerItens["PrecoUnitario"] + "\n";
                    }

                    readerItens.Close();

                    MessageBox.Show(recibo, "Recibo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Compra não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar o recibo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Desconectar();
            }
        }
    }
}