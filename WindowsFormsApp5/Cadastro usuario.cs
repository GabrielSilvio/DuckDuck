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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Conexao_user();

        }


        public void Conexao_user()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Retorna_Login", con);
            cmd.Parameters.AddWithValue("@nome", lblPesq.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                SqlDataReader i = cmd.ExecuteReader();
                int contador = 0;
                while (i.Read())
                {
                    GridTotal.Rows.Add(i[0], i[1], i[2], i[4], i[5]);

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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar(this);
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
            Conexao_user();
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
                Form2 form2 = new Form2(this, codigo);
                form2.ShowDialog();
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            GridTotal.Columns[0].Width = this.Size.Width / 2;
        }

        private void GridTotal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



      