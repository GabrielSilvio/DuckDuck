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
            desabilitaPanel();
            Atualiza_datas();
            VerificarDados();
        }
        DateTime FinalDia;
        DateTime InicioDia;
        DateTime DiaMesMensalInicial;
        DateTime DiaMesMensalFinal;
        public decimal MesMensal;
        public int AnoMensal;
        public decimal Anual;
        public DateTime data;

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
                Verificar();
                InicioDia = DateDiarioInicial.Value;
                FinalDia = DateDiarioFinal.Value;
                FinalDia = FinalDia.AddDays(+1);
                FinalDia = FinalDia.AddSeconds(-1);
                
            }
            else if (ChkMensal.Checked == true)
            {
                MesMensal = NudMensal.Value;
                MesMensal = CboMen.SelectedIndex + 1;
                AnoMensal = Convert.ToInt32(NudMensal.Value);
                DiaMesMensalInicial = new DateTime((int)AnoMensal, (int)MesMensal, 1);
                DiaMesMensalFinal = new DateTime((int)AnoMensal, (int)MesMensal, DateTime.DaysInMonth(DiaMesMensalInicial.Year, DiaMesMensalInicial.Month), 23, 59, 59);
            }
            else if (ChkAnual.Checked == true)
            {
                Anual = NudAnual.Value;
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnConfirmar_Click_1(object sender, EventArgs e)
        {
            VerificarDados();
            if ((ChkMensal.Checked == false) && (ChkAnual.Checked == false) && (ChkDiario.Checked == false))
            {
                MessageBox.Show("Marque alguma checkbox");
            }
            else
            { 
            HistoricoVenda historico = new HistoricoVenda(InicioDia,FinalDia, (int)CboVen.SelectedValue,(int)CboPro.SelectedValue);
            historico.ShowDialog();
                this.Close();
            }
        }
        private void ChkDiario_CheckedChanged(object sender, EventArgs e)
        {
            ChkMensal.Checked = false;
            ChkAnual.Checked = false;

            PnlDia.Enabled = true;
            pnlMes.Enabled = false;
            PnlAno.Enabled = false;
        }
        private void ChkMensal_CheckedChanged(object sender, EventArgs e)
        {
            ChkDiario.Checked = false;
            ChkAnual.Checked = false;
            PnlDia.Enabled = false;
            pnlMes.Enabled = true;
            PnlAno.Enabled = false;
        }
        private void ChkAnual_CheckedChanged(object sender, EventArgs e)
        {
            ChkDiario.Checked = false;
            ChkMensal.Checked = false;
            PnlDia.Enabled = false;
            pnlMes.Enabled = false;
            PnlAno.Enabled = true;
        }
        private void FiltroVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.s_Lista_Dados_Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.s_Lista_Dados_ProdutoTableAdapter.Fill(this.duck_DuckDataSet1.s_Lista_Dados_Produto);
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.s_Lista_Dados_Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.s_Lista_Dados_UsuarioTableAdapter.Fill(this.duck_DuckDataSet1.s_Lista_Dados_Usuario);
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.t_login'. Você pode movê-la ou removê-la conforme necessário.
            this.t_loginTableAdapter1.Fill(this.duck_DuckDataSet1.t_login);
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.t_Login'. Você pode movê-la ou removê-la conforme necessário.
            this.t_LoginTableAdapter.Fill(this.duck_DuckDataSet1.t_Login);
            // TODO: esta linha de código carrega dados na tabela 'duck_DuckDataSet1.t_Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.t_ProdutoTableAdapter.Fill(this.duck_DuckDataSet1.t_Produto);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void CboVen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CboPro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PnlDia_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChkDiario_CheckedChanged_1(object sender, EventArgs e)
        {
            PnlDia.Enabled = true;
            pnlMes.Enabled = false;
            PnlAno.Enabled = false;
        }

        private void ChkMensal_CheckedChanged_1(object sender, EventArgs e)
        {
            PnlDia.Enabled = false;
            pnlMes.Enabled = true;
            PnlAno.Enabled = false;

        }

        private void ChkAnual_CheckedChanged_1(object sender, EventArgs e)
        {
            PnlDia.Enabled = false;
            pnlMes.Enabled = false;
            PnlAno.Enabled = true;

        }
        private void Atualiza_datas()
        {
            DateTime diaAtual = DateTime.Now;
            //dia atual
            DateDiarioInicial.Value = new DateTime(diaAtual.Year, diaAtual.Month, diaAtual.Day);
            DateDiarioFinal.Value = new DateTime(diaAtual.Year, diaAtual.Month, diaAtual.Day);
            //mes atual
            CboMen.SelectedIndex = diaAtual.Month -1 ;
            NudMensal.Value = diaAtual.Year;
            //ano atual
            NudAnual.Value = diaAtual.Year;
        }
        private void desabilitaPanel()
        {
            pnlMes.Enabled = false;
            PnlAno.Enabled = false;
        }
            
    }
}