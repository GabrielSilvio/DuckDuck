using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Form1 user = new Form1();
            user.ShowDialog();
        }
    }
}
