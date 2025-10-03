namespace ProjetoAula
{
    partial class form_editar
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
            this.lb_editar = new System.Windows.Forms.Label();
            this.tb_nrquartosedi = new System.Windows.Forms.TextBox();
            this.tb_preçoedi = new System.Windows.Forms.TextBox();
            this.tb_nrcdbanhoedi = new System.Windows.Forms.TextBox();
            this.tb_areaedi = new System.Windows.Forms.TextBox();
            this.lb_preço = new System.Windows.Forms.Label();
            this.cb_rendaedi = new System.Windows.Forms.ComboBox();
            this.lb_renda = new System.Windows.Forms.Label();
            this.lb_mobilado = new System.Windows.Forms.Label();
            this.lb_nrcdbanho = new System.Windows.Forms.Label();
            this.lb_nrquartos = new System.Windows.Forms.Label();
            this.lb_area = new System.Windows.Forms.Label();
            this.cb_finalidadeedi = new System.Windows.Forms.ComboBox();
            this.lb_finalidade = new System.Windows.Forms.Label();
            this.cb_tipoimoveledi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sairedi = new System.Windows.Forms.Button();
            this.btn_gravaredi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_nrimoveledi = new System.Windows.Forms.ComboBox();
            this.rb_naoedi = new System.Windows.Forms.RadioButton();
            this.rb_simedi = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // lb_editar
            // 
            this.lb_editar.AutoSize = true;
            this.lb_editar.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_editar.Location = new System.Drawing.Point(334, 34);
            this.lb_editar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_editar.Name = "lb_editar";
            this.lb_editar.Size = new System.Drawing.Size(457, 68);
            this.lb_editar.TabIndex = 1;
            this.lb_editar.Text = "Edição de Imóveis";
            // 
            // tb_nrquartosedi
            // 
            this.tb_nrquartosedi.Location = new System.Drawing.Point(898, 297);
            this.tb_nrquartosedi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_nrquartosedi.Name = "tb_nrquartosedi";
            this.tb_nrquartosedi.Size = new System.Drawing.Size(176, 26);
            this.tb_nrquartosedi.TabIndex = 44;
            this.tb_nrquartosedi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_preçoedi
            // 
            this.tb_preçoedi.Location = new System.Drawing.Point(824, 451);
            this.tb_preçoedi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_preçoedi.Name = "tb_preçoedi";
            this.tb_preçoedi.Size = new System.Drawing.Size(229, 26);
            this.tb_preçoedi.TabIndex = 43;
            this.tb_preçoedi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_nrcdbanhoedi
            // 
            this.tb_nrcdbanhoedi.Location = new System.Drawing.Point(376, 382);
            this.tb_nrcdbanhoedi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_nrcdbanhoedi.Name = "tb_nrcdbanhoedi";
            this.tb_nrcdbanhoedi.Size = new System.Drawing.Size(124, 26);
            this.tb_nrcdbanhoedi.TabIndex = 40;
            this.tb_nrcdbanhoedi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_areaedi
            // 
            this.tb_areaedi.Location = new System.Drawing.Point(298, 298);
            this.tb_areaedi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_areaedi.Name = "tb_areaedi";
            this.tb_areaedi.Size = new System.Drawing.Size(168, 26);
            this.tb_areaedi.TabIndex = 39;
            this.tb_areaedi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_preço
            // 
            this.lb_preço.AutoSize = true;
            this.lb_preço.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_preço.Location = new System.Drawing.Point(628, 452);
            this.lb_preço.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_preço.Name = "lb_preço";
            this.lb_preço.Size = new System.Drawing.Size(174, 25);
            this.lb_preço.TabIndex = 38;
            this.lb_preço.Text = "Preço do Imóvel:";
            // 
            // cb_rendaedi
            // 
            this.cb_rendaedi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rendaedi.FormattingEnabled = true;
            this.cb_rendaedi.Items.AddRange(new object[] {
            "Aluguer",
            "Pagamento à vista"});
            this.cb_rendaedi.Location = new System.Drawing.Point(298, 451);
            this.cb_rendaedi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_rendaedi.Name = "cb_rendaedi";
            this.cb_rendaedi.Size = new System.Drawing.Size(202, 28);
            this.cb_rendaedi.TabIndex = 37;
            // 
            // lb_renda
            // 
            this.lb_renda.AutoSize = true;
            this.lb_renda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_renda.Location = new System.Drawing.Point(117, 452);
            this.lb_renda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_renda.Name = "lb_renda";
            this.lb_renda.Size = new System.Drawing.Size(160, 25);
            this.lb_renda.TabIndex = 36;
            this.lb_renda.Text = "Tipo de Renda:";
            // 
            // lb_mobilado
            // 
            this.lb_mobilado.AutoSize = true;
            this.lb_mobilado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mobilado.Location = new System.Drawing.Point(628, 377);
            this.lb_mobilado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mobilado.Name = "lb_mobilado";
            this.lb_mobilado.Size = new System.Drawing.Size(221, 25);
            this.lb_mobilado.TabIndex = 35;
            this.lb_mobilado.Text = "O Imóvel é mobilado?";
            // 
            // lb_nrcdbanho
            // 
            this.lb_nrcdbanho.AutoSize = true;
            this.lb_nrcdbanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nrcdbanho.Location = new System.Drawing.Point(117, 383);
            this.lb_nrcdbanho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nrcdbanho.Name = "lb_nrcdbanho";
            this.lb_nrcdbanho.Size = new System.Drawing.Size(237, 25);
            this.lb_nrcdbanho.TabIndex = 34;
            this.lb_nrcdbanho.Text = "Nr de Casas de Banho:";
            // 
            // lb_nrquartos
            // 
            this.lb_nrquartos.AutoSize = true;
            this.lb_nrquartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nrquartos.Location = new System.Drawing.Point(628, 300);
            this.lb_nrquartos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nrquartos.Name = "lb_nrquartos";
            this.lb_nrquartos.Size = new System.Drawing.Size(253, 25);
            this.lb_nrquartos.TabIndex = 33;
            this.lb_nrquartos.Text = "Nr de Quartos do Imóvel:";
            // 
            // lb_area
            // 
            this.lb_area.AutoSize = true;
            this.lb_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_area.Location = new System.Drawing.Point(117, 298);
            this.lb_area.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_area.Name = "lb_area";
            this.lb_area.Size = new System.Drawing.Size(164, 25);
            this.lb_area.TabIndex = 32;
            this.lb_area.Text = "Área do Imóvel:";
            // 
            // cb_finalidadeedi
            // 
            this.cb_finalidadeedi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_finalidadeedi.FormattingEnabled = true;
            this.cb_finalidadeedi.Items.AddRange(new object[] {
            "Residência",
            "Comercial",
            "Industrial",
            "Lazer"});
            this.cb_finalidadeedi.Location = new System.Drawing.Point(873, 217);
            this.cb_finalidadeedi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_finalidadeedi.Name = "cb_finalidadeedi";
            this.cb_finalidadeedi.Size = new System.Drawing.Size(202, 28);
            this.cb_finalidadeedi.TabIndex = 31;
            // 
            // lb_finalidade
            // 
            this.lb_finalidade.AutoSize = true;
            this.lb_finalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_finalidade.Location = new System.Drawing.Point(628, 218);
            this.lb_finalidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_finalidade.Name = "lb_finalidade";
            this.lb_finalidade.Size = new System.Drawing.Size(218, 25);
            this.lb_finalidade.TabIndex = 30;
            this.lb_finalidade.Text = "Finalidade do Imóvel:";
            // 
            // cb_tipoimoveledi
            // 
            this.cb_tipoimoveledi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipoimoveledi.FormattingEnabled = true;
            this.cb_tipoimoveledi.Items.AddRange(new object[] {
            "Casa",
            "Apartamento",
            "Terreno"});
            this.cb_tipoimoveledi.Location = new System.Drawing.Point(298, 217);
            this.cb_tipoimoveledi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_tipoimoveledi.Name = "cb_tipoimoveledi";
            this.cb_tipoimoveledi.Size = new System.Drawing.Size(202, 28);
            this.cb_tipoimoveledi.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tipo de Imóvel:";
            // 
            // btn_sairedi
            // 
            this.btn_sairedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sairedi.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_sairedi.Location = new System.Drawing.Point(963, 531);
            this.btn_sairedi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_sairedi.Name = "btn_sairedi";
            this.btn_sairedi.Size = new System.Drawing.Size(140, 46);
            this.btn_sairedi.TabIndex = 27;
            this.btn_sairedi.Text = "Sair";
            this.btn_sairedi.UseVisualStyleBackColor = true;
            this.btn_sairedi.Click += new System.EventHandler(this.btn_sairin_Click);
            // 
            // btn_gravaredi
            // 
            this.btn_gravaredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravaredi.Location = new System.Drawing.Point(814, 531);
            this.btn_gravaredi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_gravaredi.Name = "btn_gravaredi";
            this.btn_gravaredi.Size = new System.Drawing.Size(140, 46);
            this.btn_gravaredi.TabIndex = 26;
            this.btn_gravaredi.Text = "Gravar";
            this.btn_gravaredi.UseVisualStyleBackColor = true;
            this.btn_gravaredi.Click += new System.EventHandler(this.btn_gravarin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Número do Imóvel:";
            // 
            // cb_nrimoveledi
            // 
            this.cb_nrimoveledi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nrimoveledi.FormattingEnabled = true;
            this.cb_nrimoveledi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cb_nrimoveledi.Location = new System.Drawing.Point(508, 138);
            this.cb_nrimoveledi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_nrimoveledi.Name = "cb_nrimoveledi";
            this.cb_nrimoveledi.Size = new System.Drawing.Size(97, 28);
            this.cb_nrimoveledi.TabIndex = 46;
            // 
            // rb_naoedi
            // 
            this.rb_naoedi.AutoSize = true;
            this.rb_naoedi.Location = new System.Drawing.Point(963, 375);
            this.rb_naoedi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_naoedi.Name = "rb_naoedi";
            this.rb_naoedi.Size = new System.Drawing.Size(63, 24);
            this.rb_naoedi.TabIndex = 48;
            this.rb_naoedi.TabStop = true;
            this.rb_naoedi.Text = "Não";
            this.rb_naoedi.UseVisualStyleBackColor = true;
            // 
            // rb_simedi
            // 
            this.rb_simedi.AutoSize = true;
            this.rb_simedi.Location = new System.Drawing.Point(898, 375);
            this.rb_simedi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_simedi.Name = "rb_simedi";
            this.rb_simedi.Size = new System.Drawing.Size(61, 24);
            this.rb_simedi.TabIndex = 47;
            this.rb_simedi.TabStop = true;
            this.rb_simedi.Text = "Sim";
            this.rb_simedi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 308);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "m2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1056, 457);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "€";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // form_editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 615);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_naoedi);
            this.Controls.Add(this.rb_simedi);
            this.Controls.Add(this.cb_nrimoveledi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nrquartosedi);
            this.Controls.Add(this.tb_preçoedi);
            this.Controls.Add(this.tb_nrcdbanhoedi);
            this.Controls.Add(this.tb_areaedi);
            this.Controls.Add(this.lb_preço);
            this.Controls.Add(this.cb_rendaedi);
            this.Controls.Add(this.lb_renda);
            this.Controls.Add(this.lb_mobilado);
            this.Controls.Add(this.lb_nrcdbanho);
            this.Controls.Add(this.lb_nrquartos);
            this.Controls.Add(this.lb_area);
            this.Controls.Add(this.cb_finalidadeedi);
            this.Controls.Add(this.lb_finalidade);
            this.Controls.Add(this.cb_tipoimoveledi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sairedi);
            this.Controls.Add(this.btn_gravaredi);
            this.Controls.Add(this.lb_editar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form_editar";
            this.Text = "Edição de Imóveis";
            this.Load += new System.EventHandler(this.form_editar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_editar;
        private System.Windows.Forms.TextBox tb_nrquartosedi;
        private System.Windows.Forms.TextBox tb_preçoedi;
        private System.Windows.Forms.TextBox tb_nrcdbanhoedi;
        private System.Windows.Forms.TextBox tb_areaedi;
        private System.Windows.Forms.Label lb_preço;
        private System.Windows.Forms.ComboBox cb_rendaedi;
        private System.Windows.Forms.Label lb_renda;
        private System.Windows.Forms.Label lb_mobilado;
        private System.Windows.Forms.Label lb_nrcdbanho;
        private System.Windows.Forms.Label lb_nrquartos;
        private System.Windows.Forms.Label lb_area;
        private System.Windows.Forms.ComboBox cb_finalidadeedi;
        private System.Windows.Forms.Label lb_finalidade;
        private System.Windows.Forms.ComboBox cb_tipoimoveledi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sairedi;
        private System.Windows.Forms.Button btn_gravaredi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_nrimoveledi;
        private System.Windows.Forms.RadioButton rb_naoedi;
        private System.Windows.Forms.RadioButton rb_simedi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}