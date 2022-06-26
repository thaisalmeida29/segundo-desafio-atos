namespace Desafio_vendas
{
    partial class FormVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btCadastrarVendas = new System.Windows.Forms.Button();
            this.db_VendaDataSet2 = new Desafio_vendas.db_VendaDataSet2();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaTableAdapter = new Desafio_vendas.db_VendaDataSet2TableAdapters.vendaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_VendaDataSet3 = new Desafio_vendas.db_VendaDataSet3();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_VendaDataSet4 = new Desafio_vendas.db_VendaDataSet4();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEfetuarVenda = new System.Windows.Forms.Button();
            this.clienteTableAdapter = new Desafio_vendas.db_VendaDataSet3TableAdapters.clienteTableAdapter();
            this.produtoTableAdapter = new Desafio_vendas.db_VendaDataSet4TableAdapters.produtoTableAdapter();
            this.listBoxVendas = new System.Windows.Forms.ListBox();
            this.textBoxValorVenda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // btCadastrarVendas
            // 
            this.btCadastrarVendas.Location = new System.Drawing.Point(17, 219);
            this.btCadastrarVendas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCadastrarVendas.Name = "btCadastrarVendas";
            this.btCadastrarVendas.Size = new System.Drawing.Size(132, 32);
            this.btCadastrarVendas.TabIndex = 14;
            this.btCadastrarVendas.Text = "Cadastrar";
            this.btCadastrarVendas.UseVisualStyleBackColor = true;
            this.btCadastrarVendas.Click += new System.EventHandler(this.btCadastrarVendas_Click);
            // 
            // db_VendaDataSet2
            // 
            this.db_VendaDataSet2.DataSetName = "db_VendaDataSet2";
            this.db_VendaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "venda";
            this.vendaBindingSource.DataSource = this.db_VendaDataSet2;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Vendas";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.DataSource = this.clienteBindingSource;
            this.comboBoxCliente.DisplayMember = "nome";
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(128, 65);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(328, 28);
            this.comboBoxCliente.TabIndex = 16;
            this.comboBoxCliente.ValueMember = "idCliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.db_VendaDataSet3;
            // 
            // db_VendaDataSet3
            // 
            this.db_VendaDataSet3.DataSetName = "db_VendaDataSet3";
            this.db_VendaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.DataSource = this.produtoBindingSource;
            this.comboBoxProduto.DisplayMember = "nomeProduto";
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(128, 126);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(328, 28);
            this.comboBoxProduto.TabIndex = 17;
            this.comboBoxProduto.ValueMember = "idProduto";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.db_VendaDataSet4;
            // 
            // db_VendaDataSet4
            // 
            this.db_VendaDataSet4.DataSetName = "db_VendaDataSet4";
            this.db_VendaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Produto:";
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(128, 169);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(95, 27);
            this.textBoxQuantidade.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quantidade:";
            // 
            // buttonEfetuarVenda
            // 
            this.buttonEfetuarVenda.Location = new System.Drawing.Point(245, 219);
            this.buttonEfetuarVenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEfetuarVenda.Name = "buttonEfetuarVenda";
            this.buttonEfetuarVenda.Size = new System.Drawing.Size(132, 32);
            this.buttonEfetuarVenda.TabIndex = 22;
            this.buttonEfetuarVenda.Text = "Efetuar venda";
            this.buttonEfetuarVenda.UseVisualStyleBackColor = true;
            this.buttonEfetuarVenda.Click += new System.EventHandler(this.buttonEfetuarVenda_Click);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // listBoxVendas
            // 
            this.listBoxVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listBoxVendas.Enabled = false;
            this.listBoxVendas.FormattingEnabled = true;
            this.listBoxVendas.ItemHeight = 20;
            this.listBoxVendas.Location = new System.Drawing.Point(3, 293);
            this.listBoxVendas.Name = "listBoxVendas";
            this.listBoxVendas.Size = new System.Drawing.Size(710, 184);
            this.listBoxVendas.TabIndex = 23;
            // 
            // textBoxValorVenda
            // 
            this.textBoxValorVenda.Location = new System.Drawing.Point(564, 6);
            this.textBoxValorVenda.Name = "textBoxValorVenda";
            this.textBoxValorVenda.Size = new System.Drawing.Size(135, 27);
            this.textBoxValorVenda.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Valor Total:";
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(717, 495);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxValorVenda);
            this.Controls.Add(this.listBoxVendas);
            this.Controls.Add(this.buttonEfetuarVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxProduto);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCadastrarVendas);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btCadastrarVendas;
        private db_VendaDataSet2 db_VendaDataSet2;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private db_VendaDataSet2TableAdapters.vendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.ComboBox comboBoxProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEfetuarVenda;
        private db_VendaDataSet3 db_VendaDataSet3;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private db_VendaDataSet3TableAdapters.clienteTableAdapter clienteTableAdapter;
        private db_VendaDataSet4 db_VendaDataSet4;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private db_VendaDataSet4TableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.ListBox listBoxVendas;
        private System.Windows.Forms.TextBox textBoxValorVenda;
        private System.Windows.Forms.Label label5;
    }
}