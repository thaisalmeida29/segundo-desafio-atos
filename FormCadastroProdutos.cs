using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_vendas
{
    public partial class FormCadastroProdutos : Form
    {
        public FormCadastroProdutos()
        {
            InitializeComponent();
        }

        private void FormCadastroProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_VendaDataSet1.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.db_VendaDataSet1.produto);

        }
        /// <summary>
        /// click do botao para cadastrar os produtos no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCadastrarProdutos_Click(object sender, EventArgs e)
        {
            Produto c = new Produto
            {
                CodEAN = tbCodEan.Text,
                Nome = tbNomeProduto.Text,
                Preco = tbPreco.Text,
                Estoque = tbEstoque.Text,
                Marca = tbMarca.Text
            };
            if (String.IsNullOrEmpty(tbNomeProduto.Text))
            {
                MessageBox.Show("Preenchimento obrigatorio");
            }
            else
            {
                bool ok = c.gravarProduto();
                if (ok) // testa se conseguiu gravar o produto
                {
                    MessageBox.Show("Produto cadastrado com sucesso");

                    this.produtoTableAdapter.Fill(this.db_VendaDataSet1.produto);
                    tbCodEan.Clear();
                    tbNomeProduto.Clear();
                    tbPreco.Clear();
                    tbEstoque.Clear();
                    tbMarca.Clear();

                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
