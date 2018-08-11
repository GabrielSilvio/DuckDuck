using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class FrmPri : Form
    {

        public FrmPri(string text)
        {
            InitializeComponent();

            LblUser.Text =  text;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void BtnEstoque_Click(object sender, EventArgs e)
        {

        }

     

        private void LblUser_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void FrmPri_Load(object sender, EventArgs e)
        {

        }

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

        private void lblSair_Click(object sender, EventArgs e)
        {
            
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GridTotal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
