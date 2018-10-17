namespace WindowsFormsApp5
{
    partial class FiltroVendas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.PnlAno = new System.Windows.Forms.Panel();
            this.NudAnual = new System.Windows.Forms.NumericUpDown();
            this.ChkAnual = new System.Windows.Forms.CheckBox();
            this.ChkMensal = new System.Windows.Forms.CheckBox();
            this.pnlMes = new System.Windows.Forms.Panel();
            this.NudMensal = new System.Windows.Forms.NumericUpDown();
            this.CboMen = new System.Windows.Forms.ComboBox();
            this.ChkDiario = new System.Windows.Forms.CheckBox();
            this.PnlDia = new System.Windows.Forms.Panel();
            this.DateDiarioInicial = new System.Windows.Forms.DateTimePicker();
            this.DateDiarioFinal = new System.Windows.Forms.DateTimePicker();
            this.CboPro = new System.Windows.Forms.ComboBox();
            this.sListaDadosProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duckDuckDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duck_DuckDataSet1 = new WindowsFormsApp5.Duck_DuckDataSet1();
            this.sListaDadosUsuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CboVen = new System.Windows.Forms.ComboBox();
            this.sListaDadosUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tloginBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.t_ProdutoTableAdapter = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.t_ProdutoTableAdapter();
            this.t_LoginTableAdapter = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.t_LoginTableAdapter();
            this.t_loginTableAdapter1 = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.t_loginTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.s_Lista_Dados_UsuarioTableAdapter = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.s_Lista_Dados_UsuarioTableAdapter();
            this.sRetornaProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s_Retorna_ProdutoTableAdapter = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.s_Retorna_ProdutoTableAdapter();
            this.sRetornaDadosProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s_Retorna_Dados_ProdutoTableAdapter = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.s_Retorna_Dados_ProdutoTableAdapter();
            this.s_Lista_Dados_ProdutoTableAdapter = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.s_Lista_Dados_ProdutoTableAdapter();
            this.PnlAno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnual)).BeginInit();
            this.pnlMes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudMensal)).BeginInit();
            this.PnlDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sListaDadosProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duckDuckDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duck_DuckDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sListaDadosUsuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sListaDadosUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tloginBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLoginBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sRetornaProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRetornaDadosProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 361);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(781, 5);
            this.panel3.TabIndex = 1033;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(781, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 361);
            this.panel1.TabIndex = 1034;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 366);
            this.panel2.TabIndex = 1026;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfirmar.BackColor = System.Drawing.Color.Orange;
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnConfirmar.Location = new System.Drawing.Point(552, 312);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(200, 30);
            this.BtnConfirmar.TabIndex = 1051;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click_1);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.BackColor = System.Drawing.Color.Orange;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.Location = new System.Drawing.Point(293, 311);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(200, 31);
            this.BtnCancelar.TabIndex = 1050;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // PnlAno
            // 
            this.PnlAno.Controls.Add(this.NudAnual);
            this.PnlAno.Location = new System.Drawing.Point(40, 286);
            this.PnlAno.Name = "PnlAno";
            this.PnlAno.Size = new System.Drawing.Size(234, 74);
            this.PnlAno.TabIndex = 1049;
            // 
            // NudAnual
            // 
            this.NudAnual.Location = new System.Drawing.Point(11, 26);
            this.NudAnual.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.NudAnual.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NudAnual.Name = "NudAnual";
            this.NudAnual.Size = new System.Drawing.Size(200, 20);
            this.NudAnual.TabIndex = 1041;
            this.NudAnual.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // ChkAnual
            // 
            this.ChkAnual.AutoSize = true;
            this.ChkAnual.ForeColor = System.Drawing.Color.White;
            this.ChkAnual.Location = new System.Drawing.Point(51, 291);
            this.ChkAnual.Name = "ChkAnual";
            this.ChkAnual.Size = new System.Drawing.Size(53, 17);
            this.ChkAnual.TabIndex = 1043;
            this.ChkAnual.Text = "Anual";
            this.ChkAnual.UseVisualStyleBackColor = true;
            this.ChkAnual.CheckedChanged += new System.EventHandler(this.ChkAnual_CheckedChanged_1);
            this.ChkAnual.Click += new System.EventHandler(this.ChkAnual_CheckedChanged);
            // 
            // ChkMensal
            // 
            this.ChkMensal.AutoSize = true;
            this.ChkMensal.ForeColor = System.Drawing.Color.White;
            this.ChkMensal.Location = new System.Drawing.Point(51, 193);
            this.ChkMensal.Name = "ChkMensal";
            this.ChkMensal.Size = new System.Drawing.Size(60, 17);
            this.ChkMensal.TabIndex = 1048;
            this.ChkMensal.Text = "Mensal";
            this.ChkMensal.UseVisualStyleBackColor = true;
            this.ChkMensal.CheckedChanged += new System.EventHandler(this.ChkMensal_CheckedChanged_1);
            this.ChkMensal.Click += new System.EventHandler(this.ChkMensal_CheckedChanged);
            // 
            // pnlMes
            // 
            this.pnlMes.Controls.Add(this.NudMensal);
            this.pnlMes.Controls.Add(this.CboMen);
            this.pnlMes.Location = new System.Drawing.Point(43, 187);
            this.pnlMes.Name = "pnlMes";
            this.pnlMes.Size = new System.Drawing.Size(460, 66);
            this.pnlMes.TabIndex = 1047;
            // 
            // NudMensal
            // 
            this.NudMensal.Location = new System.Drawing.Point(250, 27);
            this.NudMensal.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.NudMensal.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NudMensal.Name = "NudMensal";
            this.NudMensal.Size = new System.Drawing.Size(200, 20);
            this.NudMensal.TabIndex = 1041;
            this.NudMensal.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // CboMen
            // 
            this.CboMen.FormattingEnabled = true;
            this.CboMen.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.CboMen.Location = new System.Drawing.Point(9, 27);
            this.CboMen.Name = "CboMen";
            this.CboMen.Size = new System.Drawing.Size(200, 21);
            this.CboMen.TabIndex = 1040;
            // 
            // ChkDiario
            // 
            this.ChkDiario.AutoSize = true;
            this.ChkDiario.Checked = true;
            this.ChkDiario.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkDiario.ForeColor = System.Drawing.Color.White;
            this.ChkDiario.Location = new System.Drawing.Point(54, 84);
            this.ChkDiario.Name = "ChkDiario";
            this.ChkDiario.Size = new System.Drawing.Size(53, 17);
            this.ChkDiario.TabIndex = 1046;
            this.ChkDiario.Text = "Diario";
            this.ChkDiario.UseVisualStyleBackColor = true;
            this.ChkDiario.CheckedChanged += new System.EventHandler(this.ChkDiario_CheckedChanged_1);
            this.ChkDiario.Click += new System.EventHandler(this.ChkDiario_CheckedChanged);
            // 
            // PnlDia
            // 
            this.PnlDia.Controls.Add(this.DateDiarioInicial);
            this.PnlDia.Controls.Add(this.DateDiarioFinal);
            this.PnlDia.Location = new System.Drawing.Point(43, 80);
            this.PnlDia.Name = "PnlDia";
            this.PnlDia.Size = new System.Drawing.Size(460, 66);
            this.PnlDia.TabIndex = 1045;
            this.PnlDia.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlDia_Paint);
            // 
            // DateDiarioInicial
            // 
            this.DateDiarioInicial.CustomFormat = "dd/MM/yyyy";
            this.DateDiarioInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDiarioInicial.Location = new System.Drawing.Point(11, 26);
            this.DateDiarioInicial.Name = "DateDiarioInicial";
            this.DateDiarioInicial.Size = new System.Drawing.Size(200, 20);
            this.DateDiarioInicial.TabIndex = 1037;
            this.DateDiarioInicial.Value = new System.DateTime(2018, 9, 2, 0, 0, 0, 0);
            // 
            // DateDiarioFinal
            // 
            this.DateDiarioFinal.CustomFormat = "dd/MM/yyyy";
            this.DateDiarioFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDiarioFinal.Location = new System.Drawing.Point(250, 26);
            this.DateDiarioFinal.Name = "DateDiarioFinal";
            this.DateDiarioFinal.Size = new System.Drawing.Size(200, 20);
            this.DateDiarioFinal.TabIndex = 1036;
            this.DateDiarioFinal.Value = new System.DateTime(2018, 9, 3, 0, 0, 0, 0);
            // 
            // CboPro
            // 
            this.CboPro.DataSource = this.sListaDadosProdutoBindingSource;
            this.CboPro.DisplayMember = "nome";
            this.CboPro.FormattingEnabled = true;
            this.CboPro.Location = new System.Drawing.Point(552, 214);
            this.CboPro.Name = "CboPro";
            this.CboPro.Size = new System.Drawing.Size(200, 21);
            this.CboPro.TabIndex = 1052;
            this.CboPro.ValueMember = "codigo";
            this.CboPro.SelectedIndexChanged += new System.EventHandler(this.CboPro_SelectedIndexChanged);
            // 
            // sListaDadosProdutoBindingSource
            // 
            this.sListaDadosProdutoBindingSource.DataMember = "s_Lista_Dados_Produto";
            this.sListaDadosProdutoBindingSource.DataSource = this.duckDuckDataSet1BindingSource;
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
            // sListaDadosUsuarioBindingSource1
            // 
            this.sListaDadosUsuarioBindingSource1.DataMember = "s_Lista_Dados_Usuario";
            this.sListaDadosUsuarioBindingSource1.DataSource = this.duckDuckDataSet1BindingSource;
            // 
            // tProdutoBindingSource
            // 
            this.tProdutoBindingSource.DataMember = "t_Produto";
            this.tProdutoBindingSource.DataSource = this.duckDuckDataSet1BindingSource;
            // 
            // CboVen
            // 
            this.CboVen.DataSource = this.sListaDadosUsuarioBindingSource;
            this.CboVen.DisplayMember = "nome";
            this.CboVen.FormattingEnabled = true;
            this.CboVen.Location = new System.Drawing.Point(552, 106);
            this.CboVen.Name = "CboVen";
            this.CboVen.Size = new System.Drawing.Size(200, 21);
            this.CboVen.TabIndex = 1052;
            this.CboVen.ValueMember = "codigo";
            this.CboVen.SelectedIndexChanged += new System.EventHandler(this.CboVen_SelectedIndexChanged);
            // 
            // sListaDadosUsuarioBindingSource
            // 
            this.sListaDadosUsuarioBindingSource.DataMember = "s_Lista_Dados_Usuario";
            this.sListaDadosUsuarioBindingSource.DataSource = this.duckDuckDataSet1BindingSource;
            // 
            // tloginBindingSource1
            // 
            this.tloginBindingSource1.DataMember = "t_login";
            this.tloginBindingSource1.DataSource = this.duckDuckDataSet1BindingSource;
            // 
            // tLoginBindingSource
            // 
            this.tLoginBindingSource.DataMember = "t_Login";
            this.tLoginBindingSource.DataSource = this.duckDuckDataSet1BindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(549, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1053;
            this.label1.Text = "Produto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.ForeColor = System.Drawing.Color.White;
            this.Usuario.Location = new System.Drawing.Point(549, 89);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 1053;
            this.Usuario.Text = "Usuario";
            this.Usuario.Click += new System.EventHandler(this.label2_Click);
            // 
            // t_ProdutoTableAdapter
            // 
            this.t_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // t_LoginTableAdapter
            // 
            this.t_LoginTableAdapter.ClearBeforeFill = true;
            // 
            // t_loginTableAdapter1
            // 
            this.t_loginTableAdapter1.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 38);
            this.panel4.TabIndex = 1058;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(282, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 25);
            this.label5.TabIndex = 1001;
            this.label5.Text = "Tela de Filtro - Vendas";
            // 
            // s_Lista_Dados_UsuarioTableAdapter
            // 
            this.s_Lista_Dados_UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // sRetornaProdutoBindingSource
            // 
            this.sRetornaProdutoBindingSource.DataMember = "s_Retorna_Produto";
            this.sRetornaProdutoBindingSource.DataSource = this.duckDuckDataSet1BindingSource;
            // 
            // s_Retorna_ProdutoTableAdapter
            // 
            this.s_Retorna_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // sRetornaDadosProdutoBindingSource
            // 
            this.sRetornaDadosProdutoBindingSource.DataMember = "s_Retorna_Dados_Produto";
            this.sRetornaDadosProdutoBindingSource.DataSource = this.duckDuckDataSet1BindingSource;
            // 
            // s_Retorna_Dados_ProdutoTableAdapter
            // 
            this.s_Retorna_Dados_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // s_Lista_Dados_ProdutoTableAdapter
            // 
            this.s_Lista_Dados_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // FiltroVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(786, 366);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ChkAnual);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboVen);
            this.Controls.Add(this.CboPro);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.PnlAno);
            this.Controls.Add(this.ChkMensal);
            this.Controls.Add(this.ChkDiario);
            this.Controls.Add(this.PnlDia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FiltroVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiltroVendas";
            this.Load += new System.EventHandler(this.FiltroVendas_Load);
            this.PnlAno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NudAnual)).EndInit();
            this.pnlMes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NudMensal)).EndInit();
            this.PnlDia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sListaDadosProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duckDuckDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duck_DuckDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sListaDadosUsuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sListaDadosUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tloginBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLoginBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sRetornaProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRetornaDadosProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Panel PnlAno;
        private System.Windows.Forms.CheckBox ChkAnual;
        private System.Windows.Forms.CheckBox ChkMensal;
        private System.Windows.Forms.Panel pnlMes;
        private System.Windows.Forms.CheckBox ChkDiario;
        private System.Windows.Forms.Panel PnlDia;
        private System.Windows.Forms.ComboBox CboMen;
        private System.Windows.Forms.NumericUpDown NudAnual;
        private System.Windows.Forms.NumericUpDown NudMensal;
        private System.Windows.Forms.DateTimePicker DateDiarioInicial;
        private System.Windows.Forms.DateTimePicker DateDiarioFinal;
        private System.Windows.Forms.ComboBox CboPro;
        private System.Windows.Forms.BindingSource duckDuckDataSet1BindingSource;
        private Duck_DuckDataSet1 duck_DuckDataSet1;
        private System.Windows.Forms.ComboBox CboVen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.BindingSource tProdutoBindingSource;
        private Duck_DuckDataSet1TableAdapters.t_ProdutoTableAdapter t_ProdutoTableAdapter;
        private System.Windows.Forms.BindingSource tLoginBindingSource;
        private Duck_DuckDataSet1TableAdapters.t_LoginTableAdapter t_LoginTableAdapter;
        private System.Windows.Forms.BindingSource tloginBindingSource1;
        private Duck_DuckDataSet1TableAdapters.t_loginTableAdapter t_loginTableAdapter1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource sListaDadosUsuarioBindingSource;
        private Duck_DuckDataSet1TableAdapters.s_Lista_Dados_UsuarioTableAdapter s_Lista_Dados_UsuarioTableAdapter;
        private System.Windows.Forms.BindingSource sRetornaProdutoBindingSource;
        private Duck_DuckDataSet1TableAdapters.s_Retorna_ProdutoTableAdapter s_Retorna_ProdutoTableAdapter;
        private System.Windows.Forms.BindingSource sRetornaDadosProdutoBindingSource;
        private Duck_DuckDataSet1TableAdapters.s_Retorna_Dados_ProdutoTableAdapter s_Retorna_Dados_ProdutoTableAdapter;
        private System.Windows.Forms.BindingSource sListaDadosUsuarioBindingSource1;
        private System.Windows.Forms.BindingSource sListaDadosProdutoBindingSource;
        private Duck_DuckDataSet1TableAdapters.s_Lista_Dados_ProdutoTableAdapter s_Lista_Dados_ProdutoTableAdapter;
    }
}