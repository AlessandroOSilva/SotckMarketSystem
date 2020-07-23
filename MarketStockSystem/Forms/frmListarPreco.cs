using MarketStockSystem.Data;
using MarketStockSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketStockSystem.Forms
{
    public partial class frmListarPreco : Form
    {
        public frmListarPreco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListarPreco_Load(object sender, EventArgs e)
        {
            using (MarketContext _context = new MarketContext())
            {
                dataGridView1.DataSource = _context.Acoes.ToList();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            if(double.Parse(txbPrecoMin.Text) > double.Parse(txbPrecoMax.Text))
            {
                MessageBox.Show("Preço mínimo não pode ser maior que preço máximo. ");
            }
            else if (double.Parse(txbPrecoMax.Text) < double.Parse(txbPrecoMin.Text))
            {
                MessageBox.Show("Preço máximo não pode ser menor que preço mínimo. ");
            }
            else
            {
                using (MarketContext _context = new MarketContext())
                {
                    var consulta = from Acao a in _context.Acoes
                                   where a.CotacaoAtual >= double.Parse(txbPrecoMin.Text)
                                   && a.CotacaoAtual <= double.Parse(txbPrecoMax.Text)
                                   select a;

                    List<Acao> acoes = new List<Acao>();
                    foreach (var cons in consulta)
                    {
                        acoes.Add(cons);
                    }

                    dataGridView1.DataSource = acoes;
                }
            }
        }

    }
}
