namespace MarketStockSystem.Forms
{
    partial class frmCadastrarAcao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.cmbSegmento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txbDivida = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbPatrimonio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbCod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbLucro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbQuantAcoes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            this.panelCadastro.SuspendLayout();
            this.panelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.panelTitle.Controls.Add(this.label5);
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(684, 100);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(196, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "CADASTRO DE AÇÕES";
            // 
            // panelCadastro
            // 
            this.panelCadastro.Controls.Add(this.cmbSegmento);
            this.panelCadastro.Controls.Add(this.label6);
            this.panelCadastro.Controls.Add(this.label11);
            this.panelCadastro.Controls.Add(this.txbDivida);
            this.panelCadastro.Controls.Add(this.label8);
            this.panelCadastro.Controls.Add(this.txbPatrimonio);
            this.panelCadastro.Controls.Add(this.label9);
            this.panelCadastro.Controls.Add(this.txbCod);
            this.panelCadastro.Controls.Add(this.label10);
            this.panelCadastro.Controls.Add(this.txbLucro);
            this.panelCadastro.Controls.Add(this.label4);
            this.panelCadastro.Controls.Add(this.txbQuantAcoes);
            this.panelCadastro.Controls.Add(this.label3);
            this.panelCadastro.Controls.Add(this.txbPreco);
            this.panelCadastro.Controls.Add(this.label2);
            this.panelCadastro.Controls.Add(this.txbNome);
            this.panelCadastro.Controls.Add(this.label1);
            this.panelCadastro.Location = new System.Drawing.Point(158, 106);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(320, 320);
            this.panelCadastro.TabIndex = 1;
            // 
            // cmbSegmento
            // 
            this.cmbSegmento.FormattingEnabled = true;
            this.cmbSegmento.Location = new System.Drawing.Point(98, 79);
            this.cmbSegmento.Name = "cmbSegmento";
            this.cmbSegmento.Size = new System.Drawing.Size(196, 21);
            this.cmbSegmento.TabIndex = 22;
            this.cmbSegmento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(4, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Segmento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(158, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "*Refere-se ao ultimo ano.";
            // 
            // txbDivida
            // 
            this.txbDivida.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbDivida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDivida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDivida.Location = new System.Drawing.Point(98, 149);
            this.txbDivida.Name = "txbDivida";
            this.txbDivida.Size = new System.Drawing.Size(196, 22);
            this.txbDivida.TabIndex = 15;
            this.txbDivida.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(4, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dívida:";
            // 
            // txbPatrimonio
            // 
            this.txbPatrimonio.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbPatrimonio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPatrimonio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPatrimonio.Location = new System.Drawing.Point(98, 112);
            this.txbPatrimonio.Name = "txbPatrimonio";
            this.txbPatrimonio.Size = new System.Drawing.Size(198, 22);
            this.txbPatrimonio.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(5, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Patri.:";
            // 
            // txbCod
            // 
            this.txbCod.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCod.Location = new System.Drawing.Point(98, 48);
            this.txbCod.Name = "txbCod";
            this.txbCod.Size = new System.Drawing.Size(198, 22);
            this.txbCod.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(4, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Código: ";
            // 
            // txbLucro
            // 
            this.txbLucro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbLucro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbLucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLucro.Location = new System.Drawing.Point(98, 259);
            this.txbLucro.Name = "txbLucro";
            this.txbLucro.Size = new System.Drawing.Size(196, 22);
            this.txbLucro.TabIndex = 7;
            this.txbLucro.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(4, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lucro*:";
            // 
            // txbQuantAcoes
            // 
            this.txbQuantAcoes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbQuantAcoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbQuantAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantAcoes.Location = new System.Drawing.Point(98, 225);
            this.txbQuantAcoes.Name = "txbQuantAcoes";
            this.txbQuantAcoes.Size = new System.Drawing.Size(196, 22);
            this.txbQuantAcoes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nr.  de Ações:";
            // 
            // txbPreco
            // 
            this.txbPreco.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPreco.Location = new System.Drawing.Point(98, 188);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(196, 22);
            this.txbPreco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(5, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço: ";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(98, 4);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(198, 22);
            this.txbNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // panelBotoes
            // 
            this.panelBotoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelBotoes.Controls.Add(this.btnSalvar);
            this.panelBotoes.Controls.Add(this.btnLimpar);
            this.panelBotoes.Controls.Add(this.btnCancelar);
            this.panelBotoes.Location = new System.Drawing.Point(158, 434);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(320, 50);
            this.panelBotoes.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(242, 14);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Location = new System.Drawing.Point(127, 14);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(3, 14);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCadastrarAcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(684, 522);
            this.Controls.Add(this.panelBotoes);
            this.Controls.Add(this.panelCadastro);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(684, 522);
            this.MinimumSize = new System.Drawing.Size(684, 522);
            this.Name = "frmCadastrarAcao";
            this.Text = "frmCadastrarAcao";
            this.Load += new System.EventHandler(this.frmCadastrarAcao_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelCadastro.ResumeLayout(false);
            this.panelCadastro.PerformLayout();
            this.panelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelCadastro;
        private System.Windows.Forms.TextBox txbLucro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbQuantAcoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDivida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbPatrimonio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbCod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSegmento;
    }
}