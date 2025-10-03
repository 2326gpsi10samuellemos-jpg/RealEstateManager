namespace ProjetoAula
{
    partial class form_eliminar
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
            this.lb_remover = new System.Windows.Forms.Label();
            this.cb_nrimovelre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sairre = new System.Windows.Forms.Button();
            this.btn_gravarre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_remover
            // 
            this.lb_remover.AutoSize = true;
            this.lb_remover.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_remover.Location = new System.Drawing.Point(125, 22);
            this.lb_remover.Name = "lb_remover";
            this.lb_remover.Size = new System.Drawing.Size(380, 45);
            this.lb_remover.TabIndex = 1;
            this.lb_remover.Text = "Eliminação de Imóveis";
            // 
            // cb_nrimovelre
            // 
            this.cb_nrimovelre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nrimovelre.FormattingEnabled = true;
            this.cb_nrimovelre.Items.AddRange(new object[] {
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
            this.cb_nrimovelre.Location = new System.Drawing.Point(388, 113);
            this.cb_nrimovelre.Name = "cb_nrimovelre";
            this.cb_nrimovelre.Size = new System.Drawing.Size(66, 21);
            this.cb_nrimovelre.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Número do Imóvel a remover:";
            // 
            // btn_sairre
            // 
            this.btn_sairre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sairre.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_sairre.Location = new System.Drawing.Point(525, 174);
            this.btn_sairre.Name = "btn_sairre";
            this.btn_sairre.Size = new System.Drawing.Size(93, 30);
            this.btn_sairre.TabIndex = 50;
            this.btn_sairre.Text = "Sair";
            this.btn_sairre.UseVisualStyleBackColor = true;
            this.btn_sairre.Click += new System.EventHandler(this.btn_sairre_Click);
            // 
            // btn_gravarre
            // 
            this.btn_gravarre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravarre.Location = new System.Drawing.Point(408, 174);
            this.btn_gravarre.Name = "btn_gravarre";
            this.btn_gravarre.Size = new System.Drawing.Size(111, 30);
            this.btn_gravarre.TabIndex = 49;
            this.btn_gravarre.Text = "Eliminar";
            this.btn_gravarre.UseVisualStyleBackColor = true;
            this.btn_gravarre.Click += new System.EventHandler(this.btn_gravarre_Click);
            // 
            // form_eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 227);
            this.Controls.Add(this.btn_sairre);
            this.Controls.Add(this.btn_gravarre);
            this.Controls.Add(this.cb_nrimovelre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_remover);
            this.Name = "form_eliminar";
            this.Text = "Eliminação de Imóveis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_remover;
        private System.Windows.Forms.ComboBox cb_nrimovelre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_sairre;
        private System.Windows.Forms.Button btn_gravarre;
    }
}