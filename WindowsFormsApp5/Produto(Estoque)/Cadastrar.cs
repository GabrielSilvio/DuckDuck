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
    public partial class CadastrarProduto : Form
    {
        ProdutoCRUD telacadastro;

        public CadastrarProduto(ProdutoCRUD telacadastro)
        {
            InitializeComponent();
            this.telacadastro = telacadastro;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CriaProduto();
            telacadastro.Atualiza_Lista();
            Limpatela();
        }

        private void CriaProduto()
        {
            //conexão com o Sql Server
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Cria_Produto", con); //procedure
            //seta o valor para inserção da procedure
            cmd.Parameters.AddWithValue("@nome"                 , TxtNome.Text);
            cmd.Parameters.AddWithValue("@detalhes"             , TxtDetalhes.Text);
            cmd.Parameters.AddWithValue("@quantidade"           , TxtQuantidade.Text);
            cmd.Parameters.AddWithValue("@preco"                , TxtPrecoTotal.Text);
            cmd.Parameters.AddWithValue("@precoFonecedor"       , TxtPrecoFornecedor.Text);
            cmd.Parameters.AddWithValue("@cFornecedor"          , (int)CbxForncedor.SelectedValue); 
            cmd.Parameters.AddWithValue("@porcentagemImposto"   , TxtPorcentagemImposto.Text);
            cmd.Parameters.AddWithValue("@porcentagemLucro"     , TxtPorcentagemLucro.Text);
            cmd.Parameters.AddWithValue("@validade"             , DtmValidade.Value);
            cmd.Parameters.AddWithValue("@fabricacao", DtmFabricacao.Value);
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
        private void Limpatela()
        {
            TxtDetalhes.Clear();
            TxtNome.Clear();
            TxtPrecoTotal.Clear();
            TxtPrecoFornecedor.Clear();
            TxtQuantidade.Clear();
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet11.t_Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.t_FornecedorTableAdapter.Fill(this.duck_DuckDataSet11.t_Fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.t_Cargo'. Você pode movê-la ou removê-la conforme necessário.
            this.t_CargoTableAdapter.Fill(this.duck_DuckDataSet1.t_Cargo);
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.t_login'. Você pode movê-la ou removê-la conforme necessário.
            this.t_loginTableAdapter.Fill(this.duck_DuckDataSet1.t_login);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkValidade.Checked)
            {
                PnlValidade.Visible = false;
            }
            else
            {
                PnlValidade.Visible = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void CbxForncedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}