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
        public int PreçoTotal, PorcentagemImposto, PorcentagemLucro,PreçoFornecedor,PreçoProduto;
        public int imposto;
        public int lucro    ;

        public CadastrarProduto(ProdutoCRUD telacadastro)
        {
            InitializeComponent();
            this.telacadastro = telacadastro;
        }

        private void CriaProduto()
        {
            //conexão com o Sql Server
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Cria_Produto", con); //procedure
            //seta o valor para inserção da procedure
            cmd.Parameters.AddWithValue("@nome", TxtNome.Text);
            cmd.Parameters.AddWithValue("@detalhes", TxtDetalhes.Text);
            cmd.Parameters.AddWithValue("@quantidade", TxtQuantidade.Text);
            cmd.Parameters.AddWithValue("@preco", TxtPorcentagemImposto.Text);
            cmd.Parameters.AddWithValue("@precoFonecedor", TxtPrecoFornecedor.Text);
            cmd.Parameters.AddWithValue("@cFornecedor", (int)CbxForncedor.SelectedValue);
            cmd.Parameters.AddWithValue("@validade", DtmValidade.Text);
            cmd.Parameters.AddWithValue("@fabricacao", DtmFabricacao.Text);
            cmd.Parameters.AddWithValue("@imposto", TxtPorcentagemImposto.Text);
            cmd.Parameters.AddWithValue("@lucro", TxtPorcentagemLucro.Text);
            cmd.Parameters.AddWithValue("@precoTotal", TxtPrecoTotal.Text);
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
            TxtPorcentagemImposto.Clear();
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkValidade.Checked)
            {
                PnlValidade.Visible = false;
            }
            else
                PnlValidade.Visible = true;
        }
        public void CalcularPreçoTotal(){
            PreçoFornecedor = (int.Parse(TxtPrecoFornecedor.Text));
            PorcentagemImposto = (int.Parse(TxtPorcentagemImposto.Text));
            PorcentagemLucro = (int.Parse(TxtPorcentagemLucro.Text));

            PreçoProduto = (PreçoFornecedor + (PreçoFornecedor * PorcentagemImposto));
            PreçoTotal = ((PreçoProduto * PorcentagemLucro) / 100);
            PreçoTotal = (int.Parse(TxtPrecoTotal.Text));
        }

        private void TxtPorcentagemImposto_TextChanged(object sender, EventArgs e)
        {
            //TxtPorcentagemImposto.Text + "%";
        }

        private void TxtPorcentagemLucro_TextChanged(object sender, EventArgs e)
        {
            //TxtPorcentagemLucro.Text = TxtPorcentagemLucro.Text + "%";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CriaProduto();
            CalcularPreçoTotal();
            telacadastro.Atualiza_Lista();
            Limpatela();

            imposto = (int.Parse(TxtPorcentagemImposto.Text));
            TxtPorcentagemImposto.Text = imposto.ToString();
            lucro = (int.Parse(TxtPorcentagemLucro.Text));
            TxtPorcentagemLucro.Text = lucro.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
