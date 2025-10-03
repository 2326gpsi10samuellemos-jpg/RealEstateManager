using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoAula
{
    public partial class form_inserir : Form
    {
        public form_inserir()
        {
            InitializeComponent();
        }

        private void btn_gravarin_Click(object sender, EventArgs e)
        {
            int a = -1;
            for (int i = 0; i < Imovel.lista.Length; i++)
            {
                if (Imovel.lista[i] == null)
                {
                    a = i;
                    break;
                }
            }
            if (a == -1)
            {
                if (Imovel.count < Imovel.lista.Length)
                    a = Imovel.count;
            }
            Imovel.lista[a] = new Imoveis();
            Imovel.lista[a].alterartipoimovel(cb_tipoimovelin.Text);
            Imovel.lista[a].alterarfinalidadeimovel(cb_finalidadein.Text);
            Imovel.lista[a].alterarareatotal(Int32.Parse(tb_areain.Text));
            Imovel.lista[a].alterarnrquartos(Int32.Parse(tb_nrquartosin.Text));
            Imovel.lista[a].alterarnrcdbanho(Int32.Parse(tb_nrcdbanhoin.Text));
            if (rb_sim.Checked) Imovel.lista[a].alterarmobilado(rb_sim.Text);
            else Imovel.lista[a].alterarmobilado(rb_nao.Text);
            Imovel.lista[a].alterarrenda(cb_rendain.Text);
            Imovel.lista[a].alterarqntrenda(Int32.Parse(tb_preçoin.Text));
            if (a == Imovel.count)
                Imovel.count++;

            form_principal menu = new form_principal();
            menu.Show();
            this.Hide();
        }

        private void btn_sairin_Click(object sender, EventArgs e)
        {
            form_principal menu = new form_principal();
            menu.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
