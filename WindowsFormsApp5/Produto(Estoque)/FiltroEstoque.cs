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

        public FiltroEstoque(ProdutoCRUD TelaFiltroEstoque, int EstoqueBaixoInicial, int EstoqueBaixoFinal, int EstoqueRegularInicial, int EstoqueRegularFinal)
        {
            InitializeComponent();
            this.EstoqueBaixoInicial = EstoqueBaixoInicial;
            this.EstoqueBaixoFinal = EstoqueBaixoFinal;
            this.EstoqueRegularInicial = EstoqueRegularInicial;
            this.EstoqueRegularFinal = EstoqueRegularFinal;
        }
        private void QuantidadeEstoque()
        {
            //conexão com o Sql Server
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("S_retorna_dados_cor", con); //procedure
            //seta o valor para inserção da procedure
            cmd.Parameters.AddWithValue("@estBaiInicial", NudBaixaInicial.Text);
            cmd.Parameters.AddWithValue("@estBaiFinal", NudBaixaFinal.Text);
            cmd.Parameters.AddWithValue("@estRegInicial", NudRegularInicial.Text);
            cmd.Parameters.AddWithValue("@estRegFinal", NudRegularFinal.Text);

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
            }
        }

        private void NudBaixaFinal_ValueChanged(object sender, EventArgs e)
        {
            NudRegularInicial.Value = NudBaixaFinal.Value;
        }

        private void NudRegularInicial_ValueChanged(object sender, EventArgs e)
        {
            NudBaixaFinal.Value = NudRegularInicial.Value;
        }

        private void FiltroEstoque_Load(object sender, EventArgs e)
        {
            EstoqueBaixoInicial = (int)NudBaixaInicial.Value;
            EstoqueBaixoFinal = (int)NudBaixaFinal.Value;
            EstoqueRegularInicial = (int)NudRegularInicial.Value;
            EstoqueRegularFinal = (int)NudRegularFinal.Value;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
