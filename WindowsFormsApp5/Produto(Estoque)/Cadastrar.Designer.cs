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
            this.tFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duck_DuckDataSet11 = new WindowsFormsApp5.Duck_DuckDataSet1();
            this.t_FornecedorTableAdapter = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.t_FornecedorTableAdapter();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.TxtDetalhes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CbxForncedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TxtPrecoTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtPorcentagemLucro = new System.Windows.Forms.TextBox();
            this.TxtPorcentagemImposto = new System.Windows.Forms.TextBox();
            this.TxtPrecoFornecedor = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DtmValidade = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.DtmFabricacao = new System.Windows.Forms.DateTimePicker();
            this.PnlValidade = new System.Windows.Forms.Panel();
            this.ChkValidade = new System.Windows.Forms.CheckBox();
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
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.PnlValidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(930, 5);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(930, 38);
            this.panel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(301, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 25);
            this.label5.TabIndex = 1001;
            this.label5.Text = "Tela de Cadastro - Produtos";
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
            this.panel2.Size = new System.Drawing.Size(5, 278);
            this.panel2.TabIndex = 1007;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(925, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 278);
            this.panel1.TabIndex = 1008;
            // 
            // fKtlogintCargoBindingSource1
            // 
            this.fKtlogintCargoBindingSource1.DataMember = "FK_t_login_t_Cargo";
            this.fKtlogintCargoBindingSource1.DataSource = this.tCargoBindingSource3;
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
            // TxtNome
            // 
            this.TxtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNome.Location = new System.Drawing.Point(13, 52);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(175, 20);
            this.TxtNome.TabIndex = 1031;
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtQuantidade.Location = new System.Drawing.Point(241, 52);
            this.TxtQuantidade.MaxLength = 50;
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(175, 20);
            this.TxtQuantidade.TabIndex = 1032;
            // 
            // TxtDetalhes
            // 
            this.TxtDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDetalhes.Location = new System.Drawing.Point(13, 117);
            this.TxtDetalhes.MaxLength = 50;
            this.TxtDetalhes.Multiline = true;
            this.TxtDetalhes.Name = "TxtDetalhes";
            this.TxtDetalhes.Size = new System.Drawing.Size(175, 21);
            this.TxtDetalhes.TabIndex = 1033;
            this.TxtDetalhes.Tag = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 1038;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(237, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 1037;
            this.label2.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 1036;
            this.label4.Text = "Detalhes";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(240, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 1039;
            this.label7.Text = "Fornecedor";
            // 
            // CbxForncedor
            // 
            this.CbxForncedor.DataSource = this.tFornecedorBindingSource;
            this.CbxForncedor.DisplayMember = "nome";
            this.CbxForncedor.FormattingEnabled = true;
            this.CbxForncedor.Location = new System.Drawing.Point(241, 117);
            this.CbxForncedor.Name = "CbxForncedor";
            this.CbxForncedor.Size = new System.Drawing.Size(175, 21);
            this.CbxForncedor.TabIndex = 1040;
            this.CbxForncedor.ValueMember = "codigo";
            this.CbxForncedor.SelectedIndexChanged += new System.EventHandler(this.CbxForncedor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 1041;
            this.label3.Text = "Dados Produto";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.CbxForncedor);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.TxtDetalhes);
            this.panel5.Controls.Add(this.TxtQuantidade);
            this.panel5.Controls.Add(this.TxtNome);
            this.panel5.Location = new System.Drawing.Point(25, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(430, 154);
            this.panel5.TabIndex = 1042;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.TxtPrecoTotal);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.TxtPorcentagemLucro);
            this.panel6.Controls.Add(this.TxtPorcentagemImposto);
            this.panel6.Controls.Add(this.TxtPrecoFornecedor);
            this.panel6.Location = new System.Drawing.Point(482, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(430, 154);
            this.panel6.TabIndex = 1043;
            // 
            // TxtPrecoTotal
            // 
            this.TxtPrecoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrecoTotal.Location = new System.Drawing.Point(241, 117);
            this.TxtPrecoTotal.MaxLength = 50;
            this.TxtPrecoTotal.Multiline = true;
            this.TxtPrecoTotal.Name = "TxtPrecoTotal";
            this.TxtPrecoTotal.Size = new System.Drawing.Size(175, 21);
            this.TxtPrecoTotal.TabIndex = 1042;
            this.TxtPrecoTotal.Tag = "";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(40, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 1041;
            this.label6.Text = "Preço Produto";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(240, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 21);
            this.label8.TabIndex = 1039;
            this.label8.Text = "Preço Total";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 21);
            this.label9.TabIndex = 1036;
            this.label9.Text = "Porcentagem Lucro";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(237, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 21);
            this.label10.TabIndex = 1037;
            this.label10.Text = "Porcentagem Imposto";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(9, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 21);
            this.label11.TabIndex = 1038;
            this.label11.Text = "Preço do Fornecedor";
            // 
            // TxtPorcentagemLucro
            // 
            this.TxtPorcentagemLucro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPorcentagemLucro.Location = new System.Drawing.Point(13, 117);
            this.TxtPorcentagemLucro.MaxLength = 50;
            this.TxtPorcentagemLucro.Multiline = true;
            this.TxtPorcentagemLucro.Name = "TxtPorcentagemLucro";
            this.TxtPorcentagemLucro.Size = new System.Drawing.Size(175, 21);
            this.TxtPorcentagemLucro.TabIndex = 1033;
            this.TxtPorcentagemLucro.Tag = "";
            // 
            // TxtPorcentagemImposto
            // 
            this.TxtPorcentagemImposto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPorcentagemImposto.Location = new System.Drawing.Point(241, 52);
            this.TxtPorcentagemImposto.MaxLength = 50;
            this.TxtPorcentagemImposto.Name = "TxtPorcentagemImposto";
            this.TxtPorcentagemImposto.Size = new System.Drawing.Size(175, 20);
            this.TxtPorcentagemImposto.TabIndex = 1032;
            // 
            // TxtPrecoFornecedor
            // 
            this.TxtPrecoFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrecoFornecedor.Location = new System.Drawing.Point(13, 52);
            this.TxtPrecoFornecedor.MaxLength = 50;
            this.TxtPrecoFornecedor.Name = "TxtPrecoFornecedor";
            this.TxtPrecoFornecedor.Size = new System.Drawing.Size(175, 20);
            this.TxtPrecoFornecedor.TabIndex = 1031;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(495, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 31);
            this.button2.TabIndex = 1046;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(723, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 31);
            this.button1.TabIndex = 1045;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(70, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 25);
            this.label12.TabIndex = 1047;
            this.label12.Text = "Validade Produto";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(237, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 21);
            this.label13.TabIndex = 1058;
            this.label13.Text = "Data de Validade";
            // 
            // DtmValidade
            // 
            this.DtmValidade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtmValidade.Location = new System.Drawing.Point(241, 47);
            this.DtmValidade.Name = "DtmValidade";
            this.DtmValidade.Size = new System.Drawing.Size(174, 20);
            this.DtmValidade.TabIndex = 1057;
            this.DtmValidade.Value = new System.DateTime(2018, 10, 4, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(9, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 21);
            this.label14.TabIndex = 1056;
            this.label14.Text = "Data de Fabricação";
            // 
            // DtmFabricacao
            // 
            this.DtmFabricacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtmFabricacao.Location = new System.Drawing.Point(13, 47);
            this.DtmFabricacao.Name = "DtmFabricacao";
            this.DtmFabricacao.Size = new System.Drawing.Size(174, 20);
            this.DtmFabricacao.TabIndex = 1055;
            this.DtmFabricacao.Value = new System.DateTime(2018, 10, 4, 0, 0, 0, 0);
            // 
            // PnlValidade
            // 
            this.PnlValidade.Controls.Add(this.label13);
            this.PnlValidade.Controls.Add(this.DtmValidade);
            this.PnlValidade.Controls.Add(this.label14);
            this.PnlValidade.Controls.Add(this.DtmFabricacao);
            this.PnlValidade.Location = new System.Drawing.Point(26, 210);
            this.PnlValidade.Name = "PnlValidade";
            this.PnlValidade.Size = new System.Drawing.Size(429, 95);
            this.PnlValidade.TabIndex = 1059;
            // 
            // ChkValidade
            // 
            this.ChkValidade.AutoSize = true;
            this.ChkValidade.Location = new System.Drawing.Point(52, 215);
            this.ChkValidade.Name = "ChkValidade";
            this.ChkValidade.Size = new System.Drawing.Size(15, 14);
            this.ChkValidade.TabIndex = 1060;
            this.ChkValidade.UseVisualStyleBackColor = true;
            this.ChkValidade.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(930, 321);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ChkValidade);
            this.Controls.Add(this.PnlValidade);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
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
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.PnlValidade.ResumeLayout(false);
            this.PnlValidade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
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
        private Duck_DuckDataSet1 duck_DuckDataSet11;
        private System.Windows.Forms.BindingSource tFornecedorBindingSource;
        private Duck_DuckDataSet1TableAdapters.t_FornecedorTableAdapter t_FornecedorTableAdapter;
        public System.Windows.Forms.TextBox TxtNome;
        public System.Windows.Forms.TextBox TxtQuantidade;
        public System.Windows.Forms.TextBox TxtDetalhes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbxForncedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox TxtPorcentagemLucro;
        public System.Windows.Forms.TextBox TxtPorcentagemImposto;
        public System.Windows.Forms.TextBox TxtPrecoFornecedor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker DtmValidade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker DtmFabricacao;
        private System.Windows.Forms.Panel PnlValidade;
        private System.Windows.Forms.CheckBox ChkValidade;
        public System.Windows.Forms.TextBox TxtPrecoTotal;
    }
}