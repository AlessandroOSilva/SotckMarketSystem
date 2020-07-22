using MarketStockSystem.Data;
using MarketStockSystem.Entities;
using MarketStockSystem.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketStockSystem.Forms
{
    public partial class frmListarSegmento : Form
    {
        public frmListarSegmento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmListarSegmento_Load(object sender, EventArgs e)
        {

            cmbSeg.DataSource = Enum.GetValues(typeof(SegmentoEmpresa));

            using (MarketContext dbContext = new MarketContext())
            {
                dataGridView1.DataSource = dbContext.Acoes.ToList();

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ConsultarSegmento();
        }

        public void ConsultarSegmento()
        {
            using (MarketContext context = new MarketContext())
            {
                var consulta = from acao in context.Acoes
                               where acao.Segmento == (SegmentoEmpresa)cmbSeg.SelectedItem
                               select acao;

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
