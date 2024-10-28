using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using APP.FROMS.Metodos;
using APP.FROMS;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP.FROMS.Dal;

namespace APP.FROMS.Telas
{
    public partial class AddVenda : Form
    {
        private readonly Metodos.SetVendad set = new Metodos.SetVendad();
        private DataTable vendas;
        private Conexao conexao;
        public AddVenda()
        {
            InitializeComponent();
            conexao = new Conexao();
        }

        private void AddVenda_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_venda_Click(object sender, EventArgs e)
        {
            string usuarioId = txtBox_ID.Text;
            DateTime dataVenda = DateTime.Parse(txtBox_DataVenda.Text);
            decimal totalVenda = decimal.Parse(txtBox_TotalVenda.Text);
            

            if (string.IsNullOrEmpty(usuarioId))
            {
                MessageBox.Show("ID não pode estar em branco.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!int.TryParse(usuarioId, out int id))
            {
                MessageBox.Show("ID deve ser um valor inteiro válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            VendaRepository vendaRepository = new VendaRepository(conexao);

            bool cadastradoComSucesso = vendaRepository.InserirVenda(id, dataVenda, totalVenda);

            if (cadastradoComSucesso)
            {
                MessageBox.Show($"Venda cadastrada com sucesso!\nID: {id}\nData: {dataVenda}\nTotal da venda: {totalVenda}",
                                "Cadastro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar funcionário. Verifique os dados e tente novamente.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimparCampos()
        {
            txtBox_ID.Text = "";
            txtBox_DataVenda.Text = "";
            txtBox_TotalVenda.Text = "";
           
        }

        private void txtBox_TotalVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_DataVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            this.Hide();
            vendas.Show();
        }
    }
}
