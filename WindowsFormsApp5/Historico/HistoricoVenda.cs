using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class HistoricoVenda : Form
    {
        public DateTime InicioDia;
        public DateTime FinalDia;
        public int Usuario, Produto;
        public HistoricoVenda(DateTime inicioDia, DateTime finalDia, int usuario,int produto)
        {
            InitializeComponent();
            this.InicioDia = inicioDia;
            this.FinalDia = finalDia;
            this.Usuario = usuario;
            this.Produto = produto;
            Retorna_HistoricoVenda();
        }
        private void BtnFil_Click(object sender, EventArgs e)
        {
            this.Close();
            FiltroVendas filtro = new FiltroVendas();
            filtro.ShowDialog();  
        }

        private void GridHisVen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExc_Click(object sender, EventArgs e)
        {

        }

        public void Retorna_HistoricoVenda()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Retorna_Historico_Vendas", con);
            cmd.Parameters.AddWithValue("@datainicial", InicioDia);
            cmd.Parameters.AddWithValue("@datafinal", FinalDia);
            cmd.Parameters.AddWithValue("@cUsuario", Usuario);
            cmd.Parameters.AddWithValue("@cProduto", Produto);
            //Pinta o grid
            this.GridHisVen.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(62, 120, 132);
            this.GridHisVen.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.GridHisVen.EnableHeadersVisualStyles = false;
            this.GridHisVen.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.GridHisVen.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                SqlDataReader i = cmd.ExecuteReader();
                int contador = 0;
                while (i.Read())
                {
                    GridHisVen.Rows.Add(i[0], i[1], i[2], i[3]);
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
    }
}
 
