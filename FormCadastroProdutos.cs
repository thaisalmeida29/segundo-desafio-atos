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

        private void btCadastrarProdutos_Click(object sender, EventArgs e)
        {

        }
    }
}
