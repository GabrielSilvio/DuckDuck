using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp5
{
    public partial class CadastrarFornecedor : Form
    {
        FornecedorCRUD telacadastro;

        public CadastrarFornecedor(FornecedorCRUD telacadastro)
        {
            InitializeComponent();
            this.telacadastro = telacadastro;
            TxtTelefone.GotFocus += TxtTelefone_GotFocus;
            TxtTelefone.LostFocus += TxtTelefone_LostFocus;
            
        }
        public bool FocusedT = false; 

        private void TxtTelefone_LostFocus(object sender, EventArgs e)
        {
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
            {
                testaInsercao();
                telacadastro.Atualiza_Lista();
            }

        private void Limpar() {
            TxtNome.Text = "";
            TxtEmail.Text = "";
            TxtTelefone.Text = "";
            TxtDescricao.Text = "";
        }
        private void CriaFornecedor()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Cria_Fornecedor", con);
            cmd.Parameters.AddWithValue("@empresa"  , 0);
            cmd.Parameters.AddWithValue("@nome"     , TxtNome.Text);
            cmd.Parameters.AddWithValue("@email"    , TxtEmail.Text);
            cmd.Parameters.AddWithValue("@sexo"     , cboSexo.Text);
            cmd.Parameters.AddWithValue("@telefone" , TxtTelefone.Text);
            cmd.Parameters.AddWithValue("@celular"  , TxtCelular.Text);
            cmd.Parameters.AddWithValue("@CEP"      , TxtCEP.Text);
            cmd.Parameters.AddWithValue("@RG"       , TxtRG.Text);
            cmd.Parameters.AddWithValue("@CPF"      , TxtCPF.Text);
            cmd.Parameters.AddWithValue("@CNPJ"     , "");
            cmd.Parameters.AddWithValue("@IE"       , "");
            cmd.Parameters.AddWithValue("@endereco" , TxtEndereco.Text);
            cmd.Parameters.AddWithValue("@descricao", TxtDescricao.Text);
            //seta o valor apra inserção da procedure
            
            
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                telacadastro.Atualiza_Lista();
                Limpar();
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
        private void CriaFornecedorEmpresa()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Cria_Fornecedor", con);
            cmd.Parameters.AddWithValue("@empresa"  , 1);
            cmd.Parameters.AddWithValue("@nome"     , TxtNomeEmpresa.Text);
            cmd.Parameters.AddWithValue("@email"    , TxtEmailEmpresa.Text);
            cmd.Parameters.AddWithValue("@sexo"     , "");
            cmd.Parameters.AddWithValue("@telefone" , TxtTelefoneEmpresa.Text);
            cmd.Parameters.AddWithValue("@celular"  , txtCelularEmrpesa.Text);
            cmd.Parameters.AddWithValue("@CEP"      , TxtCEPEmpresa.Text);
            cmd.Parameters.AddWithValue("@RG"       , "");
            cmd.Parameters.AddWithValue("@CPF"      , "");
            cmd.Parameters.AddWithValue("@CNPJ"     , TxtCNPJEmpresa.Text);
            cmd.Parameters.AddWithValue("@IE"       , TxtIEEmpresa.Text);
            cmd.Parameters.AddWithValue("@endereco" , TxtEnderecoEmpresa.Text);
            cmd.Parameters.AddWithValue("@descricao", TxtDescricaoEmpresa.Text);
            //seta o valor apra inserção da procedure


            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                telacadastro.Atualiza_Lista();
                Limpar();
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
        private void testaInsercao()
        {
            if (cbkEmpresa.Checked)
            {
                CriaFornecedorEmpresa();
                //empresa = 1;
            }
            else
            {
                CriaFornecedor();
                //empresa = 0;
            }
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.t_Cargo'. Você pode movê-la ou removê-la conforme necessário.
            this.t_CargoTableAdapter.Fill(this.duck_DuckDataSet1.t_Cargo);
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.t_login'. Você pode movê-la ou removê-la conforme necessário.
            this.t_loginTableAdapter.Fill(this.duck_DuckDataSet1.t_login);

        }
    private void TxtTelefone_GotFocus(object sender, EventArgs e)
    {
            if (FocusedT==false)
            {
                TxtTelefone.Text = "";
            }
            FocusedT = true;  
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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
    }
}
