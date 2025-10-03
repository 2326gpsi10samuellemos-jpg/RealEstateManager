namespace ProjetoAula
{
    partial class form_visualizar
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
            this.components = new System.ComponentModel.Container();
            this.lb_visualizar = new System.Windows.Forms.Label();
            this.btn_sairvisu = new System.Windows.Forms.Button();
            this.lb_tipoimovelvisu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_finalidadevisu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_areavisu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_nrqrtsvisu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_nrcdbanhovisu = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_mobiladovisu = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_rendavisu = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_preçovisu = new System.Windows.Forms.Label();
            this.lb_nrimovel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imovelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.imoveisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imovelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NrImovel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrQuartos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrCDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobilado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Renda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imovelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imoveisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imovelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_visualizar
            // 
            this.lb_visualizar.AutoSize = true;
            this.lb_visualizar.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_visualizar.Location = new System.Drawing.Point(339, 9);
            this.lb_visualizar.Name = "lb_visualizar";
            this.lb_visualizar.Size = new System.Drawing.Size(407, 45);
            this.lb_visualizar.TabIndex = 1;
            this.lb_visualizar.Text = "Visualização de Imóveis";
            // 
            // btn_sairvisu
            // 
            this.btn_sairvisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sairvisu.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_sairvisu.Location = new System.Drawing.Point(998, 333);
            this.btn_sairvisu.Name = "btn_sairvisu";
            this.btn_sairvisu.Size = new System.Drawing.Size(93, 30);
            this.btn_sairvisu.TabIndex = 4;
            this.btn_sairvisu.Text = "Sair";
            this.btn_sairvisu.UseVisualStyleBackColor = true;
            this.btn_sairvisu.Click += new System.EventHandler(this.btn_sairvisu_Click);
            // 
            // lb_tipoimovelvisu
            // 
            this.lb_tipoimovelvisu.AutoSize = true;
            this.lb_tipoimovelvisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tipoimovelvisu.Location = new System.Drawing.Point(117, 108);
            this.lb_tipoimovelvisu.Name = "lb_tipoimovelvisu";
            this.lb_tipoimovelvisu.Size = new System.Drawing.Size(39, 16);
            this.lb_tipoimovelvisu.TabIndex = 5;
            this.lb_tipoimovelvisu.Text = "Tipo";
            this.lb_tipoimovelvisu.Click += new System.EventHandler(this.lb_tipoimovelvisu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(116, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(213, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Finalidade:";
            // 
            // lb_finalidadevisu
            // 
            this.lb_finalidadevisu.AutoSize = true;
            this.lb_finalidadevisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_finalidadevisu.Location = new System.Drawing.Point(217, 108);
            this.lb_finalidadevisu.Name = "lb_finalidadevisu";
            this.lb_finalidadevisu.Size = new System.Drawing.Size(81, 16);
            this.lb_finalidadevisu.TabIndex = 7;
            this.lb_finalidadevisu.Text = "Finalidade";
            this.lb_finalidadevisu.Click += new System.EventHandler(this.lb_finalidadevisu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(343, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Área:";
            // 
            // lb_areavisu
            // 
            this.lb_areavisu.AutoSize = true;
            this.lb_areavisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_areavisu.Location = new System.Drawing.Point(357, 108);
            this.lb_areavisu.Name = "lb_areavisu";
            this.lb_areavisu.Size = new System.Drawing.Size(40, 16);
            this.lb_areavisu.TabIndex = 9;
            this.lb_areavisu.Text = "Area";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(451, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nr Quartos:";
            // 
            // lb_nrqrtsvisu
            // 
            this.lb_nrqrtsvisu.AutoSize = true;
            this.lb_nrqrtsvisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nrqrtsvisu.Location = new System.Drawing.Point(483, 108);
            this.lb_nrqrtsvisu.Name = "lb_nrqrtsvisu";
            this.lb_nrqrtsvisu.Size = new System.Drawing.Size(65, 16);
            this.lb_nrqrtsvisu.TabIndex = 11;
            this.lb_nrqrtsvisu.Text = "NrQRTS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(578, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nr C\'Banho:";
            // 
            // lb_nrcdbanhovisu
            // 
            this.lb_nrcdbanhovisu.AutoSize = true;
            this.lb_nrcdbanhovisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nrcdbanhovisu.Location = new System.Drawing.Point(613, 108);
            this.lb_nrcdbanhovisu.Name = "lb_nrcdbanhovisu";
            this.lb_nrcdbanhovisu.Size = new System.Drawing.Size(54, 16);
            this.lb_nrcdbanhovisu.TabIndex = 13;
            this.lb_nrcdbanhovisu.Text = "NrCDB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(709, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Mobilado:";
            // 
            // lb_mobiladovisu
            // 
            this.lb_mobiladovisu.AutoSize = true;
            this.lb_mobiladovisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mobiladovisu.Location = new System.Drawing.Point(734, 108);
            this.lb_mobiladovisu.Name = "lb_mobiladovisu";
            this.lb_mobiladovisu.Size = new System.Drawing.Size(33, 16);
            this.lb_mobiladovisu.TabIndex = 15;
            this.lb_mobiladovisu.Text = "S/N";
            this.lb_mobiladovisu.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(821, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Tipo de Renda:";
            // 
            // lb_rendavisu
            // 
            this.lb_rendavisu.AutoSize = true;
            this.lb_rendavisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rendavisu.Location = new System.Drawing.Point(821, 108);
            this.lb_rendavisu.Name = "lb_rendavisu";
            this.lb_rendavisu.Size = new System.Drawing.Size(53, 16);
            this.lb_rendavisu.TabIndex = 17;
            this.lb_rendavisu.Text = "Renda";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(1008, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Preço:";
            // 
            // lb_preçovisu
            // 
            this.lb_preçovisu.AutoSize = true;
            this.lb_preçovisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_preçovisu.Location = new System.Drawing.Point(1013, 108);
            this.lb_preçovisu.Name = "lb_preçovisu";
            this.lb_preçovisu.Size = new System.Drawing.Size(48, 16);
            this.lb_preçovisu.TabIndex = 19;
            this.lb_preçovisu.Text = "Preço";
            // 
            // lb_nrimovel
            // 
            this.lb_nrimovel.AutoSize = true;
            this.lb_nrimovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nrimovel.Location = new System.Drawing.Point(12, 108);
            this.lb_nrimovel.Name = "lb_nrimovel";
            this.lb_nrimovel.Size = new System.Drawing.Size(69, 16);
            this.lb_nrimovel.TabIndex = 21;
            this.lb_nrimovel.Text = "NrImovel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NrImovel,
            this.NrQuartos,
            this.NrCDB,
            this.Mobilado,
            this.Renda,
            this.Preco,
            this.Finalidade,
            this.Area,
            this.Tipo});
            this.dataGridView1.Location = new System.Drawing.Point(16, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 243);
            this.dataGridView1.TabIndex = 22;
            // 
            // imovelBindingSource1
            // 
            this.imovelBindingSource1.DataSource = typeof(ProjetoAula.Imovel);
            // 
            // imoveisBindingSource
            // 
            this.imoveisBindingSource.DataSource = typeof(ProjetoAula.Imoveis);
            // 
            // imovelBindingSource
            // 
            this.imovelBindingSource.DataSource = typeof(ProjetoAula.Imovel);
            // 
            // NrImovel
            // 
            this.NrImovel.HeaderText = "Nr Imóvel";
            this.NrImovel.Name = "NrImovel";
            // 
            // NrQuartos
            // 
            this.NrQuartos.HeaderText = "Nr Quartos";
            this.NrQuartos.Name = "NrQuartos";
            // 
            // NrCDB
            // 
            this.NrCDB.HeaderText = "Nr C\'Banho";
            this.NrCDB.Name = "NrCDB";
            // 
            // Mobilado
            // 
            this.Mobilado.HeaderText = "Mobilado";
            this.Mobilado.Name = "Mobilado";
            // 
            // Renda
            // 
            this.Renda.HeaderText = "Tipo de Renda";
            this.Renda.Name = "Renda";
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço (€)";
            this.Preco.Name = "Preco";
            // 
            // Finalidade
            // 
            this.Finalidade.HeaderText = "Finalidade";
            this.Finalidade.Name = "Finalidade";
            // 
            // Area
            // 
            this.Area.HeaderText = "Área (m2)";
            this.Area.Name = "Area";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // form_visualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 375);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_nrimovel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lb_preçovisu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lb_rendavisu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lb_mobiladovisu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_nrcdbanhovisu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_nrqrtsvisu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_areavisu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_finalidadevisu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_tipoimovelvisu);
            this.Controls.Add(this.btn_sairvisu);
            this.Controls.Add(this.lb_visualizar);
            this.Name = "form_visualizar";
            this.Text = "Visualização de Imóveis";
            this.Load += new System.EventHandler(this.form_inserir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imovelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imoveisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imovelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_visualizar;
        private System.Windows.Forms.Button btn_sairvisu;
        private System.Windows.Forms.Label lb_tipoimovelvisu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_finalidadevisu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_areavisu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_nrqrtsvisu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_nrcdbanhovisu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_mobiladovisu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_rendavisu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_preçovisu;
        private System.Windows.Forms.Label lb_nrimovel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource imovelBindingSource;
        private System.Windows.Forms.BindingSource imoveisBindingSource;
        private System.Windows.Forms.BindingSource imovelBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrImovel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrQuartos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrCDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobilado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Renda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Finalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}