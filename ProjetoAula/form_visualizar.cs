using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProjetoAula
{
    public partial class form_visualizar : Form
    {
        public form_visualizar()
        {
            InitializeComponent();
        }

        private void btn_sairvisu_Click(object sender, EventArgs e)
        {
            form_principal menu = new form_principal();
            menu.Show();
            this.Hide();
        }


        private void lb_tipoimovelvisu_Click(object sender, EventArgs e)
        {
        }
        private void form_inserir_Load(object sender, EventArgs e)
        {
            AtualizarConteudo();
        }

        private void AtualizarConteudo()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Imovel.count; i++)
            {
                if (Imovel.lista[i] != null){
                    dataGridView1.Rows.Add(
                        $"Imóvel: {i + 1}",
                        Imovel.lista[i].acedertipoimovel(),
                        Imovel.lista[i].acederfinalidadeimovel(),
                        Imovel.lista[i].acederareatotal(),
                        Imovel.lista[i].acedernrquartos(),
                        Imovel.lista[i].acedernrcdbanho(),
                        Imovel.lista[i].acedermobilado(),
                        Imovel.lista[i].acederrenda(),
                        Imovel.lista[i].acederqntrenda()
                    );
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lb_finalidadevisu_Click(object sender, EventArgs e)
        {

        }
    }
}
