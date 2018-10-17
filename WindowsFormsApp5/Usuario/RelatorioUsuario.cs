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

namespace WindowsFormsApp5.Usuario
{
    public partial class RelatorioUsuario : Form
    {
        public RelatorioUsuario()
        {
            InitializeComponent();
        }

        private void RelatorioUsuario_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlDataAdapter cmd = new SqlDataAdapter("select * from t_login", con);
            Duck_DuckDataSet1 ds = new Duck_DuckDataSet1();
            cmd.Fill(ds.Tables["t_login"]);
            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(ds.Tables["t_login"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }
    }
}
