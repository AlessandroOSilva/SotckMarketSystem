namespace MarketStockSystem
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnCarteira = new System.Windows.Forms.Button();
            this.btnCadastrarAtivo = new System.Windows.Forms.Button();
            this.panelWallet = new System.Windows.Forms.Panel();
            this.btnCarteiraAcoes = new System.Windows.Forms.Button();
            this.btnCarteiraFii = new System.Windows.Forms.Button();
            this.btnCarteiraOpcoes = new System.Windows.Forms.Button();
            this.btnListarPreco = new System.Windows.Forms.Button();
            this.btnListarSegmento = new System.Windows.Forms.Button();
            this.btnListarIndicadores = new System.Windows.Forms.Button();
            this.panelList = new System.Windows.Forms.Panel();
            this.panelCad = new System.Windows.Forms.Panel();
            this.btnCadFii = new System.Windows.Forms.Button();
            this.btnCadOpcao = new System.Windows.Forms.Button();
            this.btnCadAcao = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelWallet.SuspendLayout();
            this.panelList.SuspendLayout();
            this.panelCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panelCad);
            this.panel1.Controls.Add(this.btnListar);
            this.panel1.Controls.Add(this.panelList);
            this.panel1.Controls.Add(this.panelWallet);
            this.panel1.Controls.Add(this.btnCarteira);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 681);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 159);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(200, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(684, 159);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(200, 159);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(684, 522);
            this.panel7.TabIndex = 2;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 158);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(200, 40);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnListar.FlatAppearance.BorderSize = 0;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnListar.Location = new System.Drawing.Point(0, 306);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(200, 40);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnCarteira
            // 
            this.btnCarteira.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnCarteira.FlatAppearance.BorderSize = 0;
            this.btnCarteira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarteira.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnCarteira.Location = new System.Drawing.Point(0, 464);
            this.btnCarteira.Name = "btnCarteira";
            this.btnCarteira.Size = new System.Drawing.Size(200, 40);
            this.btnCarteira.TabIndex = 6;
            this.btnCarteira.Text = "Carteira";
            this.btnCarteira.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarteira.UseVisualStyleBackColor = false;
            this.btnCarteira.Click += new System.EventHandler(this.btnCarteira_Click);
            // 
            // btnCadastrarAtivo
            // 
            this.btnCadastrarAtivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCadastrarAtivo.FlatAppearance.BorderSize = 0;
            this.btnCadastrarAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAtivo.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnCadastrarAtivo.Location = new System.Drawing.Point(0, 0);
            this.btnCadastrarAtivo.Name = "btnCadastrarAtivo";
            this.btnCadastrarAtivo.Size = new System.Drawing.Size(200, 40);
            this.btnCadastrarAtivo.TabIndex = 8;
            this.btnCadastrarAtivo.Text = "Cadastrar";
            this.btnCadastrarAtivo.UseVisualStyleBackColor = false;
            this.btnCadastrarAtivo.Click += new System.EventHandler(this.btnCadastrarAtivo_Click);
            // 
            // panelWallet
            // 
            this.panelWallet.Controls.Add(this.btnCarteiraFii);
            this.panelWallet.Controls.Add(this.btnCadastrarAtivo);
            this.panelWallet.Controls.Add(this.btnCarteiraAcoes);
            this.panelWallet.Controls.Add(this.btnCarteiraOpcoes);
            this.panelWallet.Location = new System.Drawing.Point(0, 500);
            this.panelWallet.Name = "panelWallet";
            this.panelWallet.Size = new System.Drawing.Size(200, 150);
            this.panelWallet.TabIndex = 7;
            this.panelWallet.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWallet_Paint);
            // 
            // btnCarteiraAcoes
            // 
            this.btnCarteiraAcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCarteiraAcoes.FlatAppearance.BorderSize = 0;
            this.btnCarteiraAcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarteiraAcoes.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnCarteiraAcoes.Location = new System.Drawing.Point(0, 36);
            this.btnCarteiraAcoes.Name = "btnCarteiraAcoes";
            this.btnCarteiraAcoes.Size = new System.Drawing.Size(200, 40);
            this.btnCarteiraAcoes.TabIndex = 1;
            this.btnCarteiraAcoes.Text = "Ações";
            this.btnCarteiraAcoes.UseVisualStyleBackColor = false;
            this.btnCarteiraAcoes.Click += new System.EventHandler(this.btnCarteiraAcoes_Click);
            // 
            // btnCarteiraFii
            // 
            this.btnCarteiraFii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCarteiraFii.FlatAppearance.BorderSize = 0;
            this.btnCarteiraFii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarteiraFii.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnCarteiraFii.Location = new System.Drawing.Point(0, 108);
            this.btnCarteiraFii.Name = "btnCarteiraFii";
            this.btnCarteiraFii.Size = new System.Drawing.Size(200, 40);
            this.btnCarteiraFii.TabIndex = 3;
            this.btnCarteiraFii.Text = "FII";
            this.btnCarteiraFii.UseVisualStyleBackColor = false;
            this.btnCarteiraFii.Click += new System.EventHandler(this.btnCarteiraFii_Click);
            // 
            // btnCarteiraOpcoes
            // 
            this.btnCarteiraOpcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCarteiraOpcoes.FlatAppearance.BorderSize = 0;
            this.btnCarteiraOpcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarteiraOpcoes.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnCarteiraOpcoes.Location = new System.Drawing.Point(0, 72);
            this.btnCarteiraOpcoes.Name = "btnCarteiraOpcoes";
            this.btnCarteiraOpcoes.Size = new System.Drawing.Size(200, 40);
            this.btnCarteiraOpcoes.TabIndex = 2;
            this.btnCarteiraOpcoes.Text = "Opções";
            this.btnCarteiraOpcoes.UseVisualStyleBackColor = false;
            this.btnCarteiraOpcoes.Click += new System.EventHandler(this.btnCarteiraOpcoes_Click);
            // 
            // btnListarPreco
            // 
            this.btnListarPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnListarPreco.FlatAppearance.BorderSize = 0;
            this.btnListarPreco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPreco.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnListarPreco.Location = new System.Drawing.Point(0, 80);
            this.btnListarPreco.Name = "btnListarPreco";
            this.btnListarPreco.Size = new System.Drawing.Size(200, 36);
            this.btnListarPreco.TabIndex = 3;
            this.btnListarPreco.Text = "Por Preço";
            this.btnListarPreco.UseVisualStyleBackColor = false;
            this.btnListarPreco.Click += new System.EventHandler(this.btnListarPreco_Click);
            // 
            // btnListarSegmento
            // 
            this.btnListarSegmento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnListarSegmento.FlatAppearance.BorderSize = 0;
            this.btnListarSegmento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarSegmento.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnListarSegmento.Location = new System.Drawing.Point(0, 36);
            this.btnListarSegmento.Name = "btnListarSegmento";
            this.btnListarSegmento.Size = new System.Drawing.Size(200, 44);
            this.btnListarSegmento.TabIndex = 2;
            this.btnListarSegmento.Text = "Por Segmento";
            this.btnListarSegmento.UseVisualStyleBackColor = false;
            this.btnListarSegmento.Click += new System.EventHandler(this.btnListarSegmento_Click);
            // 
            // btnListarIndicadores
            // 
            this.btnListarIndicadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnListarIndicadores.FlatAppearance.BorderSize = 0;
            this.btnListarIndicadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarIndicadores.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnListarIndicadores.Location = new System.Drawing.Point(0, 0);
            this.btnListarIndicadores.Name = "btnListarIndicadores";
            this.btnListarIndicadores.Size = new System.Drawing.Size(200, 40);
            this.btnListarIndicadores.TabIndex = 1;
            this.btnListarIndicadores.Text = "Por Indicadores";
            this.btnListarIndicadores.UseVisualStyleBackColor = false;
            this.btnListarIndicadores.Click += new System.EventHandler(this.btnListarIndicadores_Click);
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.btnListarPreco);
            this.panelList.Controls.Add(this.btnListarIndicadores);
            this.panelList.Controls.Add(this.btnListarSegmento);
            this.panelList.Location = new System.Drawing.Point(0, 348);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(200, 116);
            this.panelList.TabIndex = 5;
            // 
            // panelCad
            // 
            this.panelCad.Controls.Add(this.btnCadFii);
            this.panelCad.Controls.Add(this.btnCadAcao);
            this.panelCad.Controls.Add(this.btnCadOpcao);
            this.panelCad.Location = new System.Drawing.Point(0, 196);
            this.panelCad.Name = "panelCad";
            this.panelCad.Size = new System.Drawing.Size(200, 112);
            this.panelCad.TabIndex = 2;
            // 
            // btnCadFii
            // 
            this.btnCadFii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCadFii.FlatAppearance.BorderSize = 0;
            this.btnCadFii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadFii.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnCadFii.Location = new System.Drawing.Point(0, 72);
            this.btnCadFii.Name = "btnCadFii";
            this.btnCadFii.Size = new System.Drawing.Size(200, 40);
            this.btnCadFii.TabIndex = 3;
            this.btnCadFii.Text = "FII";
            this.btnCadFii.UseVisualStyleBackColor = false;
            this.btnCadFii.Click += new System.EventHandler(this.btnCadFii_Click);
            // 
            // btnCadOpcao
            // 
            this.btnCadOpcao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCadOpcao.FlatAppearance.BorderSize = 0;
            this.btnCadOpcao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadOpcao.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnCadOpcao.Location = new System.Drawing.Point(0, 36);
            this.btnCadOpcao.Name = "btnCadOpcao";
            this.btnCadOpcao.Size = new System.Drawing.Size(200, 40);
            this.btnCadOpcao.TabIndex = 2;
            this.btnCadOpcao.Text = "Opção";
            this.btnCadOpcao.UseVisualStyleBackColor = false;
            this.btnCadOpcao.Click += new System.EventHandler(this.btnCadOpcao_Click);
            // 
            // btnCadAcao
            // 
            this.btnCadAcao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCadAcao.FlatAppearance.BorderSize = 0;
            this.btnCadAcao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadAcao.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnCadAcao.Location = new System.Drawing.Point(0, 0);
            this.btnCadAcao.Name = "btnCadAcao";
            this.btnCadAcao.Size = new System.Drawing.Size(200, 40);
            this.btnCadAcao.TabIndex = 1;
            this.btnCadAcao.Text = "Ação";
            this.btnCadAcao.UseVisualStyleBackColor = false;
            this.btnCadAcao.Click += new System.EventHandler(this.btnCadAcao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(884, 681);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelWallet.ResumeLayout(false);
            this.panelList.ResumeLayout(false);
            this.panelCad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelCad;
        private System.Windows.Forms.Button btnCadFii;
        private System.Windows.Forms.Button btnCadAcao;
        private System.Windows.Forms.Button btnCadOpcao;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Button btnListarPreco;
        private System.Windows.Forms.Button btnListarIndicadores;
        private System.Windows.Forms.Button btnListarSegmento;
        private System.Windows.Forms.Panel panelWallet;
        private System.Windows.Forms.Button btnCarteiraFii;
        private System.Windows.Forms.Button btnCadastrarAtivo;
        private System.Windows.Forms.Button btnCarteiraAcoes;
        private System.Windows.Forms.Button btnCarteiraOpcoes;
        private System.Windows.Forms.Button btnCarteira;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

