using MarketStockSystem.Data;
using MarketStockSystem.Entities;
using MarketStockSystem.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
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
            using (DbContext _context = new MarketContext())
            {
                _context.Add(a);
                _context.SaveChanges();
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string empresa = txbNome.Text;
            string codAtivo = txbCod.Text;
            SegmentoEmpresa segmento = (SegmentoEmpresa)cmbSegmento.SelectedItem;
            double patrimonioLiquido = double.Parse(txbPatrimonio.Text);
            double dividaLiquida = double.Parse(txbDivida.Text);
            double lucroAnoAnt = double.Parse(txbLucro.Text);
            int quantAcoes = int.Parse(txbQuantAcoes.Text);
            double preco = double.Parse(txbPreco.Text);

            Acao a = new Acao(codAtivo, preco, empresa, segmento, lucroAnoAnt, quantAcoes, dividaLiquida, patrimonioLiquido);

            CadastratAcao(a);
            LimparCampos();

        }

        public void LimparCampos()
        {
            txbCod.Clear();
            txbDivida.Clear();
            txbNome.Clear();
            txbPatrimonio.Clear();
            txbLucro.Clear();
            txbQuantAcoes.Clear();
            txbPreco.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
