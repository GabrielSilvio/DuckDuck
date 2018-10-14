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
        public int precoFornecedor, porcentagemImposto, porcentagemLucro, precoTotal, precoTotalProduto;
        ProdutoCRUD telacadastro;

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
            cmd.Parameters.AddWithValue("@nome"                 , TxtNome.Text                   );
            cmd.Parameters.AddWithValue("@detalhes"             , TxtDetalhes.Text               );
            cmd.Parameters.AddWithValue("@quantidade"           , TxtQuantidade.Text             );
            cmd.Parameters.AddWithValue("@preco"                , TxtPrecoTotal.Text             );
            cmd.Parameters.AddWithValue("@precoFonecedor"       , TxtPrecoFornecedor.Text        );
            cmd.Parameters.AddWithValue("@cFornecedor"          , (int)CbxForncedor.SelectedValue);
            cmd.Parameters.AddWithValue("@Imposto"              , TxtPorcentagemImposto.Text     );
            cmd.Parameters.AddWithValue("@Lucro"                , TxtPorcentagemLucro.Text       );
            cmd.Parameters.AddWithValue("@validade"             , DtmValidade.Value              );
            cmd.Parameters.AddWithValue("@dataFabricacao"       , DtmFabricacao.Value            );
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

        private void TxtPorcentagemLucro_TextChanged(object sender, EventArgs e)
        {
            if (TxtPorcentagemLucro.Text == "-")
            {
                MessageBox.Show("Nao pode ter numero negativo");
                Limpatela(); 

            }
            if (TxtPorcentagemLucro.Text == " ")
            {
                MessageBox.Show("Nao pode ter espaços");
                Limpatela();
            }

            if (TxtPorcentagemImposto.Text != "" && TxtPorcentagemLucro.Text != "" && TxtPrecoFornecedor.Text != "")
            {
                Double precoFornecedor = int.Parse(TxtPrecoFornecedor.Text);
                Double porcentagemImposto = int.Parse(TxtPrecoFornecedor.Text);
                Double porcentagemLucro = int.Parse(TxtPorcentagemLucro.Text);
                if (porcentagemLucro <= 0)
                {
                    MessageBox.Show("numero nao pode ser menor que 0");
                    Limpatela();
                }

                Double precoImposto = (precoFornecedor * porcentagemImposto) / 100; // EX : precoFonecedor = 10,00 x porcentagemImposto 10 /100 = 100/100 = 1
                Double precoTotal = (precoImposto + precoFornecedor); //EX = precoImposto = 1,00 + 10,00 = 11,00
                Double precoTotalProduto = ((precoTotal * porcentagemLucro) / 100 + precoTotal); //EX precoTotal = 11,00 * porcentagemLucro = 50 /100 + precoTotal = 11,00 || 5,50 + 11,00 = 16,50
                TxtPrecoTotal.Text = String.Format("{0:0.00}", precoTotalProduto);


                if (precoTotalProduto < precoFornecedor)
                {
                    MessageBox.Show("o preço total nao pode ser menor que o preço do fornecedor");
                    Limpatela();
                }
            }
            else
            {
                return;
            }
        }

        private void ChkQuantidade_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkQuantidade.Checked)
            {
                TxtMontante.Visible = true;
                LblMontante.Visible = true;
                TxtQuantidadeTotal.Visible = true;
                LblQuantidadeTotal.Visible = true;
            }
            else
            {
                TxtMontante.Visible = false;
                LblMontante.Visible = false;
                TxtQuantidadeTotal.Visible = false;
                LblQuantidadeTotal.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtMontante_TextChanged(object sender, EventArgs e)
        {
            if (TxtMontante.Text != "" && TxtQuantidade.Text != "")
            {
                int quantidade = int.Parse(TxtQuantidade.Text);
                int montante = int.Parse(TxtMontante.Text);
                int quantidadeTotal = (quantidade * montante);

                TxtQuantidadeTotal.Text = quantidadeTotal.ToString();
            }
            else
            {
                return;
            }
        }

        private void TxtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (TxtMontante.Text != "" && TxtQuantidade.Text != "")
            {
                int quantidade = int.Parse(TxtQuantidade.Text);
                int montante = int.Parse(TxtMontante.Text);
                int quantidadeTotal = (quantidade * montante);

                TxtQuantidadeTotal.Text = quantidadeTotal.ToString();
            }
            else
            {
                return;
            }
        }

        private void TxtPrecoFornecedor_TextChanged(object sender, EventArgs e)
        {
            if (TxtPorcentagemImposto.Text != "" && TxtPorcentagemLucro.Text != "" && TxtPrecoFornecedor.Text != "")
            {
                int precoFornecedor = int.Parse(TxtPrecoFornecedor.Text);
                int porcentagemImposto = int.Parse(TxtPrecoFornecedor.Text);
                int porcentagemLucro = int.Parse(TxtPorcentagemLucro.Text);

                int precoTotal = ((precoFornecedor * porcentagemImposto) / 100 + precoFornecedor);
                int precoTotalProduto = ((precoTotal * porcentagemLucro) / 100 + precoTotal);
                TxtPrecoTotal.Text = precoTotalProduto.ToString();
            }
            else
            {
                return;
            }
        }

        private void TxtPorcentagemImposto_TextChanged(object sender, EventArgs e)
        {
            if (TxtPorcentagemImposto.Text != "" && TxtPorcentagemLucro.Text != "" && TxtPrecoFornecedor.Text != "")
            {
                int precoFornecedor = int.Parse(TxtPrecoFornecedor.Text);
                int porcentagemImposto = int.Parse(TxtPrecoFornecedor.Text);
                int porcentagemLucro = int.Parse(TxtPorcentagemLucro.Text);

                int precoTotal = ((precoFornecedor * porcentagemImposto) / 100 + precoFornecedor);
                int precoTotalProduto = ((precoTotal * porcentagemLucro) / 100 + precoTotal);
                TxtPrecoTotal.Text = precoTotalProduto.ToString();
            }
            else
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CalcularPrecoTotal();
            CriaProduto();
            Limpatela();
        }

        private void Limpatela()
        {
            TxtDetalhes.Clear          ();
            TxtNome.Clear              ();
            TxtPrecoTotal.Clear        ();
            TxtPrecoFornecedor.Clear   ();
            TxtQuantidade.Clear        ();
            TxtPorcentagemLucro.Clear  ();
            TxtPorcentagemImposto.Clear();
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {
            TxtMontante.Visible = false;
            LblMontante.Visible = false;
            TxtQuantidadeTotal.Visible = false;
            LblQuantidadeTotal.Visible = false;
            PnlValidade.Visible = false;
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet11.t_Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.t_FornecedorTableAdapter.Fill(this.duck_DuckDataSet11.t_Fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.t_Cargo'. Você pode movê-la ou removê-la conforme necessário.
            this.t_CargoTableAdapter.Fill(this.duck_DuckDataSet1.t_Cargo);
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.t_login'. Você pode movê-la ou removê-la conforme necessário.
            this.t_loginTableAdapter.Fill(this.duck_DuckDataSet1.t_login);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkValidade.Checked)
            {
                PnlValidade.Visible = true;
            }
            else
            {
                PnlValidade.Visible = false;
            }
        }
    }
}