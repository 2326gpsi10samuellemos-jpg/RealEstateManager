namespace ProjetoAula
{
    partial class form_inserir
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
            this.lb_inserir = new System.Windows.Forms.Label();
            this.btn_gravarin = new System.Windows.Forms.Button();
            this.btn_sairin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_tipoimovelin = new System.Windows.Forms.ComboBox();
            this.cb_finalidadein = new System.Windows.Forms.ComboBox();
            this.lb_finalidade = new System.Windows.Forms.Label();
            this.lb_nrquartos = new System.Windows.Forms.Label();
            this.lb_area = new System.Windows.Forms.Label();
            this.lb_preço = new System.Windows.Forms.Label();
            this.cb_rendain = new System.Windows.Forms.ComboBox();
            this.lb_renda = new System.Windows.Forms.Label();
            this.lb_mobilado = new System.Windows.Forms.Label();
            this.lb_nrcdbanho = new System.Windows.Forms.Label();
            this.tb_areain = new System.Windows.Forms.TextBox();
            this.tb_nrcdbanhoin = new System.Windows.Forms.TextBox();
            this.tb_preçoin = new System.Windows.Forms.TextBox();
            this.tb_nrquartosin = new System.Windows.Forms.TextBox();
            this.rb_sim = new System.Windows.Forms.RadioButton();
            this.rb_nao = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_inserir
            // 
            this.lb_inserir.AutoSize = true;
            this.lb_inserir.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_inserir.Location = new System.Drawing.Point(304, 29);
            this.lb_inserir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_inserir.Name = "lb_inserir";
            this.lb_inserir.Size = new System.Drawing.Size(512, 68);
            this.lb_inserir.TabIndex = 0;
            this.lb_inserir.Text = "Inserção de Imóveis";
            // 
            // btn_gravarin
            // 
            this.btn_gravarin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravarin.Location = new System.Drawing.Point(772, 474);
            this.btn_gravarin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_gravarin.Name = "btn_gravarin";
            this.btn_gravarin.Size = new System.Drawing.Size(140, 46);
            this.btn_gravarin.TabIndex = 1;
            this.btn_gravarin.Text = "Gravar";
            this.btn_gravarin.UseVisualStyleBackColor = true;
            this.btn_gravarin.Click += new System.EventHandler(this.btn_gravarin_Click);
            // 
            // btn_sairin
            // 
            this.btn_sairin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sairin.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_sairin.Location = new System.Drawing.Point(921, 474);
            this.btn_sairin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_sairin.Name = "btn_sairin";
            this.btn_sairin.Size = new System.Drawing.Size(140, 46);
            this.btn_sairin.TabIndex = 2;
            this.btn_sairin.Text = "Sair";
            this.btn_sairin.UseVisualStyleBackColor = true;
            this.btn_sairin.Click += new System.EventHandler(this.btn_sairin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de Imóvel:";
            // 
            // cb_tipoimovelin
            // 
            this.cb_tipoimovelin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipoimovelin.FormattingEnabled = true;
            this.cb_tipoimovelin.Items.AddRange(new object[] {
            "Casa",
            "Apartamento",
            "Terreno"});
            this.cb_tipoimovelin.Location = new System.Drawing.Point(256, 160);
            this.cb_tipoimovelin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_tipoimovelin.Name = "cb_tipoimovelin";
            this.cb_tipoimovelin.Size = new System.Drawing.Size(202, 28);
            this.cb_tipoimovelin.TabIndex = 5;
            this.cb_tipoimovelin.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb_finalidadein
            // 
            this.cb_finalidadein.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_finalidadein.FormattingEnabled = true;
            this.cb_finalidadein.Items.AddRange(new object[] {
            "Residência",
            "Comercial",
            "Industrial",
            "Lazer"});
            this.cb_finalidadein.Location = new System.Drawing.Point(831, 160);
            this.cb_finalidadein.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_finalidadein.Name = "cb_finalidadein";
            this.cb_finalidadein.Size = new System.Drawing.Size(202, 28);
            this.cb_finalidadein.TabIndex = 7;
            this.cb_finalidadein.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // lb_finalidade
            // 
            this.lb_finalidade.AutoSize = true;
            this.lb_finalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_finalidade.Location = new System.Drawing.Point(586, 162);
            this.lb_finalidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_finalidade.Name = "lb_finalidade";
            this.lb_finalidade.Size = new System.Drawing.Size(218, 25);
            this.lb_finalidade.TabIndex = 6;
            this.lb_finalidade.Text = "Finalidade do Imóvel:";
            // 
            // lb_nrquartos
            // 
            this.lb_nrquartos.AutoSize = true;
            this.lb_nrquartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nrquartos.Location = new System.Drawing.Point(586, 243);
            this.lb_nrquartos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nrquartos.Name = "lb_nrquartos";
            this.lb_nrquartos.Size = new System.Drawing.Size(253, 25);
            this.lb_nrquartos.TabIndex = 10;
            this.lb_nrquartos.Text = "Nr de Quartos do Imóvel:";
            // 
            // lb_area
            // 
            this.lb_area.AutoSize = true;
            this.lb_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_area.Location = new System.Drawing.Point(75, 242);
            this.lb_area.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_area.Name = "lb_area";
            this.lb_area.Size = new System.Drawing.Size(164, 25);
            this.lb_area.TabIndex = 8;
            this.lb_area.Text = "Área do Imóvel:";
            this.lb_area.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_preço
            // 
            this.lb_preço.AutoSize = true;
            this.lb_preço.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_preço.Location = new System.Drawing.Point(586, 395);
            this.lb_preço.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_preço.Name = "lb_preço";
            this.lb_preço.Size = new System.Drawing.Size(174, 25);
            this.lb_preço.TabIndex = 18;
            this.lb_preço.Text = "Preço do Imóvel:";
            // 
            // cb_rendain
            // 
            this.cb_rendain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rendain.FormattingEnabled = true;
            this.cb_rendain.Items.AddRange(new object[] {
            "Aluguer",
            "Pagamento à vista"});
            this.cb_rendain.Location = new System.Drawing.Point(256, 394);
            this.cb_rendain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_rendain.Name = "cb_rendain";
            this.cb_rendain.Size = new System.Drawing.Size(202, 28);
            this.cb_rendain.TabIndex = 17;
            // 
            // lb_renda
            // 
            this.lb_renda.AutoSize = true;
            this.lb_renda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_renda.Location = new System.Drawing.Point(75, 395);
            this.lb_renda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_renda.Name = "lb_renda";
            this.lb_renda.Size = new System.Drawing.Size(160, 25);
            this.lb_renda.TabIndex = 16;
            this.lb_renda.Text = "Tipo de Renda:";
            // 
            // lb_mobilado
            // 
            this.lb_mobilado.AutoSize = true;
            this.lb_mobilado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mobilado.Location = new System.Drawing.Point(586, 320);
            this.lb_mobilado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mobilado.Name = "lb_mobilado";
            this.lb_mobilado.Size = new System.Drawing.Size(221, 25);
            this.lb_mobilado.TabIndex = 14;
            this.lb_mobilado.Text = "O Imóvel é mobilado?";
            // 
            // lb_nrcdbanho
            // 
            this.lb_nrcdbanho.AutoSize = true;
            this.lb_nrcdbanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nrcdbanho.Location = new System.Drawing.Point(75, 326);
            this.lb_nrcdbanho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nrcdbanho.Name = "lb_nrcdbanho";
            this.lb_nrcdbanho.Size = new System.Drawing.Size(237, 25);
            this.lb_nrcdbanho.TabIndex = 12;
            this.lb_nrcdbanho.Text = "Nr de Casas de Banho:";
            // 
            // tb_areain
            // 
            this.tb_areain.Location = new System.Drawing.Point(256, 242);
            this.tb_areain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_areain.Name = "tb_areain";
            this.tb_areain.Size = new System.Drawing.Size(168, 26);
            this.tb_areain.TabIndex = 20;
            this.tb_areain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_nrcdbanhoin
            // 
            this.tb_nrcdbanhoin.Location = new System.Drawing.Point(334, 325);
            this.tb_nrcdbanhoin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_nrcdbanhoin.Name = "tb_nrcdbanhoin";
            this.tb_nrcdbanhoin.Size = new System.Drawing.Size(124, 26);
            this.tb_nrcdbanhoin.TabIndex = 21;
            this.tb_nrcdbanhoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_nrcdbanhoin.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_preçoin
            // 
            this.tb_preçoin.Location = new System.Drawing.Point(782, 394);
            this.tb_preçoin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_preçoin.Name = "tb_preçoin";
            this.tb_preçoin.Size = new System.Drawing.Size(229, 26);
            this.tb_preçoin.TabIndex = 24;
            this.tb_preçoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_nrquartosin
            // 
            this.tb_nrquartosin.Location = new System.Drawing.Point(856, 240);
            this.tb_nrquartosin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_nrquartosin.Name = "tb_nrquartosin";
            this.tb_nrquartosin.Size = new System.Drawing.Size(176, 26);
            this.tb_nrquartosin.TabIndex = 25;
            this.tb_nrquartosin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rb_sim
            // 
            this.rb_sim.AutoSize = true;
            this.rb_sim.Location = new System.Drawing.Point(856, 320);
            this.rb_sim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_sim.Name = "rb_sim";
            this.rb_sim.Size = new System.Drawing.Size(61, 24);
            this.rb_sim.TabIndex = 26;
            this.rb_sim.TabStop = true;
            this.rb_sim.Text = "Sim";
            this.rb_sim.UseVisualStyleBackColor = true;
            // 
            // rb_nao
            // 
            this.rb_nao.AutoSize = true;
            this.rb_nao.Location = new System.Drawing.Point(921, 320);
            this.rb_nao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_nao.Name = "rb_nao";
            this.rb_nao.Size = new System.Drawing.Size(63, 24);
            this.rb_nao.TabIndex = 27;
            this.rb_nao.TabStop = true;
            this.rb_nao.Text = "Não";
            this.rb_nao.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "m2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1014, 400);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "€";
            // 
            // form_inserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 565);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_nao);
            this.Controls.Add(this.rb_sim);
            this.Controls.Add(this.tb_nrquartosin);
            this.Controls.Add(this.tb_preçoin);
            this.Controls.Add(this.tb_nrcdbanhoin);
            this.Controls.Add(this.tb_areain);
            this.Controls.Add(this.lb_preço);
            this.Controls.Add(this.cb_rendain);
            this.Controls.Add(this.lb_renda);
            this.Controls.Add(this.lb_mobilado);
            this.Controls.Add(this.lb_nrcdbanho);
            this.Controls.Add(this.lb_nrquartos);
            this.Controls.Add(this.lb_area);
            this.Controls.Add(this.cb_finalidadein);
            this.Controls.Add(this.lb_finalidade);
            this.Controls.Add(this.cb_tipoimovelin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sairin);
            this.Controls.Add(this.btn_gravarin);
            this.Controls.Add(this.lb_inserir);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form_inserir";
            this.Text = "Inserção de Imóveis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_inserir;
        private System.Windows.Forms.Button btn_gravarin;
        private System.Windows.Forms.Button btn_sairin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_tipoimovelin;
        private System.Windows.Forms.ComboBox cb_finalidadein;
        private System.Windows.Forms.Label lb_finalidade;
        private System.Windows.Forms.Label lb_nrquartos;
        private System.Windows.Forms.Label lb_area;
        private System.Windows.Forms.Label lb_preço;
        private System.Windows.Forms.ComboBox cb_rendain;
        private System.Windows.Forms.Label lb_renda;
        private System.Windows.Forms.Label lb_mobilado;
        private System.Windows.Forms.Label lb_nrcdbanho;
        private System.Windows.Forms.TextBox tb_areain;
        private System.Windows.Forms.TextBox tb_nrcdbanhoin;
        private System.Windows.Forms.TextBox tb_preçoin;
        private System.Windows.Forms.TextBox tb_nrquartosin;
        private System.Windows.Forms.RadioButton rb_sim;
        private System.Windows.Forms.RadioButton rb_nao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}