using MarketStockSystem.Entities.Enums;
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

            comboBox1.DataSource = Enum.GetValues(typeof(SegmentoEmpresa));
        }
    }
}
