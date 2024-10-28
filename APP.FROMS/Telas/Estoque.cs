using Bunifu.UI.WinForms;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using MySql.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP.FROMS.Metodos;
using APP.FROMS.Class;


namespace APP.FROMS.Telas
{
    public partial class Estoque : Form
    {
        Metodos.DataSet set = new Metodos.DataSet();
        DataTable estoque;      
            public Estoque()
        {
            InitializeComponent();
        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        private void btn_Estoque_Click(object sender, EventArgs e)
        {
            Main redirecionar = new Main();
            redirecionar.ShowDialog();
            this.Close();

        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            estoque = set.Estoque();
            dtGrid_Estoque.DataSource = estoque;
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {  
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            RemoçãodeProduto remoçãodeProduto =  new RemoçãodeProduto ();
            remoçãodeProduto.Show();
        }

        private void btnAdd_Estoque_Click(object sender, EventArgs e)
        {
            registrarProdutocs registrarProduto = new registrarProdutocs();
            registrarProduto.Show();
            this.Hide();
            Estoque estoque = new Estoque();    
        }

        private void btn_Vendas_Estoque_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();   
            this.Hide();
            vendas.Show();
        }

        private void btn_Compras_Estoque_Click(object sender, EventArgs e)
        {
            Compras compra = new Compras();   
            this.Hide();    
            compra.Show();  
        }

        private async void btn_Relatorio_Estoque_Click(object sender, EventArgs e)
        {
            string connectionString = @"server=localhost;user=root;password='09072006';database=EmpresaCosmeticos";
            var dadosAcesso = new RelatorioFinanceiroDadoscs(connectionString);

            try
            {
                
                var dadosRelatorioDetalhado = await dadosAcesso.ObterDadosRelatorioDetalhadoAsync();

               
                string caminhoArquivoDetalhado = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RelatorioDetalhado.pdf");
                var geradorPDF = new GeradorRelatorioPDF();

             
                await geradorPDF.GerarPDFAsync(caminhoArquivoDetalhado, dadosRelatorioDetalhado);

                MessageBox.Show($"Relatório detalhado gerado com sucesso e salvo em: {caminhoArquivoDetalhado}", "Relatório Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao gerar o relatório: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
