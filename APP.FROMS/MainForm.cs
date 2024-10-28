using APP.FROMS.Dal;
using APP.FROMS.Metodos;
using Bunifu;
using Bunifu.Dataviz;
using Bunifu.Dataviz.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static Bunifu.Dataviz.WinForms.BunifuDatavizBasic;

namespace APP.FROMS.Telas
{
    public partial class MainForm : Form
    {
        private readonly Bunifu.Dataviz.WinForms.BunifuDataViz bunifuDatavizAdvanced1; // Ajuste o tipo para corresponder ao tipo correto

        public MainForm()
        {
            InitializeComponent();
            bunifuDatavizAdvanced1 = new Bunifu.Dataviz.WinForms.BunifuDataViz(); // Inicialize corretamente
        }

        private void Painel_Estoque_ControlAdded(object sender, ControlEventArgs e)
        {
            // Seu código aqui...
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            this.Hide();
            Estoque estoque = new Estoque();
            estoque.Show();
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
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

        private void btn_Relatorio_Click(object sender, EventArgs e)
        {
            this.Show();
            Relatorio relatorio = new Relatorio();
            relatorio.Show();
        }

        private void bunifuDatavizBasic1_Load(object sender, EventArgs e)
        {
            // Seu código aqui...
        }

        private void bunifuDatavizAdvanced1_Load(object sender, EventArgs e)
        {
            ConfigurarGrafico();
        }

        private void ConfigurarGrafico()
        {
            var relatorioFinanceiro = new RelatorioFinanceiro(new Conexao());
            var dadosRelatorio = relatorioFinanceiro.ObterRelatorioFinanceiroAgregado();

            var canvas = new Bunifu.Dataviz.WinForms.Canvas();
            var financialReportDataPoint = new Bunifu.Dataviz.WinForms.DataPoint(FetchBunifuLineChartType());

            foreach (var item in dadosRelatorio)
            {
                financialReportDataPoint.addLabely(item.Mes.ToString(), item.TotalVendas.ToString());
            }

            canvas.addData(financialReportDataPoint);

            if (bunifuDatavizAdvanced1 != null)
            {
                bunifuDatavizAdvanced1.Render(canvas);
            }
            else
            {
                MessageBox.Show("O controle bunifuDatavizAdvanced1 não foi inicializado corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static Bunifu.Dataviz.WinForms.BunifuDataViz._type FetchBunifuLineChartType()
        {
            return Bunifu.Dataviz.WinForms.BunifuDataViz._type.Bunifu_line; // Ajuste para acessar corretamente a enumeração
        }
    }
}
