namespace WindowsFormsApp5
{
    partial class Cadastrar
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
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSenhaConf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cargo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.duck_DuckDataSet1 = new WindowsFormsApp5.Duck_DuckDataSet1();
            this.tloginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_loginTableAdapter = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.t_loginTableAdapter();
            this.tCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_CargoTableAdapter = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.t_CargoTableAdapter();
            this.fKtlogintCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCargoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.tCargoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tCargoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fKtlogintCargoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duck_DuckDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tloginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtlogintCargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCargoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCargoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCargoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtlogintCargoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 255);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 5);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(700, 38);
            this.panel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(254, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 1001;
            this.label5.Text = "Tela de Cadastro";
            // 
            // TxtNome
            // 
            this.TxtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNome.Location = new System.Drawing.Point(25, 79);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(182, 20);
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
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 1004;
            this.label1.Text = "Nome";
            // 
            // TxtLogin
            // 
            this.TxtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLogin.Location = new System.Drawing.Point(262, 79);
            this.TxtLogin.MaxLength = 50;
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(182, 20);
            this.TxtLogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(267, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 1004;
            this.label2.Text = "Login";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(492, 79);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(497, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 1004;
            this.label3.Text = "Email";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.Location = new System.Drawing.Point(25, 157);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(182, 20);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.Tag = "";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 1004;
            this.label4.Text = "Senha";
            // 
            // TxtSenhaConf
            // 
            this.TxtSenhaConf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSenhaConf.Location = new System.Drawing.Point(262, 157);
            this.TxtSenhaConf.MaxLength = 50;
            this.TxtSenhaConf.Name = "TxtSenhaConf";
            this.TxtSenhaConf.PasswordChar = '•';
            this.TxtSenhaConf.Size = new System.Drawing.Size(182, 20);
            this.TxtSenhaConf.TabIndex = 4;
            this.TxtSenhaConf.Tag = "";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(267, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 1004;
            this.label6.Text = "Confirmação";
            // 
            // Cargo
            // 
            this.Cargo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cargo.AutoSize = true;
            this.Cargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cargo.ForeColor = System.Drawing.Color.White;
            this.Cargo.Location = new System.Drawing.Point(497, 131);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(60, 21);
            this.Cargo.TabIndex = 1006;
            this.Cargo.Text = "Cargo";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(552, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 31);
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
            this.button2.Location = new System.Drawing.Point(405, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 31);
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
            // cbxCargo
            // 
            this.cbxCargo.DataSource = this.tCargoBindingSource3;
            this.cbxCargo.DisplayMember = "nome";
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Location = new System.Drawing.Point(492, 157);
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(189, 21);
            this.cbxCargo.TabIndex = 5;
            this.cbxCargo.ValueMember = "codigo";
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
            this.panel2.Size = new System.Drawing.Size(5, 217);
            this.panel2.TabIndex = 1007;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(695, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 217);
            this.panel1.TabIndex = 1008;
            // 
            // fKtlogintCargoBindingSource1
            // 
            this.fKtlogintCargoBindingSource1.DataMember = "FK_t_login_t_Cargo";
            this.fKtlogintCargoBindingSource1.DataSource = this.tCargoBindingSource3;
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(700, 260);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbxCargo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cargo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSenhaConf);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastrar";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtSenhaConf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Cargo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Duck_DuckDataSet1 duck_DuckDataSet1;
        private System.Windows.Forms.BindingSource tloginBindingSource;
        private Duck_DuckDataSet1TableAdapters.t_loginTableAdapter t_loginTableAdapter;
        private System.Windows.Forms.BindingSource tCargoBindingSource;
        private Duck_DuckDataSet1TableAdapters.t_CargoTableAdapter t_CargoTableAdapter;
        private System.Windows.Forms.BindingSource fKtlogintCargoBindingSource;
        private System.Windows.Forms.BindingSource tCargoBindingSource1;
        private System.Windows.Forms.ComboBox cbxCargo;
        private System.Windows.Forms.BindingSource tCargoBindingSource2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource tCargoBindingSource3;
        private System.Windows.Forms.BindingSource fKtlogintCargoBindingSource1;
    }
}