using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp5
{
    public partial class EditarFornecedor : Form
    {
        public bool empresa;
        public int codigo;
        public FornecedorCRUD telacadastro;

        public EditarFornecedor(FornecedorCRUD telacadastro, int codigo)   
        {
            InitializeComponent();
            this.telacadastro = telacadastro;
            this.codigo = codigo;
            Retorna_Informações();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edita_Fornecedor();
        }
        public void Retorna_Informações()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Retorna_Dados_Fornecedor", con);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                SqlDataReader i = cmd.ExecuteReader();
                if (i.Read())
                {
                    empresa  = (bool)i["empresa"];

                    if (empresa == false)
                    {
                        TxtNome.Text        = i["nome"].ToString();
                        TxtEmail.Text       = i["email"].ToString();
                        cboSexo.Text        = i["sexo"].ToString();
                        TxtTelefone.Text    = i["telefone"].ToString();
                        TxtCelular.Text     = i["celular"].ToString();
                        TxtCEP.Text         = i["CEP"].ToString();
                        TxtRG.Text          = i["RG"].ToString();
                        TxtCPF.Text         = i["CPF"].ToString();
                        TxtEndereco.Text    = i["endereco"].ToString();
                        TxtDescricao.Text   = i["descricao"].ToString();
                        cbkEmpresa.Checked  = false;
                    }
                    else
                    if (empresa == true)
                    {
                        TxtNomeEmpresa.Text         = i["nome"].ToString();
                        TxtEmailEmpresa.Text        = i["email"].ToString();
                        TxtTelefoneEmpresa.Text     = i["telefone"].ToString();
                        txtCelularEmrpesa.Text      = i["celular"].ToString();
                        TxtCEPEmpresa.Text          = i["CEP"].ToString();
                        TxtCNPJEmpresa.Text         = i["CNPJ"].ToString();
                        TxtIEEmpresa.Text           = i["IE"].ToString();
                        TxtEnderecoEmpresa.Text     = i["endereco"].ToString();
                        TxtDescricaoEmpresa.Text    = i["descricao"].ToString();
                        cbkEmpresa.Checked          = true;
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.t_Cargo'. Você pode movê-la ou removê-la conforme necessário.
            this.t_CargoTableAdapter.Fill(this.duck_DuckDataSet1.t_Cargo);

        }

        private void cbkEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            verifica_panel();
        }
        private void verifica_panel()
        {
            if (cbkEmpresa.Checked)
            {
                pnlEmpresa.Visible = true;
            }
            else
                pnlEmpresa.Visible = false;
        }
        private void EditaFornecedor()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Edita_Dados_Fornecedor", con);
            cmd.Parameters.AddWithValue("@empresa", 0);
            cmd.Parameters.AddWithValue("@nome", TxtNome.Text);
            cmd.Parameters.AddWithValue("@email", TxtEmail.Text);
            cmd.Parameters.AddWithValue("@sexo", cboSexo.Text);
            cmd.Parameters.AddWithValue("@telefone", TxtTelefone.Text);
            cmd.Parameters.AddWithValue("@celular", TxtCelular.Text);
            cmd.Parameters.AddWithValue("@CEP", TxtCEP.Text);
            cmd.Parameters.AddWithValue("@RG", TxtRG.Text);
            cmd.Parameters.AddWithValue("@CPF", TxtCPF.Text);
            cmd.Parameters.AddWithValue("@CNPJ", "");
            cmd.Parameters.AddWithValue("@IE", "");
            cmd.Parameters.AddWithValue("@endereco", TxtEndereco.Text);
            cmd.Parameters.AddWithValue("@descricao", TxtDescricao.Text);
            //seta o valor apra inserção da procedure


            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                telacadastro.Atualiza_Lista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void EditaFornecedorEmpresa()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Edita_Dados_Fornecedor", con);
            cmd.Parameters.AddWithValue("@empresa", 1);
            cmd.Parameters.AddWithValue("@nome", TxtNomeEmpresa.Text);
            cmd.Parameters.AddWithValue("@email", TxtEmailEmpresa.Text);
            cmd.Parameters.AddWithValue("@sexo", "");
            cmd.Parameters.AddWithValue("@telefone", TxtTelefoneEmpresa.Text);
            cmd.Parameters.AddWithValue("@celular", txtCelularEmrpesa.Text);
            cmd.Parameters.AddWithValue("@CEP", TxtCEPEmpresa.Text);
            cmd.Parameters.AddWithValue("@RG", "");
            cmd.Parameters.AddWithValue("@CPF", "");
            cmd.Parameters.AddWithValue("@CNPJ", TxtCNPJEmpresa.Text);
            cmd.Parameters.AddWithValue("@IE", TxtIEEmpresa.Text);
            cmd.Parameters.AddWithValue("@endereco", TxtEnderecoEmpresa.Text);
            cmd.Parameters.AddWithValue("@descricao", TxtDescricaoEmpresa.Text);
            //seta o valor apra inserção da procedure


            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                telacadastro.Atualiza_Lista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void Edita_Fornecedor()
        {
            if (cbkEmpresa.Checked)
            {
                //editaFornecedorEmpresa();
            }
            else
            {
                // CriaFornecedor();
            }
        }

        private void pnlEmpresa_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}