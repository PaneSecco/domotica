using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domotica
{
    public class telecomando
    {
        //immutabili
        private string produttore;
        private string modello;
        private string modalita;

        private televisione tv;

        public telecomando(string produttore1, string modello1, string modalita1, televisione tv1)
        {
            produttore = produttore1;
            modello = modello1;
            modalita = modalita1;

            set_tv(tv1);
        }

        private void set_tv(televisione tv1)
        {
            tv = tv1;
        }
        private void setcanale(int cambio)
        {
            tv.setcanale(cambio);
        }

        private int getcanale()
        {
            return tv.getcanale();
        }

        private void cambio_stato()
        {
            tv.cambio_stato();
        }

        private bool get_stato()
        {
            return tv.get_stato();
        }

        private void volume_su()
        {
            tv.volume_su();
        }
        private void volume_giu()
        {
            tv.volume_giu();
        }

        private int get_volume()
        {
            return tv.get_volume();
        }
        private void set_specifiche(string produttore1, string modello1, string modalita1)
        {
            produttore = produttore1;
            modello = modello1;
            modalita = modalita1;
        }
        private string[] get_specifiche()
        {
            string[] array = { produttore, modello, modalita };
            return array;
        }

    }
}
