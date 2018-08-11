namespace WindowsFormsApp5
{
    partial class CadastrarProduto
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDetalhes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.duck_DuckDataSet1 = new WindowsFormsApp5.Duck_DuckDataSet1();
            this.tloginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_loginTableAdapter = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.t_loginTableAdapter();
            this.tCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_CargoTableAdapter = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.t_CargoTableAdapter();
            this.fKtlogintCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCargoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tCargoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tCargoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fKtlogintCargoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPreco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPrecoFornecedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbxForncedor = new System.Windows.Forms.ComboBox();
            this.tFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duck_DuckDataSet11 = new WindowsFormsApp5.Duck_DuckDataSet1();
            this.t_FornecedorTableAdapter = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.t_FornecedorTableAdapter();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duck_DuckDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tloginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtlogintCargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCargoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCargoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCargoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtlogintCargoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duck_DuckDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 364);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 5);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(501, 38);
            this.panel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(86, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 25);
            this.label5.TabIndex = 1001;
            this.label5.Text = "Tela de Cadastro - Produtos";
            // 
            // TxtNome
            // 
            this.TxtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNome.Location = new System.Drawing.Point(31, 84);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(175, 20);
            this.TxtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 1004;
            this.label1.Text = "Nome";
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtQuantidade.Location = new System.Drawing.Point(259, 84);
            this.TxtQuantidade.MaxLength = 50;
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(175, 20);
            this.TxtQuantidade.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(255, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 1004;
            this.label2.Text = "Quantidade";
            // 
            // TxtDetalhes
            // 
            this.TxtDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDetalhes.Location = new System.Drawing.Point(31, 246);
            this.TxtDetalhes.MaxLength = 50;
            this.TxtDetalhes.Multiline = true;
            this.TxtDetalhes.Name = "TxtDetalhes";
            this.TxtDetalhes.Size = new System.Drawing.Size(175, 21);
            this.TxtDetalhes.TabIndex = 3;
            this.TxtDetalhes.Tag = "";
            this.TxtDetalhes.TextChanged += new System.EventHandler(this.TxtDescricao_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 1004;
            this.label4.Text = "Detalhes";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(259, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(31, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // duck_DuckDataSet1
            // 
            this.duck_DuckDataSet1.DataSetName = "Duck_DuckDataSet1";
            this.duck_DuckDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tloginBindingSource
            // 
            this.tloginBindingSource.DataMember = "t_login";
            this.tloginBindingSource.DataSource = this.duck_DuckDataSet1;
            // 
            // t_loginTableAdapter
            // 
            this.t_loginTableAdapter.ClearBeforeFill = true;
            // 
            // tCargoBindingSource
            // 
            this.tCargoBindingSource.DataMember = "t_Cargo";
            this.tCargoBindingSource.DataSource = this.duck_DuckDataSet1;
            // 
            // t_CargoTableAdapter
            // 
            this.t_CargoTableAdapter.ClearBeforeFill = true;
            // 
            // fKtlogintCargoBindingSource
            // 
            this.fKtlogintCargoBindingSource.DataMember = "FK_t_login_t_Cargo";
            this.fKtlogintCargoBindingSource.DataSource = this.tCargoBindingSource;
            // 
            // tCargoBindingSource1
            // 
            this.tCargoBindingSource1.DataMember = "t_Cargo";
            this.tCargoBindingSource1.DataSource = this.duck_DuckDataSet1;
            // 
            // tCargoBindingSource3
            // 
            this.tCargoBindingSource3.DataMember = "t_Cargo";
            this.tCargoBindingSource3.DataSource = this.duck_DuckDataSet1;
            // 
            // tCargoBindingSource2
            // 
            this.tCargoBindingSource2.DataMember = "t_Cargo";
            this.tCargoBindingSource2.DataSource = this.duck_DuckDataSet1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 326);
            this.panel2.TabIndex = 1007;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(496, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 326);
            this.panel1.TabIndex = 1008;
            // 
            // fKtlogintCargoBindingSource1
            // 
            this.fKtlogintCargoBindingSource1.DataMember = "FK_t_login_t_Cargo";
            this.fKtlogintCargoBindingSource1.DataSource = this.tCargoBindingSource3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 1010;
            this.label3.Text = "Preço";
            // 
            // TxtPreco
            // 
            this.TxtPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPreco.Location = new System.Drawing.Point(31, 163);
            this.TxtPreco.MaxLength = 50;
            this.TxtPreco.Name = "TxtPreco";
            this.TxtPreco.Size = new System.Drawing.Size(175, 20);
            this.TxtPreco.TabIndex = 1009;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(255, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 21);
            this.label6.TabIndex = 1012;
            this.label6.Text = "Preço do fornecedor";
            // 
            // TxtPrecoFornecedor
            // 
            this.TxtPrecoFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrecoFornecedor.Location = new System.Drawing.Point(259, 163);
            this.TxtPrecoFornecedor.MaxLength = 50;
            this.TxtPrecoFornecedor.Name = "TxtPrecoFornecedor";
            this.TxtPrecoFornecedor.Size = new System.Drawing.Size(175, 20);
            this.TxtPrecoFornecedor.TabIndex = 1011;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(258, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 1015;
            this.label7.Text = "Fornecedor";
            // 
            // CbxForncedor
            // 
            this.CbxForncedor.DataSource = this.tFornecedorBindingSource;
            this.CbxForncedor.DisplayMember = "nome";
            this.CbxForncedor.FormattingEnabled = true;
            this.CbxForncedor.Location = new System.Drawing.Point(259, 246);
            this.CbxForncedor.Name = "CbxForncedor";
            this.CbxForncedor.Size = new System.Drawing.Size(175, 21);
            this.CbxForncedor.TabIndex = 1016;
            this.CbxForncedor.ValueMember = "codigo";
            // 
            // tFornecedorBindingSource
            // 
            this.tFornecedorBindingSource.DataMember = "t_Fornecedor";
            this.tFornecedorBindingSource.DataSource = this.duck_DuckDataSet11;
            // 
            // duck_DuckDataSet11
            // 
            this.duck_DuckDataSet11.DataSetName = "Duck_DuckDataSet1";
            this.duck_DuckDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_FornecedorTableAdapter
            // 
            this.t_FornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // CadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(501, 369);
            this.Controls.Add(this.CbxForncedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtPrecoFornecedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPreco);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDetalhes);
            this.Controls.Add(this.TxtQuantidade);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "9";
            this.Load += new System.EventHandler(this.Cadastrar_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duck_DuckDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tloginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtlogintCargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCargoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCargoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCargoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtlogintCargoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duck_DuckDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtDetalhes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Duck_DuckDataSet1 duck_DuckDataSet1;
        private System.Windows.Forms.BindingSource tloginBindingSource;
        private Duck_DuckDataSet1TableAdapters.t_loginTableAdapter t_loginTableAdapter;
        private System.Windows.Forms.BindingSource tCargoBindingSource;
        private Duck_DuckDataSet1TableAdapters.t_CargoTableAdapter t_CargoTableAdapter;
        private System.Windows.Forms.BindingSource fKtlogintCargoBindingSource;
        private System.Windows.Forms.BindingSource tCargoBindingSource1;
        private System.Windows.Forms.BindingSource tCargoBindingSource2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource tCargoBindingSource3;
        private System.Windows.Forms.BindingSource fKtlogintCargoBindingSource1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtPreco;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtPrecoFornecedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbxForncedor;
        private Duck_DuckDataSet1 duck_DuckDataSet11;
        private System.Windows.Forms.BindingSource tFornecedorBindingSource;
        private Duck_DuckDataSet1TableAdapters.t_FornecedorTableAdapter t_FornecedorTableAdapter;
    }
}