namespace WindowsFormsApp5
{
    partial class EditarProduto
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
            this.tCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duck_DuckDataSet1 = new WindowsFormsApp5.Duck_DuckDataSet1();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.t_CargoTableAdapter = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.t_CargoTableAdapter();
            this.tFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_FornecedorTableAdapter = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.t_FornecedorTableAdapter();
            this.tProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_ProdutoTableAdapter = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.t_ProdutoTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            this.ChkQuantidade = new System.Windows.Forms.CheckBox();
            this.ChkValidade = new System.Windows.Forms.CheckBox();
            this.PnlValidade = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.DtmValidade = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.DtmFabricacao = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.LblQuantidadeTotal = new System.Windows.Forms.Label();
            this.TxtQuantidadeTotal = new System.Windows.Forms.TextBox();
            this.LblMontante = new System.Windows.Forms.Label();
            this.TxtMontante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxForncedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblQuantidade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDetalhes = new System.Windows.Forms.TextBox();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tCargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duck_DuckDataSet1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProdutoBindingSource)).BeginInit();
            this.PnlValidade.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tCargoBindingSource
            // 
            this.tCargoBindingSource.DataMember = "t_Cargo";
            this.tCargoBindingSource.DataSource = this.duck_DuckDataSet1;
            // 
            // duck_DuckDataSet1
            // 
            this.duck_DuckDataSet1.DataSetName = "Duck_DuckDataSet1";
            this.duck_DuckDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(928, 38);
            this.panel4.TabIndex = 1011;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(337, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 25);
            this.label5.TabIndex = 1001;
            this.label5.Text = "Tela de Edição - Produto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 323);
            this.panel2.TabIndex = 1022;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(923, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 323);
            this.panel1.TabIndex = 1023;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(918, 5);
            this.panel3.TabIndex = 1024;
            // 
            // t_CargoTableAdapter
            // 
            this.t_CargoTableAdapter.ClearBeforeFill = true;
            // 
            // tFornecedorBindingSource
            // 
            this.tFornecedorBindingSource.DataMember = "t_Fornecedor";
            this.tFornecedorBindingSource.DataSource = this.duck_DuckDataSet1;
            // 
            // t_FornecedorTableAdapter
            // 
            this.t_FornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tProdutoBindingSource
            // 
            this.tProdutoBindingSource.DataMember = "t_Produto";
            this.tProdutoBindingSource.DataSource = this.duck_DuckDataSet1;
            // 
            // t_ProdutoTableAdapter
            // 
            this.t_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(27, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 25);
            this.label12.TabIndex = 1066;
            this.label12.Text = "Validade Produto";
            // 
            // ChkQuantidade
            // 
            this.ChkQuantidade.AutoSize = true;
            this.ChkQuantidade.Location = new System.Drawing.Point(6, 142);
            this.ChkQuantidade.Name = "ChkQuantidade";
            this.ChkQuantidade.Size = new System.Drawing.Size(15, 14);
            this.ChkQuantidade.TabIndex = 1069;
            this.ChkQuantidade.UseVisualStyleBackColor = true;
            this.ChkQuantidade.CheckedChanged += new System.EventHandler(this.ChkQuantidade_CheckedChanged);
            // 
            // ChkValidade
            // 
            this.ChkValidade.AutoSize = true;
            this.ChkValidade.Location = new System.Drawing.Point(8, 256);
            this.ChkValidade.Name = "ChkValidade";
            this.ChkValidade.Size = new System.Drawing.Size(15, 14);
            this.ChkValidade.TabIndex = 1068;
            this.ChkValidade.UseVisualStyleBackColor = true;
            this.ChkValidade.CheckedChanged += new System.EventHandler(this.ChkValidade_CheckedChanged_1);
            // 
            // PnlValidade
            // 
            this.PnlValidade.Controls.Add(this.label13);
            this.PnlValidade.Controls.Add(this.DtmValidade);
            this.PnlValidade.Controls.Add(this.label14);
            this.PnlValidade.Controls.Add(this.DtmFabricacao);
            this.PnlValidade.Location = new System.Drawing.Point(13, 251);
            this.PnlValidade.Name = "PnlValidade";
            this.PnlValidade.Size = new System.Drawing.Size(429, 95);
            this.PnlValidade.TabIndex = 1067;
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
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(482, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 31);
            this.button2.TabIndex = 1065;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(710, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 31);
            this.button1.TabIndex = 1064;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.panel6.Location = new System.Drawing.Point(469, 44);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(430, 154);
            this.panel6.TabIndex = 1063;
            // 
            // TxtPrecoTotal
            // 
            this.TxtPrecoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrecoTotal.Enabled = false;
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
            this.label6.Location = new System.Drawing.Point(13, 0);
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
            this.TxtPorcentagemLucro.TextChanged += new System.EventHandler(this.TxtPorcentagemLucro_TextChanged);
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
            // panel5
            // 
            this.panel5.Controls.Add(this.LblQuantidadeTotal);
            this.panel5.Controls.Add(this.TxtQuantidadeTotal);
            this.panel5.Controls.Add(this.LblMontante);
            this.panel5.Controls.Add(this.TxtMontante);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.CbxForncedor);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.LblQuantidade);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.TxtDetalhes);
            this.panel5.Controls.Add(this.TxtQuantidade);
            this.panel5.Controls.Add(this.TxtNome);
            this.panel5.Location = new System.Drawing.Point(12, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(430, 201);
            this.panel5.TabIndex = 1062;
            // 
            // LblQuantidadeTotal
            // 
            this.LblQuantidadeTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblQuantidadeTotal.AutoSize = true;
            this.LblQuantidadeTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantidadeTotal.ForeColor = System.Drawing.Color.White;
            this.LblQuantidadeTotal.Location = new System.Drawing.Point(238, 149);
            this.LblQuantidadeTotal.Name = "LblQuantidadeTotal";
            this.LblQuantidadeTotal.Size = new System.Drawing.Size(151, 21);
            this.LblQuantidadeTotal.TabIndex = 1045;
            this.LblQuantidadeTotal.Text = "Quantidade Total";
            // 
            // TxtQuantidadeTotal
            // 
            this.TxtQuantidadeTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtQuantidadeTotal.Enabled = false;
            this.TxtQuantidadeTotal.Location = new System.Drawing.Point(242, 173);
            this.TxtQuantidadeTotal.MaxLength = 50;
            this.TxtQuantidadeTotal.Name = "TxtQuantidadeTotal";
            this.TxtQuantidadeTotal.Size = new System.Drawing.Size(175, 20);
            this.TxtQuantidadeTotal.TabIndex = 1044;
            // 
            // LblMontante
            // 
            this.LblMontante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMontante.AutoSize = true;
            this.LblMontante.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMontante.ForeColor = System.Drawing.Color.White;
            this.LblMontante.Location = new System.Drawing.Point(10, 149);
            this.LblMontante.Name = "LblMontante";
            this.LblMontante.Size = new System.Drawing.Size(90, 21);
            this.LblMontante.TabIndex = 1043;
            this.LblMontante.Text = "Montante";
            // 
            // TxtMontante
            // 
            this.TxtMontante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMontante.Location = new System.Drawing.Point(14, 173);
            this.TxtMontante.MaxLength = 50;
            this.TxtMontante.Name = "TxtMontante";
            this.TxtMontante.Size = new System.Drawing.Size(175, 20);
            this.TxtMontante.TabIndex = 1042;
            this.TxtMontante.TextChanged += new System.EventHandler(this.TxtMontante_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 1041;
            this.label3.Text = "Dados Produto";
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
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(240, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 1036;
            this.label4.Text = "Detalhes";
            // 
            // LblQuantidade
            // 
            this.LblQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblQuantidade.AutoSize = true;
            this.LblQuantidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantidade.ForeColor = System.Drawing.Color.White;
            this.LblQuantidade.Location = new System.Drawing.Point(10, 93);
            this.LblQuantidade.Name = "LblQuantidade";
            this.LblQuantidade.Size = new System.Drawing.Size(108, 21);
            this.LblQuantidade.TabIndex = 1037;
            this.LblQuantidade.Text = "Quantidade";
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
            // TxtDetalhes
            // 
            this.TxtDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDetalhes.Location = new System.Drawing.Point(241, 51);
            this.TxtDetalhes.MaxLength = 50;
            this.TxtDetalhes.Multiline = true;
            this.TxtDetalhes.Name = "TxtDetalhes";
            this.TxtDetalhes.Size = new System.Drawing.Size(175, 21);
            this.TxtDetalhes.TabIndex = 1033;
            this.TxtDetalhes.Tag = "";
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtQuantidade.Location = new System.Drawing.Point(14, 117);
            this.TxtQuantidade.MaxLength = 50;
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(175, 20);
            this.TxtQuantidade.TabIndex = 1032;
            this.TxtQuantidade.TextChanged += new System.EventHandler(this.TxtQuantidade_TextChanged);
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
            // EditarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(928, 361);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ChkQuantidade);
            this.Controls.Add(this.ChkValidade);
            this.Controls.Add(this.PnlValidade);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarProduto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tCargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duck_DuckDataSet1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProdutoBindingSource)).EndInit();
            this.PnlValidade.ResumeLayout(false);
            this.PnlValidade.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Duck_DuckDataSet1 duck_DuckDataSet1;
        private System.Windows.Forms.BindingSource tCargoBindingSource;
        private Duck_DuckDataSet1TableAdapters.t_CargoTableAdapter t_CargoTableAdapter;
        private System.Windows.Forms.BindingSource tFornecedorBindingSource;
        private Duck_DuckDataSet1TableAdapters.t_FornecedorTableAdapter t_FornecedorTableAdapter;
        private System.Windows.Forms.BindingSource tProdutoBindingSource;
        private Duck_DuckDataSet1TableAdapters.t_ProdutoTableAdapter t_ProdutoTableAdapter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox ChkQuantidade;
        private System.Windows.Forms.CheckBox ChkValidade;
        private System.Windows.Forms.Panel PnlValidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker DtmValidade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker DtmFabricacao;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.TextBox TxtPrecoTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox TxtPorcentagemLucro;
        public System.Windows.Forms.TextBox TxtPorcentagemImposto;
        public System.Windows.Forms.TextBox TxtPrecoFornecedor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LblQuantidadeTotal;
        public System.Windows.Forms.TextBox TxtQuantidadeTotal;
        private System.Windows.Forms.Label LblMontante;
        public System.Windows.Forms.TextBox TxtMontante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxForncedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblQuantidade;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtDetalhes;
        public System.Windows.Forms.TextBox TxtQuantidade;
        public System.Windows.Forms.TextBox TxtNome;
    }
}