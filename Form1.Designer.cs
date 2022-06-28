namespace Desafio_vendas
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btHome = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btVendas = new System.Windows.Forms.Button();
            this.btCadastrarProdutos = new System.Windows.Forms.Button();
            this.btCadastrarClientes = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelMenu.Controls.Add(this.btHome);
            this.panelMenu.Controls.Add(this.btSair);
            this.panelMenu.Controls.Add(this.btVendas);
            this.panelMenu.Controls.Add(this.btCadastrarProdutos);
            this.panelMenu.Controls.Add(this.btCadastrarClientes);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(245, 495);
            this.panelMenu.TabIndex = 0;
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btHome.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.Location = new System.Drawing.Point(5, 124);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(237, 48);
            this.btHome.TabIndex = 6;
            this.btHome.Text = "Home";
            this.btHome.UseVisualStyleBackColor = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btSair.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(5, 414);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(237, 53);
            this.btSair.TabIndex = 5;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btVendas
            // 
            this.btVendas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btVendas.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVendas.Location = new System.Drawing.Point(8, 332);
            this.btVendas.Name = "btVendas";
            this.btVendas.Size = new System.Drawing.Size(237, 50);
            this.btVendas.TabIndex = 4;
            this.btVendas.Text = "Vendas";
            this.btVendas.UseVisualStyleBackColor = false;
            this.btVendas.Click += new System.EventHandler(this.btVendas_Click);
            // 
            // btCadastrarProdutos
            // 
            this.btCadastrarProdutos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btCadastrarProdutos.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarProdutos.Location = new System.Drawing.Point(5, 267);
            this.btCadastrarProdutos.Name = "btCadastrarProdutos";
            this.btCadastrarProdutos.Size = new System.Drawing.Size(237, 49);
            this.btCadastrarProdutos.TabIndex = 2;
            this.btCadastrarProdutos.Text = "Cadastrar produtos";
            this.btCadastrarProdutos.UseVisualStyleBackColor = false;
            this.btCadastrarProdutos.Click += new System.EventHandler(this.btCadastrarProdutos_Click);
            // 
            // btCadastrarClientes
            // 
            this.btCadastrarClientes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btCadastrarClientes.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarClientes.Location = new System.Drawing.Point(5, 188);
            this.btCadastrarClientes.Name = "btCadastrarClientes";
            this.btCadastrarClientes.Size = new System.Drawing.Size(237, 49);
            this.btCadastrarClientes.TabIndex = 1;
            this.btCadastrarClientes.Text = "Cadastrar cliente";
            this.btCadastrarClientes.UseVisualStyleBackColor = false;
            this.btCadastrarClientes.Click += new System.EventHandler(this.btCadastrarClientes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLogo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(245, 118);
            this.panelLogo.TabIndex = 0;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHome.BackgroundImage")));
            this.panelHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHome.Location = new System.Drawing.Point(251, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(717, 495);
            this.panelHome.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(962, 495);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelMenu);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENDUP";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btVendas;
        private System.Windows.Forms.Button btCadastrarProdutos;
        private System.Windows.Forms.Button btCadastrarClientes;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button btHome;
    }
}

