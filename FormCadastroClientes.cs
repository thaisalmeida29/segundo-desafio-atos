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
    public partial class FormCadastroClientes : Form
    {
        public FormCadastroClientes()
        {
            InitializeComponent();
        }

        private void textBoxTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastroClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_VendaDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.db_VendaDataSet.cliente);

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente
            {
                Cpf = textBoxCpf.Text,
                Email = textBoxEmail.Text,
                Estado = tbEstado.Text,
                Nome = textBoxNome.Text,
                Telefone = textBoxTelefone.Text
            };
            bool ok =  c.gravarPessoa();
            if (ok)
            {
                MessageBox.Show("Ok");
                this.clienteTableAdapter.Fill(this.db_VendaDataSet.cliente);

            }
            else
            {
                MessageBox.Show("Nao Ok");
            }
        }

        private void dgCadastroClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
