using APP.FROMS.Class;
using APP.FROMS.Metodos;
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
    public partial class RemoçãodeProduto : Form
    {
        public RemoçãodeProduto()
        {
            InitializeComponent();
        }

        private void lbl_RemoveProd_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_RemoveProd_Click(object sender, EventArgs e)
        {
            RemoveProd  removeProd = new RemoveProd();
            removeProd.Estoque(int.Parse(txtbox_RemoveProd.Text));
           
            this.Hide();
            Estoque estoque = new Estoque();
            estoque.Show();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.Hide();    
        }
    }
}
