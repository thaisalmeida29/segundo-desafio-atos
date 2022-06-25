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
    public partial class FormPrincipal : Form
    {
        private Form frmAtivo;
        
        public FormPrincipal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// método que faz passar de um formulário para o outro
        /// </summary>
        /// <param name="frm"></param>
        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelHome.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        /// <summary>
        /// método para quando clicar em uma formulário fechar o outro
        /// </summary>
        private void ActiveFormClose()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }
        /// <summary>
        /// método para mudar de cor a parte do menu selecionada
        /// </summary>
        /// <param name="frmAtivo"></param>
        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in panelHome.Controls)
            {
                ctrl.ForeColor = Color.Black;
            }

        }

        private void btCadastrarClientes_Click(object sender, EventArgs e)
        {
            ActiveButton(btCadastrarClientes);
            FormShow(new FormCadastroClientes());
        }

        private void btCadastrarProdutos_Click(object sender, EventArgs e)
        {
            ActiveButton(btCadastrarProdutos);
            FormShow(new FormCadastroProdutos());
        }

        private void btVendas_Click(object sender, EventArgs e)
        {
            ActiveButton(btVendas);
            FormShow(new FormVendas());
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VENDUP AGRADECE SUA CONFIANÇA!! \n VOLTE SEMPRE!");
            Application.Exit();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
        }
    }
}
