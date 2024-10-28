using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP.FROMS.Metodos;

namespace APP.FROMS.Telas
{
    public partial class RegistrarFunc : Form
    {
        private readonly AddFunc addFunc;

        public RegistrarFunc()
        {
            InitializeComponent();
            string connectionString = @"server=localhost;user=root;password='09072006';database=EmpresaCosmeticos";
            addFunc = new AddFunc(connectionString);
        }

        private void txtBox_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Perfil_TextChanged(object sender, EventArgs e)
        {

        }

        private void perfil_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttxtBox_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {

            string nome = txtBox_Nome.Text;
            string perfil = txtBox_Perfil.Text;
            string senha = txtBox_Senha.Text;
            string idString = txtBox_ID.Text;


            if (string.IsNullOrEmpty(idString))
            {
                MessageBox.Show("ID não pode estar em branco.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!int.TryParse(idString, out int id))
            {
                MessageBox.Show("ID deve ser um valor inteiro válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            bool cadastradoComSucesso = addFunc.CadastrarFuncionario(nome, perfil, senha, id);

            if (cadastradoComSucesso)
            {
                MessageBox.Show($"Funcionário cadastrado com sucesso!\nNome: {nome}\nPerfil: {perfil}\nID: {id}",
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
            txtBox_Nome.Text = "";
            txtBox_Perfil.Text = "";
            txtBox_Senha.Text = "";
            txtBox_ID.Text = "";
        }

        private void RegistrarFunc_Load(object sender, EventArgs e)
        {

        }
    }
}
