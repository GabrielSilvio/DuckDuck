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
using System.Web.UI.WebControls;
namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        public int codigo;
        public Form2(Form1 telacadastro)   
        {
            InitializeComponent();
            this.telacadastro = telacadastro;
            Retorna_Informações();
        }
        Form1 telacadastro;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void Retorna_Informações()
        {
            int row = ((int)CbxCargo.SelectedValue);
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Retorna_Dados_Usuario", con);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                
                SqlDataReader i = cmd.ExecuteReader();
                while (i.Read())
                {
                    cmd.Parameters.AddWithValue("@nome"  ,TxtNome.Text);
                    cmd.Parameters.AddWithValue("@login" ,TxtLogin.Text);
                    cmd.Parameters.AddWithValue("@email" ,TxtSenha.Text);
                    cmd.Parameters.AddWithValue("@senha" ,TxtSenha.Text);
                    cmd.Parameters.AddWithValue("@Ccargo",row);
                    //teste
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

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.t_Cargo'. Você pode movê-la ou removê-la conforme necessário.
            this.t_CargoTableAdapter.Fill(this.duck_DuckDataSet1.t_Cargo);

        }
        public void Edita_login()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand    cmd = new SqlCommand("s_edita_Login", con);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Parameters.AddWithValue("@login" , TxtLogin.Text);
            cmd.Parameters.AddWithValue("@nome"  , TxtNome.Text);
            cmd.Parameters.AddWithValue("@email" , TxtEmail.Text);
            cmd.Parameters.AddWithValue("@cCargo", CbxCargo.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro editado com sucesso");
                telacadastro.Atualiza_Lista();



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


