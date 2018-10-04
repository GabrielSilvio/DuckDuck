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

namespace WindowsFormsApp5.Forms_Principais.Carrinho
{
    public partial class editacarrinho : Form
    {
        public int codigoCarrinho;
        private FrmPri carrinho;
        public editacarrinho(FrmPri carrinho, int codigoCarrinho)
        {
            InitializeComponent();
            this.carrinho = carrinho;
            this.codigoCarrinho = codigoCarrinho;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Edita_Dados_Carrinho", con);
            cmd.Parameters.AddWithValue("@codigo", codigoCarrinho);
            cmd.Parameters.AddWithValue("@quantidade", dmpQuantidade.Value);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                SqlDataReader i = cmd.ExecuteReader();
                while (i.Read())
                {
                    MessageBox.Show("Quantidade alterada com sucesso");
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                carrinho.GridCarrinho.Rows.Clear();
                carrinho.Retorna_Carrinho();
                this.Close();
            }
        }
        private void RetornaQuantidade()
        {

            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Edita_Dados_Carrinho", con);
            cmd.Parameters.AddWithValue("@codigo", codigoCarrinho);
            cmd.Parameters.AddWithValue("@quantidade", dmpQuantidade);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                SqlDataReader i = cmd.ExecuteReader();
                if (i.Read())
                {
                    dmpQuantidade.Text = i["quantidade"].ToString();
                }
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

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
