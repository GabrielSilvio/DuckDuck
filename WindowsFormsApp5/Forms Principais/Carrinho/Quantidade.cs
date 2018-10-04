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
    public partial class Quantidade : Form
    {
        public FrmPri formPrincipal;
        public Quantidade(FrmPri formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            formPrincipal.GridCarrinho.Rows.Clear();
            insereCarrinho();
        }
       
        private void insereCarrinho()
        {
             int codigo = formPrincipal.codigoProduto;
        SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Insere_Carrinho", con);
            cmd.Parameters.AddWithValue    ("@codigo", codigo);
            cmd.Parameters.AddWithValue    ("@quantidade", dmpQuantidade.Text);
            cmd.Parameters.AddWithValue    ("@cLogin", formPrincipal.CodigoUsuario);
            //seta o valor para inserção da procedure
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
                formPrincipal.Retorna_Carrinho();
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
