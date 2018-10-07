namespace WindowsFormsApp5
{
    partial class InsercaoProduto
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.BtnDadosFornecedor = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxFornecedor = new System.Windows.Forms.ComboBox();
            this.tFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duckDuckDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duck_DuckDataSet1 = new WindowsFormsApp5.Duck_DuckDataSet1();
            this.DtmFabricacao = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DtmValidade = new System.Windows.Forms.DateTimePicker();
            this.t_FornecedorTableAdapter = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.t_FornecedorTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtQuantidadeFinal = new System.Windows.Forms.TextBox();
            this.NudQuantidadeAdd = new System.Windows.Forms.NumericUpDown();
            this.NudQuandidadeEstoque = new System.Windows.Forms.NumericUpDown();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duckDuckDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duck_DuckDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantidadeAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuandidadeEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 322);
            this.panel2.TabIndex = 1026;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(749, 38);
            this.panel4.TabIndex = 1020;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(210, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 25);
            this.label5.TabIndex = 1001;
            this.label5.Text = "Tela de Inserção - Produtos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(744, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 322);
            this.panel1.TabIndex = 1033;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 355);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 5);
            this.panel3.TabIndex = 1034;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.Location = new System.Drawing.Point(572, 291);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(150, 31);
            this.BtnCancelar.TabIndex = 1039;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnInserir
            // 
            this.BtnInserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BtnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInserir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInserir.ForeColor = System.Drawing.Color.Transparent;
            this.BtnInserir.Location = new System.Drawing.Point(391, 291);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(143, 31);
            this.BtnInserir.TabIndex = 1038;
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.UseVisualStyleBackColor = false;
            this.BtnInserir.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDadosFornecedor
            // 
            this.BtnDadosFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDadosFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BtnDadosFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDadosFornecedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDadosFornecedor.ForeColor = System.Drawing.Color.Transparent;
            this.BtnDadosFornecedor.Location = new System.Drawing.Point(391, 138);
            this.BtnDadosFornecedor.Name = "BtnDadosFornecedor";
            this.BtnDadosFornecedor.Size = new System.Drawing.Size(31, 25);
            this.BtnDadosFornecedor.TabIndex = 1040;
            this.BtnDadosFornecedor.Text = "...";
            this.BtnDadosFornecedor.UseVisualStyleBackColor = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.Location = new System.Drawing.Point(572, 64);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(143, 31);
            this.BtnBuscar.TabIndex = 1041;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(29, 72);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(496, 20);
            this.TxtCodigo.TabIndex = 1042;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 1043;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 1045;
            this.label2.Text = "Nome";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(29, 144);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(134, 20);
            this.TxtNome.TabIndex = 1044;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 1047;
            this.label3.Text = "Quantidade em Estoque";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(213, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 1049;
            this.label4.Text = "Fornecedor";
            // 
            // CbxFornecedor
            // 
            this.CbxFornecedor.DataSource = this.tFornecedorBindingSource;
            this.CbxFornecedor.DisplayMember = "nome";
            this.CbxFornecedor.FormattingEnabled = true;
            this.CbxFornecedor.Location = new System.Drawing.Point(217, 143);
            this.CbxFornecedor.Name = "CbxFornecedor";
            this.CbxFornecedor.Size = new System.Drawing.Size(134, 21);
            this.CbxFornecedor.TabIndex = 1050;
            this.CbxFornecedor.ValueMember = "codigo";
            // 
            // tFornecedorBindingSource
            // 
            this.tFornecedorBindingSource.DataMember = "t_Fornecedor";
            this.tFornecedorBindingSource.DataSource = this.duckDuckDataSet1BindingSource;
            // 
            // duckDuckDataSet1BindingSource
            // 
            this.duckDuckDataSet1BindingSource.DataSource = this.duck_DuckDataSet1;
            this.duckDuckDataSet1BindingSource.Position = 0;
            // 
            // duck_DuckDataSet1
            // 
            this.duck_DuckDataSet1.DataSetName = "Duck_DuckDataSet1";
            this.duck_DuckDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DtmFabricacao
            // 
            this.DtmFabricacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtmFabricacao.Location = new System.Drawing.Point(29, 302);
            this.DtmFabricacao.Name = "DtmFabricacao";
            this.DtmFabricacao.Size = new System.Drawing.Size(134, 20);
            this.DtmFabricacao.TabIndex = 1051;
            this.DtmFabricacao.Value = new System.DateTime(2018, 10, 4, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 21);
            this.label6.TabIndex = 1052;
            this.label6.Text = "Data de Fabricação";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(213, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 21);
            this.label7.TabIndex = 1054;
            this.label7.Text = "Data de Validade";
            // 
            // DtmValidade
            // 
            this.DtmValidade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtmValidade.Location = new System.Drawing.Point(217, 302);
            this.DtmValidade.Name = "DtmValidade";
            this.DtmValidade.Size = new System.Drawing.Size(134, 20);
            this.DtmValidade.TabIndex = 1053;
            this.DtmValidade.Value = new System.DateTime(2018, 10, 4, 0, 0, 0, 0);
            // 
            // t_FornecedorTableAdapter
            // 
            this.t_FornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(213, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 21);
            this.label8.TabIndex = 1056;
            this.label8.Text = "Quantidade";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(387, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 1058;
            this.label9.Text = "Quantidade Final";
            // 
            // TxtQuantidadeFinal
            // 
            this.TxtQuantidadeFinal.Enabled = false;
            this.TxtQuantidadeFinal.Location = new System.Drawing.Point(391, 224);
            this.TxtQuantidadeFinal.Name = "TxtQuantidadeFinal";
            this.TxtQuantidadeFinal.Size = new System.Drawing.Size(143, 20);
            this.TxtQuantidadeFinal.TabIndex = 1057;
            // 
            // NudQuantidadeAdd
            // 
            this.NudQuantidadeAdd.Location = new System.Drawing.Point(217, 224);
            this.NudQuantidadeAdd.Name = "NudQuantidadeAdd";
            this.NudQuantidadeAdd.Size = new System.Drawing.Size(134, 20);
            this.NudQuantidadeAdd.TabIndex = 1062;
            this.NudQuantidadeAdd.ValueChanged += new System.EventHandler(this.NudQuantidadeAdd_ValueChanged_1);
            // 
            // NudQuandidadeEstoque
            // 
            this.NudQuandidadeEstoque.Enabled = false;
            this.NudQuandidadeEstoque.Location = new System.Drawing.Point(29, 225);
            this.NudQuandidadeEstoque.Name = "NudQuandidadeEstoque";
            this.NudQuandidadeEstoque.Size = new System.Drawing.Size(134, 20);
            this.NudQuandidadeEstoque.TabIndex = 1063;
            this.NudQuandidadeEstoque.ValueChanged += new System.EventHandler(this.NudQuandidadeEstoque_ValueChanged);
            // 
            // InsercaoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(749, 360);
            this.Controls.Add(this.NudQuandidadeEstoque);
            this.Controls.Add(this.NudQuantidadeAdd);
            this.Controls.Add(this.BtnInserir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtQuantidadeFinal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DtmValidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DtmFabricacao);
            this.Controls.Add(this.CbxFornecedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnDadosFornecedor);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsercaoProduto";
            this.Text = "InserçãoProduto";
            this.Load += new System.EventHandler(this.InsercaoProduto_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duckDuckDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duck_DuckDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantidadeAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuandidadeEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button BtnDadosFornecedor;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxFornecedor;
        private System.Windows.Forms.DateTimePicker DtmFabricacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtmValidade;
        private System.Windows.Forms.BindingSource duckDuckDataSet1BindingSource;
        private Duck_DuckDataSet1 duck_DuckDataSet1;
        private System.Windows.Forms.BindingSource tFornecedorBindingSource;
        private Duck_DuckDataSet1TableAdapters.t_FornecedorTableAdapter t_FornecedorTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtQuantidadeFinal;
        private System.Windows.Forms.NumericUpDown NudQuantidadeAdd;
        private System.Windows.Forms.NumericUpDown NudQuandidadeEstoque;
    }
}