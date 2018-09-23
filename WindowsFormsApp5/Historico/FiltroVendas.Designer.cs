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
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.NudAnual = new System.Windows.Forms.NumericUpDown();
            this.ChkAnual = new System.Windows.Forms.CheckBox();
            this.ChkMensal = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.NudMensal = new System.Windows.Forms.NumericUpDown();
            this.CboMen = new System.Windows.Forms.ComboBox();
            this.ChkDiario = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DateDiarioInicial = new System.Windows.Forms.DateTimePicker();
            this.DateDiarioFinal = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CboPro = new System.Windows.Forms.ComboBox();
            this.tProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duckDuckDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duck_DuckDataSet1 = new WindowsFormsApp5.Duck_DuckDataSet1();
            this.CboVen = new System.Windows.Forms.ComboBox();
            this.tloginBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_ProdutoTableAdapter = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.t_ProdutoTableAdapter();
            this.t_LoginTableAdapter = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.t_LoginTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_loginTableAdapter1 = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.t_loginTableAdapter();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnual)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudMensal)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duckDuckDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duck_DuckDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tloginBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLoginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 386);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1029, 5);
            this.panel3.TabIndex = 1033;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1029, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 386);
            this.panel1.TabIndex = 1034;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 391);
            this.panel2.TabIndex = 1026;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(409, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 25);
            this.label5.TabIndex = 1001;
            this.label5.Text = "Tela de Filtro - Vendas";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1034, 38);
            this.panel4.TabIndex = 1020;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnConfirmar.Location = new System.Drawing.Point(776, 312);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(175, 31);
            this.BtnConfirmar.TabIndex = 1051;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click_1);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.Location = new System.Drawing.Point(544, 312);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(175, 31);
            this.BtnCancelar.TabIndex = 1050;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.NudAnual);
            this.panel8.Controls.Add(this.ChkAnual);
            this.panel8.Location = new System.Drawing.Point(40, 294);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(463, 66);
            this.panel8.TabIndex = 1049;
            // 
            // NudAnual
            // 
            this.NudAnual.Location = new System.Drawing.Point(11, 26);
            this.NudAnual.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NudAnual.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.NudAnual.Name = "NudAnual";
            this.NudAnual.Size = new System.Drawing.Size(200, 20);
            this.NudAnual.TabIndex = 1041;
            this.NudAnual.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // ChkAnual
            // 
            this.ChkAnual.AutoSize = true;
            this.ChkAnual.ForeColor = System.Drawing.Color.White;
            this.ChkAnual.Location = new System.Drawing.Point(11, 3);
            this.ChkAnual.Name = "ChkAnual";
            this.ChkAnual.Size = new System.Drawing.Size(53, 17);
            this.ChkAnual.TabIndex = 1043;
            this.ChkAnual.Text = "Anual";
            this.ChkAnual.UseVisualStyleBackColor = true;
            this.ChkAnual.Click += new System.EventHandler(this.ChkAnual_CheckedChanged);
            // 
            // ChkMensal
            // 
            this.ChkMensal.AutoSize = true;
            this.ChkMensal.ForeColor = System.Drawing.Color.White;
            this.ChkMensal.Location = new System.Drawing.Point(54, 195);
            this.ChkMensal.Name = "ChkMensal";
            this.ChkMensal.Size = new System.Drawing.Size(60, 17);
            this.ChkMensal.TabIndex = 1048;
            this.ChkMensal.Text = "Mensal";
            this.ChkMensal.UseVisualStyleBackColor = true;
            this.ChkMensal.Click += new System.EventHandler(this.ChkMensal_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.NudMensal);
            this.panel7.Controls.Add(this.CboMen);
            this.panel7.Location = new System.Drawing.Point(43, 187);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(460, 66);
            this.panel7.TabIndex = 1047;
            // 
            // NudMensal
            // 
            this.NudMensal.Location = new System.Drawing.Point(250, 27);
            this.NudMensal.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NudMensal.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.NudMensal.Name = "NudMensal";
            this.NudMensal.Size = new System.Drawing.Size(200, 20);
            this.NudMensal.TabIndex = 1041;
            this.NudMensal.Value = new decimal(new int[] {
            2018,
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
            this.ChkDiario.ForeColor = System.Drawing.Color.White;
            this.ChkDiario.Location = new System.Drawing.Point(54, 89);
            this.ChkDiario.Name = "ChkDiario";
            this.ChkDiario.Size = new System.Drawing.Size(53, 17);
            this.ChkDiario.TabIndex = 1046;
            this.ChkDiario.Text = "Diario";
            this.ChkDiario.UseVisualStyleBackColor = true;
            this.ChkDiario.Click += new System.EventHandler(this.ChkDiario_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DateDiarioInicial);
            this.panel5.Controls.Add(this.DateDiarioFinal);
            this.panel5.Location = new System.Drawing.Point(43, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(460, 66);
            this.panel5.TabIndex = 1045;
            // 
            // DateDiarioInicial
            // 
            this.DateDiarioInicial.CustomFormat = "dd/MM/yyyy";
            this.DateDiarioInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateDiarioInicial.Location = new System.Drawing.Point(11, 26);
            this.DateDiarioInicial.Name = "DateDiarioInicial";
            this.DateDiarioInicial.Size = new System.Drawing.Size(200, 20);
            this.DateDiarioInicial.TabIndex = 1037;
            this.DateDiarioInicial.Value = new System.DateTime(2018, 9, 21, 0, 0, 0, 0);
            // 
            // DateDiarioFinal
            // 
            this.DateDiarioFinal.CustomFormat = "dd/MM/yyyy";
            this.DateDiarioFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateDiarioFinal.Location = new System.Drawing.Point(250, 26);
            this.DateDiarioFinal.Name = "DateDiarioFinal";
            this.DateDiarioFinal.Size = new System.Drawing.Size(200, 20);
            this.DateDiarioFinal.TabIndex = 1036;
            this.DateDiarioFinal.Value = new System.DateTime(2018, 9, 21, 0, 0, 0, 0);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(515, 37);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(4, 413);
            this.panel6.TabIndex = 1002;
            // 
            // CboPro
            // 
            this.CboPro.DataSource = this.tProdutoBindingSource;
            this.CboPro.DisplayMember = "nome";
            this.CboPro.FormattingEnabled = true;
            this.CboPro.Location = new System.Drawing.Point(552, 108);
            this.CboPro.Name = "CboPro";
            this.CboPro.Size = new System.Drawing.Size(200, 21);
            this.CboPro.TabIndex = 1052;
            this.CboPro.ValueMember = "codigo";
            // 
            // tProdutoBindingSource
            // 
            this.tProdutoBindingSource.DataMember = "t_Produto";
            this.tProdutoBindingSource.DataSource = this.duckDuckDataSet1BindingSource;
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
            // CboVen
            // 
            this.CboVen.DataSource = this.tloginBindingSource1;
            this.CboVen.DisplayMember = "login";
            this.CboVen.FormattingEnabled = true;
            this.CboVen.Location = new System.Drawing.Point(552, 213);
            this.CboVen.Name = "CboVen";
            this.CboVen.Size = new System.Drawing.Size(200, 21);
            this.CboVen.TabIndex = 1052;
            this.CboVen.ValueMember = "codigo";
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
            this.label1.Location = new System.Drawing.Point(560, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1053;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(560, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1053;
            this.label2.Text = "Vendedor";
            // 
            // t_ProdutoTableAdapter
            // 
            this.t_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // t_LoginTableAdapter
            // 
            this.t_LoginTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(226, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 1054;
            this.label3.Text = "Filtro Data";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(721, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 1055;
            this.label4.Text = "Filtro Venda";
            // 
            // t_loginTableAdapter1
            // 
            this.t_loginTableAdapter1.ClearBeforeFill = true;
            // 
            // FiltroVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1034, 391);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboVen);
            this.Controls.Add(this.CboPro);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.ChkMensal);
            this.Controls.Add(this.ChkDiario);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FiltroVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiltroVendas";
            this.Load += new System.EventHandler(this.FiltroVendas_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnual)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NudMensal)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duckDuckDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duck_DuckDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tloginBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLoginBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.CheckBox ChkAnual;
        private System.Windows.Forms.CheckBox ChkMensal;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox ChkDiario;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox CboMen;
        private System.Windows.Forms.NumericUpDown NudAnual;
        private System.Windows.Forms.NumericUpDown NudMensal;
        private System.Windows.Forms.DateTimePicker DateDiarioInicial;
        private System.Windows.Forms.DateTimePicker DateDiarioFinal;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox CboPro;
        private System.Windows.Forms.BindingSource duckDuckDataSet1BindingSource;
        private Duck_DuckDataSet1 duck_DuckDataSet1;
        private System.Windows.Forms.ComboBox CboVen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource tProdutoBindingSource;
        private Duck_DuckDataSet1TableAdapters.t_ProdutoTableAdapter t_ProdutoTableAdapter;
        private System.Windows.Forms.BindingSource tLoginBindingSource;
        private Duck_DuckDataSet1TableAdapters.t_LoginTableAdapter t_LoginTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource tloginBindingSource1;
        private Duck_DuckDataSet1TableAdapters.t_loginTableAdapter t_loginTableAdapter1;
    }
}