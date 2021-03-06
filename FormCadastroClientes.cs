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
            // TODO: esta linha de código carrega dados na tabela 'db_VendaDataSet11.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter6.Fill(this.db_VendaDataSet11.cliente);
       




        }
        /// <summary>
        /// click do botao para cadastrar os clientes no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente
            {
                Email = textBoxEmail.Text,
                Estado = tbEstado.Text,
                Nome = textBoxNome.Text,
                Telefone = textBoxTelefone.Text,
                Cpf = textBoxCpf.Text
            };
            if (String.IsNullOrEmpty(textBoxNome.Text))
            {
                MessageBox.Show("Preenchimento obrigatorio");
            }
            else
            {
                bool ok = c.gravarPessoa();
                if (ok) // testa se conseguiu gravar um cliente
                {
                    MessageBox.Show("Cliente cadastrado com sucesso");
                   
                    this.clienteTableAdapter6.Fill(this.db_VendaDataSet11.cliente);
                    textBoxCpf.Clear();
                    textBoxNome.Clear();
                    tbEstado.Clear();
                    textBoxTelefone.Clear();
                    textBoxEmail.Clear();
                }
                else
                {
                    MessageBox.Show("Cliente não cadastrado");
                }
            }
        }




        private void dgCadastroClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter6.Fill(this.db_VendaDataSet11.cliente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
