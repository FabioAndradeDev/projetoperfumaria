using APP.FROMS.Class;
using APP.FROMS.Metodos;
using Bunifu.Dataviz.WinForms;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP.FROMS.Telas
{
    public partial class Vendas : Form
    {
       
        Metodos.SetVendad set = new Metodos.SetVendad();
        DataTable vendas;
        public Vendas()
        {
            InitializeComponent();
         
        }



        private void dashboardViewer1_Load(object sender, EventArgs e)
        {

        }

        private void dashboardDesigner1_Load(object sender, EventArgs e)
        {

        }

        private void dashboardDesigner1_Load_1(object sender, EventArgs e)
        {

        }

        private void bunifuDatavizBasic1_Load(object sender, EventArgs e)
        {
        
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
        
           
            vendas = set.Vendas();
            dtGrrid_Vendas.DataSource = vendas;


        }

        private void btn_Vendas_Click(object sender, EventArgs e)
        {
            this.Hide();        
            Main main = new Main();
            main.Show();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btn_Relatorio_Click(object sender, EventArgs e)
        {
            string connectionString = @"server=localhost;user=root;password='09072006';database=EmpresaCosmeticos";
            var dadosAcesso = new RelatorioFinanceiroDadoscs(connectionString);

            try
            {
                
                var dadosRelatorioDetalhado = await dadosAcesso.ObterDadosRelatorioDetalhadoAsync();

            
                string caminhoArquivoDetalhado = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RelatorioDetalhado_Vendas.pdf");
                var geradorPDF = new GeradorRelatorioPDF();

                
                await geradorPDF.GerarPDFAsync(caminhoArquivoDetalhado, dadosRelatorioDetalhado);

                MessageBox.Show($"Relatório detalhado gerado com sucesso e salvo em: {caminhoArquivoDetalhado}", "Relatório Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao gerar o relatório: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Compras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compras compras = new Compras();    
            compras.Show();
        }

        private void btn_Estoque_Click(object sender, EventArgs e)
        {
            this.Hide();
            Estoque estoque = new Estoque();    
            estoque.Show();
        }

        private void btnAdd_Estoque_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddVenda addVenda = new AddVenda();
            addVenda.Show();
        }
    }
}
