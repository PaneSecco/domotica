using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domotica
{
    public class televisione
    {
        //mutabili
        private int canale;
        private int volume;
        private bool stato;

        //immutabili
        private string produttore;
        private string modello;
        private string[] connettori;
        private string risoluzione;

        private float prezzo;

        public float Prezzo
        {
            set
            {
                return prezzo;
            }

            get
            {
                prezzo=value;
            }
        }

        public televisione(string produttore1, string modello1, string [] connettori1, string risoluzione1)
        {
            produttore = produttore1;   
            modello = modello1;
            connettori = connettori1;
            risoluzione = risoluzione1;

            canale = 0;
            volume = 0;
            stato = false;
        }

        public void setcanale(int cambio)
        {
            canale = cambio;
        }
        public int getcanale()
        {
            return canale;
        }
        public void cambio_stato()
        {
            if (stato == false)
            {
                stato = true;
            }
            else
            {
                stato = false;
            }
        }
        public bool get_stato()
        {
            return stato;
        }
        public void volume_su()
        {
            volume = volume + 1;
        }
        public void volume_giu()
        {
            volume = volume - 1;
        }

        public int get_volume()
        {
            return volume;
        }
    }
}
