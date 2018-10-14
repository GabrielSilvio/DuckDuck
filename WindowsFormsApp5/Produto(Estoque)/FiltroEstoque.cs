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
    public partial class FiltroEstoque : Form
    {
        public ProdutoCRUD TelaFiltroEstoque;
        public int EstoqueBaixoInicial, EstoqueBaixoFinal, EstoqueRegularInicial, EstoqueRegularFinal;
        public string cor;

        public FiltroEstoque(ProdutoCRUD TelaFiltroEstoque, int EstoqueBaixoInicial, int EstoqueBaixoFinal, int EstoqueRegularInicial, int EstoqueRegularFinal)
        {
            InitializeComponent();
            Retorna_Informações();
            this.EstoqueBaixoInicial = EstoqueBaixoInicial;
            this.EstoqueBaixoFinal = EstoqueBaixoFinal;
            this.EstoqueRegularInicial = EstoqueRegularInicial;
            this.EstoqueRegularFinal = EstoqueRegularFinal;
        }

        private void AtualizaVermelho()
        {
            //conexão com o Sql Server
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Edita_Dados_Cor", con); //procedure
            //seta o valor para inserção da procedure
            cmd.Parameters.AddWithValue("@nome", "vermelho");
            cmd.Parameters.AddWithValue("@quantidadeInicial", TxtBaixaInicial.Text);
            cmd.Parameters.AddWithValue("@QuantidadeFinal", TxtBaixaFinal.Text);

            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                TelaFiltroEstoque.Atualiza_Lista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                TelaFiltroEstoque.Atualiza_Lista();
            }
        }
     
        private void AtualizaAmarelo()
        {
            //conexão com o Sql Server
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Edita_Dados_Cor", con); //procedure
            //seta o valor para inserção da procedure
            cmd.Parameters.AddWithValue("@nome", "amarelo");
            cmd.Parameters.AddWithValue("@quantidadeInicial", TxtRegularInicial.Text);
            cmd.Parameters.AddWithValue("@QuantidadeFinal", TxtRegularFinal.Text);

            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                TelaFiltroEstoque.Atualiza_Lista();
            }
        }
        public void Retorna_Informações()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Retorna_Dados_Cor", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                SqlDataReader i = cmd.ExecuteReader();
                if (i.Read())
                {
                    cor = (string)i["nome"];

                    if (cor == "vermelho")
                    {
                        TxtBaixaInicial.Text = i["quantidadeInicial"].ToString();
                        TxtBaixaFinal.Text = i["QuantidadeFinall"].ToString();
                    }
                    if (cor == "amarelo")
                    {
                        TxtRegularInicial.Text = i["quantidadeInicial"].ToString();
                        TxtRegularFinal.Text = i["QuantidadeFinall"].ToString();
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

        private void Verificar()
        {
            if (EstoqueRegularInicial > EstoqueRegularFinal)
            {
                MessageBox.Show("Corrija os valores inseridos");
            }

        }

        private void NudBaixaFinal_ValueChanged(object sender, EventArgs e)
        {
            TxtRegularInicial.Text = TxtBaixaFinal.Text;
        }

        private void NudRegularInicial_ValueChanged(object sender, EventArgs e)
        {
            TxtBaixaFinal.Text = TxtRegularInicial.Text;
        }

        private void FiltroEstoque_Load(object sender, EventArgs e)
        {
            EstoqueBaixoInicial = int.Parse(TxtBaixaInicial.Text);
            EstoqueBaixoFinal = int.Parse(TxtBaixaFinal.Text);
            EstoqueRegularInicial = int.Parse(TxtRegularInicial.Text);
            EstoqueRegularFinal = int.Parse(TxtRegularFinal.Text);

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            Verificar       ();
            AtualizaVermelho();
            AtualizaAmarelo ();
            
        }
    }
}
