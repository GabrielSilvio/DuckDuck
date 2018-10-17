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
    public partial class InsercaoProduto : Form
    {

        public ProdutoCRUD telaInsercao;
        public int QuantidadeAdd, QuantidadeEstoque, QuantidadeFinal;
        public int codigo;

        public InsercaoProduto()
        {
            InitializeComponent();
        }

        private void CriaInsercao()
        {
            //conexão com o Sql Server
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Insere_Produto", con); //procedure
            //seta o valor para inserção da procedure
            cmd.Parameters.AddWithValue("@usuario      ",""                               );
            cmd.Parameters.AddWithValue("@codigo       ", TxtCodigo.Text                  );
            cmd.Parameters.AddWithValue("@nome         ", TxtNome.Text                    );
            cmd.Parameters.AddWithValue("@quantidade   ", NudQuandidadeEstoque.Text       );
            cmd.Parameters.AddWithValue("@cFornecedor  ", (int)CbxFornecedor.SelectedValue);
            cmd.Parameters.AddWithValue("@validade     ", DtmValidade.Value               );
            cmd.Parameters.AddWithValue("@fabricacao   ", DtmFabricacao.Value             );
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                telaInsercao.Atualiza_Lista();
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CriaInsercao();
        }

        private void InsercaoProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.t_Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.t_FornecedorTableAdapter.Fill(this.duck_DuckDataSet1.t_Fornecedor);

        }
        public void Busca_Produto()
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
                    TxtNome.Text              = i["nome             "].ToString();
                    NudQuandidadeEstoque.Text = i["quantidade       "].ToString();
                    CbxFornecedor.Text        = i["fornecedor       "].ToString();
                    DtmFabricacao.Text        = i["fabricacao       "].ToString();
                    DtmValidade.Text          = i["validade         "].ToString();
                    TxtPrecoFornecedor.Text   = i["precoFornecedor  "].ToString();
                    TxtDetalhes.Text          = i["detalhes         "].ToString();
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busca_Produto();
        }

        private void NudQuantidadeAdd_ValueChanged_1(object sender, EventArgs e)
        {
            QuantidadeEstoque = (int)NudQuandidadeEstoque.Value;
            QuantidadeAdd = (int)NudQuantidadeAdd.Value;

            QuantidadeFinal = QuantidadeEstoque + QuantidadeAdd;
            TxtQuantidadeFinal.Text = QuantidadeFinal.ToString();
        }
    }
}