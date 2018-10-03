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
    public partial class FiltroEstoque : Form
    {
        public ProdutoCRUD TelaFiltroEstoque;
        public int EstoqueBaixoInicial, EstoqueBaixoFinal, EstoqueRegularInicial, EstoqueRegularFinal;

        public FiltroEstoque(ProdutoCRUD TelaFiltroEstoque,int EstoqueBaixoInicial, int EstoqueBaixoFinal, int EstoqueRegularInicial, int EstoqueRegularFinal)
        {
            InitializeComponent();
            this.EstoqueBaixoInicial = EstoqueBaixoInicial;
            this.EstoqueBaixoFinal = EstoqueBaixoFinal;
            this.EstoqueRegularInicial = EstoqueRegularInicial;
            this.EstoqueRegularFinal = EstoqueRegularFinal;
            VerificarEstoque();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NudEstAmaInicial_ValueChanged(object sender, EventArgs e)
        {
            NudEstVerFinal.Value=NudEstAmaInicial.Value;
        }

        public void VerificarEstoque()
        {
            EstoqueBaixoInicial = (int)NudEstVerInicial.Value;
            EstoqueBaixoFinal = (int)NudEstVerFinal.Value;
            EstoqueRegularInicial = (int)NudEstAmaInicial.Value;
            EstoqueRegularFinal = (int)NudEstAmaFinal.Value;
        }
        public void Verificar()
        {
            if (EstoqueRegularInicial > EstoqueRegularFinal)
            {
                MessageBox.Show("Corrija os dados informados");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Verificar();
            VerificarEstoque();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            NudEstAmaInicial.Value = NudEstVerFinal.Value;
        }
    }
}
