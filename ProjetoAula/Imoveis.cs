using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAula
{
    public class Imoveis
    {
        private string tipoimovel; //casa, apartamento, terreno
        private string finalidadeimovel; //residencia, comercial, industrial, lazer
        private int areatotal;
        private int nrquartos; 
        private int nrcdbanho;
        private string mobilado; //dizer se está mobilado ou não
        private string renda; //aluguer ou pagamento á vista
        private int qntrenda; //preço p/mes ou total
        public void alterartipoimovel(string tipoimovel)
        {
            this.tipoimovel = tipoimovel;
        }
        public void alterarfinalidadeimovel(string finalidadeimovel)
        {
            this.finalidadeimovel = finalidadeimovel;
        }
        public void alterarmobilado(string mobilado)
        {
            this.mobilado = mobilado;
        }
        public void alterarareatotal(int areatotal)
        {
            this.areatotal = areatotal;
        }
        public void alterarnrquartos(int nrquartos)
        {
            this.nrquartos = nrquartos;
        }
        public void alterarnrcdbanho(int nrcdbanho)
        {
            this.nrcdbanho = nrcdbanho;
        }
        public void alterarrenda(string renda)
        {
            this.renda = renda;
        }
        public void alterarqntrenda(int qntrenda)
        {
            this.qntrenda = qntrenda;
        }
        public string acedertipoimovel()
        {
            return this.tipoimovel;
        }
        public string acederfinalidadeimovel()
        {
            return this.finalidadeimovel;
        }
        public string acedermobilado()
        {
            return this.mobilado;
        }
        public string acederrenda()
        {
            return this.renda;
        }
        public int acederareatotal()
        {
            return this.areatotal;
        }
        public int acedernrquartos()
        {
            return this.nrquartos;
        }
        public int acedernrcdbanho()
        {
            return this.nrcdbanho;
        }
        public int acederqntrenda()
        {
            return this.qntrenda;
        }
    }
    public static class Imovel
    {
        public static int count = 0;
        public static Imoveis[] lista = new Imoveis[20];
    }
}
