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
        public Form2(Form1 telacadastro,int codigo)   
        {
            InitializeComponent();
            this.telacadastro = telacadastro;
            this.codigo = codigo;
            Retorna_Informações();
        }
        Form1 telacadastro;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edita_login();
        }
        public void Retorna_Informações()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Retorna_Dados_Usuario", con);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                SqlDataReader i = cmd.ExecuteReader();
                if (i.Read())
                {
                    TxtNome.Text  = i["nome"].ToString();
                    TxtLogin.Text = i["login"].ToString();
                    TxtSenha.Text = i["senha"].ToString();
                    TxtSenhaConf.Text = TxtSenha.Text;
                    TxtEmail.Text = i["email"].ToString();
                    CbxCargo.Text = i["cargo"].ToString();
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
            int cCargo = ((int)CbxCargo.SelectedValue);
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand    cmd = new SqlCommand("s_edita_Login", con);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Parameters.AddWithValue("@login" , TxtLogin.Text);
            cmd.Parameters.AddWithValue("@nome"  , TxtNome.Text);
            cmd.Parameters.AddWithValue("@email" , TxtEmail.Text);
            cmd.Parameters.AddWithValue("@cCargo", cCargo);
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


