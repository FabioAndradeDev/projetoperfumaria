using APP.FROMS.Dal;
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
using APP.FROMS.Dal;
using APP.FROMS.Class;
using System.Drawing.Text;
using APP.FROMS.Telas;
using APP.FROMS;

namespace APP.FROMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void bunifuCircleProgress1_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {

        }

        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            string id = txtBox_ID.Text;
            string senha = txtBox_Senha.Text;

            // Verifica se o ID é um número válido
            if (!int.TryParse(id, out int idNumero))
            {
                MessageBox.Show("ID de usuário deve ser um número válido.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Determina o namespace e o nome da classe baseado no último dígito do ID
            string namespaceFormulario;
            string nomeClasse;
            switch (id.Substring(id.Length - 3))
            {
                case "002":
                    namespaceFormulario = "APP.FROMS.Telas";
                    nomeClasse = "Main";
                    break;
                case "003":
                    namespaceFormulario = "APP.FROMS.Telas_Estoque";
                    nomeClasse = "Estoque_Estoquista";
                    break;
                case "004":
                    namespaceFormulario = "APP.FROMS.Telas_Vendedor";
                    nomeClasse = "Vendas_Vendedor";
                    break;
                default:
                    MessageBox.Show("ID não corresponde a um formulário válido.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            LoginForm loginForm = new LoginForm();

            // Verifica o login com o método VerificaLogin da classe LoginForm
            if (loginForm.VerificaLogin(id, senha))
            {
                this.Hide();

                // Monta o nome completo da classe com base no namespace determinado
                string nomeCompletoClasse = $"{namespaceFormulario}.{nomeClasse}";

                // Cria uma instância do formulário usando reflection
                Type formType = Type.GetType(nomeCompletoClasse);
                if (formType != null)
                {
                    Form form = (Form)Activator.CreateInstance(formType);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Formulário não encontrado.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ID de usuário ou senha incorretos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBox_Senha_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
