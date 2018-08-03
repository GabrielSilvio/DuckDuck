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
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
    

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.Duck_DuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Verifica_Login", con);
            cmd.Parameters.AddWithValue("@login", TxtLogin.Text);
            cmd.Parameters.AddWithValue("@senha", TxtSenha.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show("Login atutenticado com sucesso!"); 
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

        private void lblPrincipal_Click(object sender, EventArgs e)
        {
        }
    }
}
