using System;
using APP.FROMS.Metodos;
using APP.FROMS.Class;
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
    public partial class registrarProdutocs : Form
    {


        /*
         (int idProduto, string nome, string descricao, decimal preco, int qntdEstoque, string categoria)
         */

        public registrarProdutocs()
        {
            InitializeComponent();
        }


            private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void bunifuLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnPreco_RegistroProd_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_registroProd_Click(object sender, EventArgs e)
        {
            Produto novoProduto = new Produto(
             int.Parse(txtboxID_RegistrarProd.Text),
             txtboxNome_RegistroProd.Text,
             txtboxDescricao_RegistroProd.Text,
             decimal.Parse(txtboxPreco_RegistroProd.Text),
             int.Parse(txtboxQntd_RegistroProd.Text),
             txtboxCategoria_registroProd.Text);

            AddProduto addProduto = new AddProduto();

            addProduto.Estoque(
                novoProduto.ProdutoID,
                novoProduto.Nome,
                novoProduto.Descricao,
                novoProduto.Preco,
                novoProduto.QuantidadeEstoque,
                novoProduto.Categoria
            );
            this.Hide();
            Estoque estoque = new Estoque();
            estoque.Show();
        }

        private void txtboxNome_RegistroProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxID_RegistrarProd_TextChanged(object sender, EventArgs e)
        {

          
        }

        private void txtbox_RegistroProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxPreco_RegistroProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCarcelar_Registroprod_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            this.Hide();
            estoque.Show();
        }

        private void registrarProdutocs_Load(object sender, EventArgs e)
        {

        }

        private void lblID_RegistrarProd_Click(object sender, EventArgs e)
        {

        }

        private void lblCategoria_Registroprod_Click(object sender, EventArgs e)
        {

        }

        private void lblQntd_RegistroProd_Click(object sender, EventArgs e)
        {

        }

        private void txtboxCategoria_registroProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxQntd_RegistroProd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
