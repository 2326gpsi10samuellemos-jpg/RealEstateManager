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
    public partial class form_eliminar : Form
    {
        public form_eliminar()
        {
            InitializeComponent();
        }

        private void btn_gravarre_Click(object sender, EventArgs e)
        {
            int nrimovel = cb_nrimovelre.SelectedIndex;
            if (Imovel.lista[nrimovel] != null)
            {
                    for (int i = nrimovel; i < 20; i++)
                    {
                        if (i != 19)
                            Imovel.lista[i] = Imovel.lista[i + 1];
                        else
                            Imovel.lista[i] = null;
                    }

                    form_principal menu = new form_principal();
                    menu.Show();
                    this.Hide();
            }
            else
            {
                MessageBox.Show("Insira um número que contenha um Imóvel!");
            }
        }

        private void btn_sairre_Click(object sender, EventArgs e)
        {
            form_principal menu = new form_principal();
            menu.Show();
            this.Hide();
        }
    }
}
