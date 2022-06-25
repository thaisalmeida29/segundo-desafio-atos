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
    public partial class FormVendas : Form
    {
        private Venda _venda = new Venda();

        public FormVendas()
        {
            InitializeComponent();
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_VendaDataSet4.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.db_VendaDataSet4.produto);
            // TODO: esta linha de código carrega dados na tabela 'db_VendaDataSet3.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.db_VendaDataSet3.cliente);
            // TODO: esta linha de código carrega dados na tabela 'db_VendaDataSet2.venda'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaTableAdapter.Fill(this.db_VendaDataSet2.venda);
            listBoxVendas.Items.Add("Nome do Produto - Quantidade - Valor total");

        }

        private void btCadastrarVendas_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(comboBoxCliente.SelectedValue);
            string nomeCliente = comboBoxCliente.GetItemText(comboBoxCliente.SelectedItem);
            int idProduto = Convert.ToInt32(comboBoxProduto.SelectedValue);
            string nomeProduto = comboBoxProduto.GetItemText(comboBoxProduto.SelectedItem);
            int quantidade = Convert.ToInt32(textBoxQuantidade.Text);
            DataRowView oDataRowView = comboBoxProduto.SelectedItem as DataRowView;
            decimal precoProduto = (decimal)(oDataRowView.Row["preco"]);
            _venda.IdCliente = idCliente;
            _venda.NomeCliente = nomeCliente;
            var itemVenda = new ItemVenda
            {
                IdProduto = idProduto,
                NomeProduto = nomeProduto,
                Quantidade = quantidade,
                PrecoTotal = precoProduto * quantidade
            };
            _venda.ItemVendas.Add(itemVenda);
            listBoxVendas.Items.Add($"{itemVenda.NomeProduto} - {itemVenda.Quantidade} - R$ {itemVenda.PrecoTotal}");
            textBoxValorVenda.Text = $"R$ {_venda.ValorTotalVenda}";
            MessageBox.Show("Item adicionado a venda");
        }

        private void buttonEfetuarVenda_Click(object sender, EventArgs e)
        {
            if(_venda.ItemVendas.Count == 0)
            {
                MessageBox.Show("Voce precisa adicionar pelo um produto");
                return;
            }
            bool sucesso = _venda.gravarVenda();
            if(sucesso)
            {
                MessageBox.Show("Venda efetuada com sucesso");
                this.RefreshForm();
            }
            else
            {
                MessageBox.Show("Ocorreu algum problema na efetuação da venda");
            }
        }

        public void RefreshForm()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            // TODO: esta linha de código carrega dados na tabela 'db_VendaDataSet4.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.db_VendaDataSet4.produto);
            // TODO: esta linha de código carrega dados na tabela 'db_VendaDataSet3.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.db_VendaDataSet3.cliente);
            // TODO: esta linha de código carrega dados na tabela 'db_VendaDataSet2.venda'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaTableAdapter.Fill(this.db_VendaDataSet2.venda);
            listBoxVendas.Items.Add("Nome do Produto - Quantidade - Valor total");
        }
    }
}
