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
            this.produtoTableAdapter.Fill(this.db_VendaDataSet4.produto);
            this.clienteTableAdapter.Fill(this.db_VendaDataSet3.cliente);
            this.vendaTableAdapter.Fill(this.db_VendaDataSet2.venda);
            textBoxQuantidade.Text = "1";
            comboBoxProduto.SelectedItem = null;
            comboBoxProduto.Text = "Selecione";
            comboBoxCliente.SelectedItem = null;
            comboBoxCliente.Text = "Selecione";
            
        }

        private void btCadastrarVendas_Click(object sender, EventArgs e)
        {
           if(comboBoxProduto.SelectedValue == null)
           {
                MessageBox.Show("Selecione um produto");
                return;
            }

            if (comboBoxCliente.SelectedValue == null)
            {
                MessageBox.Show("Selecione um cliente");
                return;
            }
            int idProduto = Convert.ToInt32(comboBoxProduto.SelectedValue);
            string nomeProduto = comboBoxProduto.GetItemText(comboBoxProduto.SelectedItem);
            int quantidade = Convert.ToInt32(textBoxQuantidade.Text);
            DataRowView oDataRowView = comboBoxProduto.SelectedItem as DataRowView;
            decimal precoProduto = (decimal)(oDataRowView.Row["preco"]);
            int estoque = (int)(oDataRowView.Row["estoque"]);

            if(quantidade == 0)
            {
                MessageBox.Show("Quantidade de produtos inválida");
                return;
            }

            if(quantidade > estoque)
            {
                MessageBox.Show("Quantidade de items acima do estoque!");
                return;
            }
            var itemExistente = _venda.ItemVendas.FirstOrDefault(i => i.IdProduto == idProduto);
            if (itemExistente != null)
            {
                int index = _venda.ItemVendas.IndexOf(itemExistente);
                itemExistente.Quantidade = quantidade;
                itemExistente.PrecoTotal = precoProduto * quantidade;
                _venda.ItemVendas[index] = itemExistente;
                RefreshListBox();
            }
            else
            {
                var itemVenda = new ItemVenda
                {
                    IdProduto = idProduto,
                    NomeProduto = nomeProduto,
                    Quantidade = quantidade,
                    PrecoTotal = precoProduto * quantidade,
                    PrecoUnitario = precoProduto
                };
                _venda.ItemVendas.Add(itemVenda);
                RefreshListBox();
            }
            textBoxValorVenda.Text = $"R$ {_venda.ValorTotalVenda}";
            MessageBox.Show("Item adicionado a venda");
            comboBoxCliente.Enabled = false;
        }

        private void RefreshListBox()
        {
            listBoxVendas.Items.Clear();
            foreach(var itemVenda in _venda.ItemVendas)
            {
                listBoxVendas.Items.Add($" Nome do Produto: {itemVenda.NomeProduto} - Quantidade: {itemVenda.Quantidade} - Preço Unitário: R$ {itemVenda.PrecoUnitario} - Valor Total:  R$ {itemVenda.PrecoTotal}");
            }
        }

        private void buttonEfetuarVenda_Click(object sender, EventArgs e)
        {
            if(_venda.ItemVendas.Count == 0)
            {
                MessageBox.Show("Voce precisa adicionar pelo um produto");
                return;
            }
            int idCliente = Convert.ToInt32(comboBoxCliente.SelectedValue);
            string nomeCliente = comboBoxCliente.GetItemText(comboBoxCliente.SelectedItem);
            _venda.IdCliente = idCliente;
            _venda.NomeCliente = nomeCliente;
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
            this.produtoTableAdapter.Fill(this.db_VendaDataSet4.produto);
            this.clienteTableAdapter.Fill(this.db_VendaDataSet3.cliente);
            this.vendaTableAdapter.Fill(this.db_VendaDataSet2.venda);
            textBoxQuantidade.Text = "1";
            comboBoxProduto.SelectedItem = null;
            comboBoxProduto.Text = "Selecione";
            comboBoxCliente.Text = "Selecione";
            comboBoxCliente.SelectedItem = null;
        }
    }
}
