using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp5.Forms_Principais.Carrinho;

namespace WindowsFormsApp5
{
    public partial class FrmPri : Form
    {
        public string loginUsuario;
        public FrmPri(string text)
        {
            InitializeComponent();          
            loginUsuario = text;
            LblUser.Text = loginUsuario;
            RetornaCodigoLogin();
            Retorna_Produto();
            Retorna_Carrinho();
        }
        public int CodigoUsuario;
        private void LblUser_MouseMove(object sender, MouseEventArgs e)
        {
            LblUser.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3E7884");

        }

        private void LblUser_MouseLeave(object sender, EventArgs e)
        {
            LblUser.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UsuarioCRUD user = new UsuarioCRUD();
            user.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FornecedorCRUD fornecedor = new FornecedorCRUD();
            fornecedor.ShowDialog();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string message = "Você realmente deseja sair?";
            string caption = "Confirmação";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Mensagem se deseja realmente sair.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnEstoque_Click_1(object sender, EventArgs e)
        {
            ProdutoCRUD produto = new ProdutoCRUD();
            produto.ShowDialog();
        }

        private void GridProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        public int codigoCarrinho = -100;
        private void GridCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GridProduto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (codigoCarrinho != -100)
            {
                //
                editacarrinho formcarrinho = new editacarrinho(this, codigoCarrinho);
                formcarrinho.Show();
            }
            else
                MessageBox.Show("selecione um objeto");
        }
        public void Retorna_Produto()
        { 
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Retorna_Produto", con);
            cmd.Parameters.AddWithValue("@nome", lblPesq.Text);
            cmd.Parameters.AddWithValue("@fornecedor", "");
            //Pinta o grid
            this.GridProduto.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(62, 120, 132);
            this.GridProduto.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.GridProduto.EnableHeadersVisualStyles = false;
            this.GridProduto.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.GridProduto.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                SqlDataReader i = cmd.ExecuteReader();
                int contador = 0;
                while (i.Read())
                {
                    GridProduto.Rows.Add(i[0], i[1], i[2], i[3], i[4]);
                    string valortotal = i[5].ToString(); //quantidade 
                    contador++;
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
        public int total;
        public void Retorna_Carrinho()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Retorna_Dados_Carrinho", con);
            cmd.Parameters.AddWithValue("@cLogin", CodigoUsuario);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                this.GridCarrinho.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(62, 120, 132);
                this.GridCarrinho.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                this.GridCarrinho.EnableHeadersVisualStyles = false;
                this.GridCarrinho.RowsDefaultCellStyle.BackColor = Color.Bisque;
                this.GridCarrinho.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                SqlDataReader i = cmd.ExecuteReader();
                int contador = 0;
                while (i.Read())
                {
                    GridCarrinho.Rows.Add(i[0], i[1], i[2], i[3], i[4], i[5]);
                    contador++;
                }

                lblTotal.Text = total.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            FiltroVendas filtro = new FiltroVendas();
            filtro.ShowDialog();
        }

        private void lblPesq_TextChanged(object sender, EventArgs e)
        {
            GridProduto.Rows.Clear();
            Retorna_Produto();
        }

        private void GridProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Quantidade quantidade = new Quantidade(this);
            quantidade.ShowDialog();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            string message = "Você realmente deseja Excluir esse registro ?";
            string caption = "Confirmação";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Mensagem se deseja realmente sair.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Excluir_Carrinho();
            }
           
        }

        void Excluir_Carrinho()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Exclui_Carrinho", con);
            cmd.Parameters.AddWithValue("@codigo", codigoCarrinho);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show("Item excluido com sucesso");
                GridCarrinho.Rows.Clear();
                Retorna_Carrinho();
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



        void Finalizar_Carrinho()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Finaliza_Carrinho", con);
            cmd.Parameters.AddWithValue("@dataVenda"     , DateTime.Now);
            cmd.Parameters.AddWithValue("@cUsuario"  ,CodigoUsuario);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show("Compra finalizada com Sucesso");
                GridCarrinho.Rows.Clear();
                Retorna_Carrinho();
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
        private void BtnFinal_Click(object sender, EventArgs e)
        {

            Finalizar_Carrinho();
            GridProduto.Rows.Clear();
            Retorna_Produto();
            
        }

        private void LblUser_Click(object sender, EventArgs e)
        {

        }
        public int codigoProduto = -100;
        private void GridProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow dadosProduto = GridProduto.Rows[e.RowIndex];
            codigoProduto = (int)dadosProduto.Cells[0].Value;
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
        public void RetornaCodigoLogin()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Retorna_Codigo_Usuario", con);
            cmd.Parameters.AddWithValue("@loginUsuario", loginUsuario);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                SqlDataReader i = cmd.ExecuteReader();
                while (i.Read())
                {
                    CodigoUsuario = ((int)i[0]);
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

        private void GridCarrinho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow dadosCarrinho = GridCarrinho.Rows[e.RowIndex];
            codigoCarrinho = (int)dadosCarrinho.Cells[0].Value;
        }
    }
}
