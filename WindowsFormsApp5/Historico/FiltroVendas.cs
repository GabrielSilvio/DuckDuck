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
    public partial class FiltroVendas : Form
    {
        public FiltroVendas()
        {
            InitializeComponent();
        }
        DateTime FinalDia;
        DateTime InicioDia;
        DateTime DiaMesMensalInicial;
        DateTime DiaMesMensalFinal;
        public decimal MesMensal;
        public int AnoMensal;
        public decimal Anual;
        public DateTime data;
        DateTime AnualInicial;
        DateTime AnualFinal;
 
        private void Verificar()
        {
            if (DateDiarioInicial.Value > DateDiarioFinal.Value)
            {
                MessageBox.Show("Corrija os dados informados!");
            }
        }
        public void VerificarDados()
        {
            if (ChkDiario.Checked == true)
            {
                InicioDia = DateDiarioInicial.Value;
                FinalDia = DateDiarioFinal.Value;
                FinalDia = FinalDia.AddDays(+1);
                FinalDia = FinalDia.AddSeconds(-1);
                Verificar();
            }
            else if (ChkMensal.Checked == true)
            {
                MesMensal = CboMen.SelectedIndex + 1;
                AnoMensal = Convert.ToInt32(NudMensal.Value);
                DiaMesMensalInicial = new DateTime((int)AnoMensal, (int)MesMensal, 1);
                MessageBox.Show(DiaMesMensalInicial.ToString());
                DiaMesMensalFinal = new DateTime((int)AnoMensal, (int)MesMensal, DateTime.DaysInMonth(DiaMesMensalInicial.Year, DiaMesMensalInicial.Month), 23, 59, 59);
                MessageBox.Show(DiaMesMensalFinal.ToString());
            }
            else if (ChkAnual.Checked == true)
            {
                Anual = Convert.ToInt32(NudMensal.Value);
                AnualInicial = new DateTime((int)Anual, 1, 1, 0, 0, 0);
                MessageBox.Show(AnualInicial.ToString());
                AnualFinal   = new DateTime((int)Anual, 12, DateTime.DaysInMonth(DiaMesMensalInicial.Year, DiaMesMensalInicial.Month), 23, 59, 59);
                MessageBox.Show(AnualFinal.ToString());
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnConfirmar_Click_1(object sender, EventArgs e)
        {
            VerificarDados();
            HistoricoVenda historico = new HistoricoVenda(InicioDia,FinalDia,(int)CboVen.SelectedValue,(int)CboPro.SelectedValue);
            historico.ShowDialog();
        }
        private void ChkDiario_CheckedChanged(object sender, EventArgs e)
        {
            ChkMensal.Checked = false;
            ChkAnual.Checked = false;
            PnlDia.Visible = true;
            PnlMen.Visible = false;
            PnlAnu.Visible = false;
        }
        private void ChkMensal_CheckedChanged(object sender, EventArgs e)
        {
            ChkDiario.Checked = false;
            ChkAnual.Checked = false;
            PnlDia.Visible = false;
            PnlMen.Visible = true;
            PnlAnu.Visible = false;
        }
        private void ChkAnual_CheckedChanged(object sender, EventArgs e)
        {
            ChkDiario.Checked = false;
            ChkMensal.Checked = false;
            PnlDia.Visible = false;
            PnlMen.Visible = false;
            PnlAnu.Visible = true;
        }
        private void FiltroVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.t_login'. Você pode movê-la ou removê-la conforme necessário.
            this.t_loginTableAdapter1.Fill(this.duck_DuckDataSet1.t_login);
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.t_Login'. Você pode movê-la ou removê-la conforme necessário.
            this.t_LoginTableAdapter.Fill(this.duck_DuckDataSet1.t_Login);
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.t_Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.t_ProdutoTableAdapter.Fill(this.duck_DuckDataSet1.t_Produto);
        }
    }
}