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
            SqlCommand cmd = new SqlCommand("s_Retorna_Dados_Forcenador", con);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                SqlDataReader i = cmd.ExecuteReader();
                if (i.Read())
                {
                    TxtNome.Text  = i["nome"].ToString();
                    TxtTelefone.Text = i["telefone"].ToString();
                    TxtDescricao.Text = i["descricao"].ToString();
                    TxtEmail.Text = i["email"].ToString();
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
        public void Edita_Fornecedor()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand    cmd = new SqlCommand("s_Edita_Dados_Fornecedor", con);
            cmd.Parameters.AddWithValue("@nome", TxtNome.Text);
            cmd.Parameters.AddWithValue("@telefone" , TxtTelefone.Text);
            cmd.Parameters.AddWithValue("@email"  , TxtEmail.Text);
            cmd.Parameters.AddWithValue("@descricao" , TxtDescricao.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro editado com sucesso");
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
    }
}