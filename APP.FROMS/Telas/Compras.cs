using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    
using System.Windows.Forms;
using APP.FROMS.Class;
using APP.FROMS.Metodos;

namespace APP.FROMS.Telas
{
    public partial class Compras : Form
    {
        CompraSet set = new CompraSet();
        DataTable compra;

        public Compras()
        {
            InitializeComponent();
        }

        private void Painel_Estoque_ControlAdded(object sender, ControlEventArgs e)


        {

        }

        private void dtGrid_Estoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGrid_Compra.SelectedRows.Count > 0)
            {
                int compraID = Convert.ToInt32(dtGrid_Compra.SelectedRows[0].Cells["compraIDDataGridViewTextBoxColumn"].Value);
                SetRecibo setRecibo = new SetRecibo();
                setRecibo.GerarRecibo(compraID);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma compra para gerar o recibo.", "Seleção de Compra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            compra = set.CompraaSet();
            dtGrid_Compra.DataSource = compra;

        }

        private void picBox_home_Click(object sender, EventArgs e)
        {

        }

        private async void btn_Relatorio_Estoque_Click(object sender, EventArgs e)
        {
            string connectionString = @"server=localhost;user=root;password='09072006';database=EmpresaCosmeticos";
            var dadosAcesso = new RelatorioFinanceiroDadoscs(connectionString);

            try
            {
                
                var dadosRelatorioDetalhado = await dadosAcesso.ObterDadosRelatorioDetalhadoAsync();

               
                string caminhoArquivoDetalhado = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RelatorioDetalhado_Estoque.pdf");
                var geradorPDF = new GeradorRelatorioPDF();

                
                await geradorPDF.GerarPDFAsync(caminhoArquivoDetalhado, dadosRelatorioDetalhado);

                MessageBox.Show($"Relatório detalhado gerado com sucesso e salvo em: {caminhoArquivoDetalhado}", "Relatório Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao gerar o relatório: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Inicio_Estoque_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void btn_Vendas_Estoque_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vendas vendas = new Vendas();   
            vendas.Show();
        }

        private void btn_Estoque_Estoque_Click(object sender, EventArgs e)
        {
            this.Hide();    
            Estoque estoque = new Estoque();
            estoque.Show();
        }
    }
}
