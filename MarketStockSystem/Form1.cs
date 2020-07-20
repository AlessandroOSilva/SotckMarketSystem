using MarketStockSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketStockSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MudarDesign();
        }

        private void MudarDesign()
        {
            panelCad.Visible = false;
            panelList.Visible = false;
            panelWallet.Visible = false;
        }
        public void EsconderSubmenu()
        {
            if (panelCad.Visible == true)
                panelCad.Visible = false;
            if (panelList.Visible == true)
                panelList.Visible = false;
            if (panelWallet.Visible == true)
                panelWallet.Visible = false;
        }

        private void MostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                EsconderSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelCad);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelList);
        }

        private void btnCarteira_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelWallet);
        }

        private void btnCadAcao_Click(object sender, EventArgs e)
        {
            AbrirJanelaFilho(new frmCadastrarAcao());
            EsconderSubmenu();
        }

        private void btnCadOpcao_Click(object sender, EventArgs e)
        {
            AbrirJanelaFilho(new frmCadastrarOpcao());
            EsconderSubmenu();
        }

        private void btnCadFii_Click(object sender, EventArgs e)
        {
            AbrirJanelaFilho(new frmCadastroFii());
            EsconderSubmenu();
        }

        private void btnListarIndicadores_Click(object sender, EventArgs e)
        {
            EsconderSubmenu();
        }

        private void btnListarSegmento_Click(object sender, EventArgs e)
        {
            EsconderSubmenu();
        }

        private void btnListarPreco_Click(object sender, EventArgs e)
        {
            EsconderSubmenu();
        }

        private void btnCarteiraAcoes_Click(object sender, EventArgs e)
        {
            EsconderSubmenu();
        }

        private void btnCarteiraOpcoes_Click(object sender, EventArgs e)
        {
            EsconderSubmenu();
        }

        private void btnCarteiraFii_Click(object sender, EventArgs e)
        {
            EsconderSubmenu();
        }

        private void btnCadastrarAtivo_Click(object sender, EventArgs e)
        {
            EsconderSubmenu();
        }

        private Form janelaAtiva = null;
        private void AbrirJanelaFilho(Form frmFilho)
        {
            if(janelaAtiva != null)
                janelaAtiva.Close();
            janelaAtiva = frmFilho;
            frmFilho.TopLevel =false;
            frmFilho.FormBorderStyle = FormBorderStyle.None;
            frmFilho.Dock = DockStyle.Fill;
            panel7.Controls.Add(frmFilho);
            panel7.Tag = frmFilho;
            frmFilho.BringToFront();
            frmFilho.Show();

            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelWallet_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
