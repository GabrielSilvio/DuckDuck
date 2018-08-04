using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class FornecedorCRUD : Form
    {
        public FornecedorCRUD()
        {
            InitializeComponent();

            Conexao_fornecedor();

        }


        public void Conexao_fornecedor()
        {
            lblMensagem.Visible = false;

            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Retorna_Dados_Fornecedor", con);
            cmd.Parameters.AddWithValue("@nome", lblPesq.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                SqlDataReader i = cmd.ExecuteReader();
                int contador = 0;
                while (i.Read())
                {
                    GridTotal.Rows.Add(i[0], i[1], i[2], i[3], i[4]);

                    this.GridTotal.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(62, 120, 132);
                    this.GridTotal.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    this.GridTotal.EnableHeadersVisualStyles = false;
                    this.GridTotal.RowsDefaultCellStyle.BackColor = Color.Bisque;
                    this.GridTotal.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                    contador++;

                }
                lblContador.Text = contador.ToString() + " Registros";
            }
            catch (Exception ex)
            {
               lblMensagem.Visible = true;
               lblMensagem.Text=("DADOS NÃO ENCONTRADOS POR FAVOR VERIFIQUE O NOME DIGITADO");
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarFornecedor cadastrar = new CadastrarFornecedor(this);
            cadastrar.ShowDialog();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void label4_Click(object sender, EventArgs e)
        {
            PnlPesquisa.Visible = true;
        }

      

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PnlPesquisa.Visible = false;
            lbluser.Visible = true;

        }


        private void lblPesq_TextChanged(object sender, EventArgs e)
        {
            Atualiza_Lista();
        }
        public void Atualiza_Lista()
        {
            GridTotal.Rows.Clear();
            Conexao_fornecedor();
        }
        public int codigo = -100;
        private void GridTotal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow dados = GridTotal.Rows[e.RowIndex];
            codigo = (int)dados.Cells[0].Value;
           
        }
        void Edita_cadastro()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Exclui_Login", con);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro excluido com sucesso");
                Atualiza_Lista();
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

        private void ExportToExcel()
        {
            var sb = new StringBuilder();

            var headers = GridTotal.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(";", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in GridTotal.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(";", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
            }
            var fs = File.Open("data.csv", FileMode.OpenOrCreate, FileAccess.Write);
            var sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(sb.ToString());
            sw.Close();
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.ErrorDialog = false;
                //Faz o programa não fechar
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;

                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C start data.csv > nul";
                process.StartInfo = startInfo;
                process.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void Excluir_cadastro()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Exclui_Login", con);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro excluido com sucesso");
                Atualiza_Lista();
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            Excluir_cadastro();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (codigo != -100)
            { 
                EditarFornecedor form2 = new EditarFornecedor(this, codigo);
                form2.ShowDialog();
            }
        }

        private void FornecedorCRUD_SizeChanged(object sender, EventArgs e)
        {
            GridTotal.Columns[0].Width = this.Size.Width / 2;
        }

        private void GridTotal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}