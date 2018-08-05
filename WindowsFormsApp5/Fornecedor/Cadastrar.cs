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
    public partial class CadastrarFornecedor : Form
    {
        FornecedorCRUD telacadastro;

        public CadastrarFornecedor(FornecedorCRUD telacadastro)
        {
            InitializeComponent();
            this.telacadastro = telacadastro;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
            {
                CriaFornecedor();
                telacadastro.Atualiza_Lista();
            }

        private void CriaFornecedor()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Cria_Fornecedor", con);
            cmd.Parameters.AddWithValue("@nome",  TxtNome.Text);
            cmd.Parameters.AddWithValue("@telefone", TxtTelefone.Text);
            cmd.Parameters.AddWithValue("@email", TxtEmail.Text);
            cmd.Parameters.AddWithValue("@descricao", TxtDescricao.Text);
            //seta o valor apra inserção da procedure
            
            
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
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

        private void Cadastrar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.t_Cargo'. Você pode movê-la ou removê-la conforme necessário.
            this.t_CargoTableAdapter.Fill(this.duck_DuckDataSet1.t_Cargo);
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.t_login'. Você pode movê-la ou removê-la conforme necessário.
            this.t_loginTableAdapter.Fill(this.duck_DuckDataSet1.t_login);

        }
    }
}
