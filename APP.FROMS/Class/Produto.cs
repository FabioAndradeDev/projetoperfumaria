using DevExpress.XtraEditors.Filtering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.FROMS.Class
{
    internal class Produto
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string Categoria { get; set; }



        public Produto(int idProduto, string nome, string descricao, decimal preco, int qntdEstoque, string categoria)
        {
            ProdutoID = idProduto;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            QuantidadeEstoque = qntdEstoque;
            Categoria = categoria;
        }
    }
}

