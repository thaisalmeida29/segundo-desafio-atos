namespace Desafio_vendas
{
    partial class FormCadastroClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_VendaDataSet = new Desafio_vendas.db_VendaDataSet();
            this.clienteTableAdapter = new Desafio_vendas.db_VendaDataSetTableAdapters.clienteTableAdapter();
            this.db_VendaDataSet5 = new Desafio_vendas.db_VendaDataSet5();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter1 = new Desafio_vendas.db_VendaDataSet5TableAdapters.clienteTableAdapter();
            this.db_VendaDataSet6 = new Desafio_vendas.db_VendaDataSet6();
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter2 = new Desafio_vendas.db_VendaDataSet6TableAdapters.clienteTableAdapter();
            this.db_VendaDataSet7 = new Desafio_vendas.db_VendaDataSet7();
            this.clienteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter3 = new Desafio_vendas.db_VendaDataSet7TableAdapters.clienteTableAdapter();
            this.clienteBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.db_VendaDataSet8 = new Desafio_vendas.db_VendaDataSet8();
            this.clienteTableAdapter4 = new Desafio_vendas.db_VendaDataSet8TableAdapters.clienteTableAdapter();
            this.db_VendaDataSet10 = new Desafio_vendas.db_VendaDataSet10();
            this.clienteBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter5 = new Desafio_vendas.db_VendaDataSet10TableAdapters.clienteTableAdapter();
            this.clienteBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.db_VendaDataSet9 = new Desafio_vendas.db_VendaDataSet9();
            this.db_VendaDataSet21 = new Desafio_vendas.db_VendaDataSet2();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.db_VendaDataSet11 = new Desafio_vendas.db_VendaDataSet11();
            this.clienteBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter6 = new Desafio_vendas.db_VendaDataSet11TableAdapters.clienteTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(82, 75);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(195, 27);
            this.textBoxNome.TabIndex = 2;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(431, 200);
            this.textBoxTelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(206, 27);
            this.textBoxTelefone.TabIndex = 3;
            this.textBoxTelefone.TextChanged += new System.EventHandler(this.textBoxTelefone_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(431, 74);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(206, 27);
            this.textBoxEmail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, -1);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cadastro de clientes";
            // 
            // btCadastrar
            // 
            this.btCadastrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btCadastrar.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(45, 226);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(136, 37);
            this.btCadastrar.TabIndex = 11;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(349, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Estado:";
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(431, 134);
            this.tbEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(206, 27);
            this.tbEstado.TabIndex = 16;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.db_VendaDataSet;
            // 
            // db_VendaDataSet
            // 
            this.db_VendaDataSet.DataSetName = "db_VendaDataSet";
            this.db_VendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // db_VendaDataSet5
            // 
            this.db_VendaDataSet5.DataSetName = "db_VendaDataSet5";
            this.db_VendaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "cliente";
            this.clienteBindingSource1.DataSource = this.db_VendaDataSet5;
            // 
            // clienteTableAdapter1
            // 
            this.clienteTableAdapter1.ClearBeforeFill = true;
            // 
            // db_VendaDataSet6
            // 
            this.db_VendaDataSet6.DataSetName = "db_VendaDataSet6";
            this.db_VendaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource2
            // 
            this.clienteBindingSource2.DataMember = "cliente";
            this.clienteBindingSource2.DataSource = this.db_VendaDataSet6;
            // 
            // clienteTableAdapter2
            // 
            this.clienteTableAdapter2.ClearBeforeFill = true;
            // 
            // db_VendaDataSet7
            // 
            this.db_VendaDataSet7.DataSetName = "db_VendaDataSet7";
            this.db_VendaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource3
            // 
            this.clienteBindingSource3.DataMember = "cliente";
            this.clienteBindingSource3.DataSource = this.db_VendaDataSet7;
            // 
            // clienteTableAdapter3
            // 
            this.clienteTableAdapter3.ClearBeforeFill = true;
            // 
            // clienteBindingSource4
            // 
            this.clienteBindingSource4.DataMember = "cliente";
            this.clienteBindingSource4.DataSource = this.db_VendaDataSet8;
            // 
            // db_VendaDataSet8
            // 
            this.db_VendaDataSet8.DataSetName = "db_VendaDataSet8";
            this.db_VendaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter4
            // 
            this.clienteTableAdapter4.ClearBeforeFill = true;
            // 
            // db_VendaDataSet10
            // 
            this.db_VendaDataSet10.DataSetName = "db_VendaDataSet10";
            this.db_VendaDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource6
            // 
            this.clienteBindingSource6.DataMember = "cliente";
            this.clienteBindingSource6.DataSource = this.db_VendaDataSet10;
            // 
            // clienteTableAdapter5
            // 
            this.clienteTableAdapter5.ClearBeforeFill = true;
            // 
            // clienteBindingSource5
            // 
            this.clienteBindingSource5.DataMember = "cliente";
            this.clienteBindingSource5.DataSource = this.db_VendaDataSet9;
            // 
            // db_VendaDataSet9
            // 
            this.db_VendaDataSet9.DataSetName = "db_VendaDataSet9";
            this.db_VendaDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_VendaDataSet21
            // 
            this.db_VendaDataSet21.DataSetName = "db_VendaDataSet2";
            this.db_VendaDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Location = new System.Drawing.Point(84, 135);
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(192, 27);
            this.textBoxCpf.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "CPF:";
            // 
            // db_VendaDataSet11
            // 
            this.db_VendaDataSet11.DataSetName = "db_VendaDataSet11";
            this.db_VendaDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource7
            // 
            this.clienteBindingSource7.DataMember = "cliente";
            this.clienteBindingSource7.DataSource = this.db_VendaDataSet11;
            // 
            // clienteTableAdapter6
            // 
            this.clienteTableAdapter6.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.cpf});
            this.dataGridView1.DataSource = this.clienteBindingSource7;
            this.dataGridView1.Location = new System.Drawing.Point(12, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 172);
            this.dataGridView1.TabIndex = 17;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Width = 80;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.Width = 60;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf";
            this.cpf.HeaderText = "cpf";
            this.cpf.Name = "cpf";
            this.cpf.Width = 110;
            // 
            // FormCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(717, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCpf);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBoxNome);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCadastroClientes";
            this.Text = "FormCadastroClientes";
            this.Load += new System.EventHandler(this.FormCadastroClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_VendaDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEstado;
        private db_VendaDataSet db_VendaDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private db_VendaDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private db_VendaDataSet5 db_VendaDataSet5;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private db_VendaDataSet5TableAdapters.clienteTableAdapter clienteTableAdapter1;
        private db_VendaDataSet6 db_VendaDataSet6;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private db_VendaDataSet6TableAdapters.clienteTableAdapter clienteTableAdapter2;
        private db_VendaDataSet7 db_VendaDataSet7;
        private System.Windows.Forms.BindingSource clienteBindingSource3;
        private db_VendaDataSet7TableAdapters.clienteTableAdapter clienteTableAdapter3;
        private db_VendaDataSet8 db_VendaDataSet8;
        private System.Windows.Forms.BindingSource clienteBindingSource4;
        private db_VendaDataSet8TableAdapters.clienteTableAdapter clienteTableAdapter4;
        private System.Windows.Forms.BindingSource clienteBindingSource5;
        private db_VendaDataSet9 db_VendaDataSet9;
        private db_VendaDataSet10 db_VendaDataSet10;
        private System.Windows.Forms.BindingSource clienteBindingSource6;
        private db_VendaDataSet10TableAdapters.clienteTableAdapter clienteTableAdapter5;
        private db_VendaDataSet2 db_VendaDataSet21;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.Label label1;
        private db_VendaDataSet11 db_VendaDataSet11;
        private System.Windows.Forms.BindingSource clienteBindingSource7;
        private db_VendaDataSet11TableAdapters.clienteTableAdapter clienteTableAdapter6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
    }
}