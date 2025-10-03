using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAula
{
    public partial class form_principal : Form
    {
        public form_principal()
        {
            InitializeComponent();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            form_inserir inserir = new form_inserir();
            inserir.Show();
            this.Hide();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            form_editar editar = new form_editar();
            editar.Show();
            this.Hide();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            form_eliminar remover = new form_eliminar();
            remover.Show();
            this.Hide();
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            form_visualizar visualizar = new form_visualizar();
            visualizar.Show();
            this.Hide();
        }
    }
}
