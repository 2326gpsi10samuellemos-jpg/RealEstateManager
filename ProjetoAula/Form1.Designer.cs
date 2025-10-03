namespace ProjetoAula
{
    partial class form_principal
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
            this.lb_menu = new System.Windows.Forms.Label();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_menu
            // 
            this.lb_menu.AutoSize = true;
            this.lb_menu.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_menu.Location = new System.Drawing.Point(322, 49);
            this.lb_menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_menu.Name = "lb_menu";
            this.lb_menu.Size = new System.Drawing.Size(493, 68);
            this.lb_menu.TabIndex = 0;
            this.lb_menu.Text = "Seleção de Imóveis";
            // 
            // btn_inserir
            // 
            this.btn_inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserir.Location = new System.Drawing.Point(51, 158);
            this.btn_inserir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(267, 115);
            this.btn_inserir.TabIndex = 1;
            this.btn_inserir.Text = "Inserção de Imóveis";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(333, 158);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(267, 115);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.Text = "Edição de Imóveis";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visualizar.Location = new System.Drawing.Point(891, 158);
            this.btn_visualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(267, 115);
            this.btn_visualizar.TabIndex = 4;
            this.btn_visualizar.Text = "Visualização de Imóveis";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.Location = new System.Drawing.Point(609, 158);
            this.btn_remover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(267, 115);
            this.btn_remover.TabIndex = 3;
            this.btn_remover.Text = "Remoção de Imóveis";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 338);
            this.Controls.Add(this.btn_visualizar);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.lb_menu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form_principal";
            this.Text = "Menu de Imóveis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_menu;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.Button btn_remover;
    }
}

