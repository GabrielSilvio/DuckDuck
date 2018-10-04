using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp5
{
    public partial class EditarProduto : Form
    {
        public int codigo;
        public ProdutoCRUD telacadastro;

        public EditarProduto(ProdutoCRUD telacadastro, int codigo)   
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
            Edita_Produto();
            this.Close();
        }
        public void Retorna_Informações()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Retorna_Dados_Produto", con);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                SqlDataReader i = cmd.ExecuteReader();
                if (i.Read())
                {
                    TxtNome.Text            = i["nome"           ].ToString();
                    TxtDetalhes.Text        = i["detalhes"       ].ToString();
                    TxtPreco.Text           = i["preco"          ].ToString();
                    TxtPrecoFornecedor.Text = i["precoFornecedor"].ToString();
                    TxtQuantidade.Text      = i["quantidade"     ].ToString();
                    TxtFornecedor.Text      = i["fornecedor"     ].ToString();
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
            
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.t_Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.t_FornecedorTableAdapter.Fill(this.duck_DuckDataSet1.t_Fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.t_Cargo'. Você pode movê-la ou removê-la conforme necessário.
            this.t_CargoTableAdapter.Fill(this.duck_DuckDataSet1.t_Cargo);

        }
        public void Edita_Produto()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand    cmd = new SqlCommand("s_Edita_Dados_Produto", con);
            cmd.Parameters.AddWithValue("@codigo"			 , codigo);
            cmd.Parameters.AddWithValue("@nome"			     , TxtNome.Text);
            cmd.Parameters.AddWithValue("@detalhes"		     , TxtDetalhes.Text);
            cmd.Parameters.AddWithValue("@quantidade"		 , TxtQuantidade.Text);
            cmd.Parameters.AddWithValue("@preco"			 , TxtPreco.Text);
            cmd.Parameters.AddWithValue("@precoFonercedor"   , TxtPrecoFornecedor.Text);

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
                this.Close();
            }
        }
    }
}