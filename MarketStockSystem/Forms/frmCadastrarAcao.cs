using MarketStockSystem.Entities;
using MarketStockSystem.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketStockSystem.Forms
{
    public partial class frmCadastrarAcao : Form
    {
        public frmCadastrarAcao()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarAcao_Load(object sender, EventArgs e)
        {
            cmbSegmento.DataSource = Enum.GetValues(typeof(SegmentoEmpresa));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void CadastratAcao(Acao a)
        {
            a.Empresa = txbNome.Text;
            a.CodAtivo = txbCod.Text;
        }
    }
}
