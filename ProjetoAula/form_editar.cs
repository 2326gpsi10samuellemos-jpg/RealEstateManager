using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAula
{
    public partial class form_editar : Form
    {
        public form_editar()
        {
            InitializeComponent();
        }

        private void btn_gravarin_Click(object sender, EventArgs e)
        {
            int nrimovel = cb_nrimoveledi.SelectedIndex;
            if (Imovel.lista[nrimovel] != null)
            {
                Imovel.lista[nrimovel] = new Imoveis();
                Imovel.lista[nrimovel].alterartipoimovel(cb_tipoimoveledi.Text);
                Imovel.lista[nrimovel].alterarfinalidadeimovel(cb_finalidadeedi.Text);
                Imovel.lista[nrimovel].alterarareatotal(Int32.Parse(tb_areaedi.Text));
                Imovel.lista[nrimovel].alterarnrquartos(Int32.Parse(tb_nrquartosedi.Text));
                Imovel.lista[nrimovel].alterarnrcdbanho(Int32.Parse(tb_nrcdbanhoedi.Text));
                if (rb_simedi.Checked) Imovel.lista[nrimovel].alterarmobilado(rb_simedi.Text);
                else Imovel.lista[nrimovel].alterarmobilado(rb_naoedi.Text);
                Imovel.lista[nrimovel].alterarrenda(cb_rendaedi.Text);
                Imovel.lista[nrimovel].alterarqntrenda(Int32.Parse(tb_preçoedi.Text));
            }
            else
            {
                MessageBox.Show("Insira um número que contenha um Imóvel!");
            }

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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void form_editar_Load(object sender, EventArgs e)
        {
            cb_nrimoveledi.SelectedIndexChanged += Cb_nrimoveledi_SelectedIndexChanged;
        }

        private void Cb_nrimoveledi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nrimovel = cb_nrimoveledi.SelectedIndex;
            if (nrimovel >= 0 && Imovel.lista[nrimovel] != null)
            {
                cb_tipoimoveledi.Text = Imovel.lista[nrimovel].acedertipoimovel();
                cb_finalidadeedi.Text = Imovel.lista[nrimovel].acederfinalidadeimovel();
                tb_areaedi.Text = Imovel.lista[nrimovel].acederareatotal().ToString();
                tb_nrquartosedi.Text = Imovel.lista[nrimovel].acedernrquartos().ToString();
                tb_nrcdbanhoedi.Text = Imovel.lista[nrimovel].acedernrcdbanho().ToString();
                if (Imovel.lista[nrimovel].acedermobilado() == "Sim")
                    rb_simedi.Checked = true;
                else
                    rb_naoedi.Checked = true;
                cb_rendaedi.Text = Imovel.lista[nrimovel].acederrenda();
                tb_preçoedi.Text = Imovel.lista[nrimovel].acederqntrenda().ToString();
            }
            else
            {
                MessageBox.Show("O número selecionado não contem um imóvel!.");
                cb_tipoimoveledi.Text = string.Empty;
                cb_finalidadeedi.Text = string.Empty;
                tb_areaedi.Text = string.Empty;
                tb_nrquartosedi.Text = string.Empty;
                tb_nrcdbanhoedi.Text = string.Empty;
                rb_simedi.Checked = false;
                rb_naoedi.Checked = false;
                cb_rendaedi.Text = string.Empty;
                tb_preçoedi.Text = string.Empty;
            }
        }

    }
}
