using APP.FROMS.Class;
using APP.FROMS.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP.FROMS.Telas
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_Estoque_Click(object sender, EventArgs e)
        {
            this.Hide();
            Estoque estoque = new Estoque();
            estoque.Show();
        }

        private void picBox_Main_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPerfil_home_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Vendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vendas vendas = new Vendas();
            vendas.Show();
        }

        private void btn_Compras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compras compras = new Compras();
            compras.Show();
        }

        private async void btn_Relatorio_Click(object sender, EventArgs e)
        {
            string connectionString = @"server=localhost;user=root;password='';database=EmpresaCosmeticos";
            var dadosAcesso = new RelatorioFinanceiroDadoscs(connectionString);

       
            var dadosRelatorioDetalhado = await dadosAcesso.ObterDadosRelatorioDetalhadoAsync();

            
            IEnumerable<RelatorioDetalhado> dadosRelatorio = dadosRelatorioDetalhado.Cast<RelatorioDetalhado>();

          
            string caminhoArquivoDetalhado = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RelatorioDetalhado.pdf");
            var geradorPDF = new GeradorRelatorioPDF();

          
            await geradorPDF.GerarPDFAsync(caminhoArquivoDetalhado, dadosRelatorio);

            MessageBox.Show($"Relatório detalhado gerado com sucesso e salvo em: {caminhoArquivoDetalhado}", "Relatório Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_RegistroFunc_Click(object sender, EventArgs e)
        {
            RegistrarFunc registrarFunc = new RegistrarFunc();  
            registrarFunc.Show();
        }
    }
}
