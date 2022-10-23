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

        public televisione(string produttore1, string modello1, string [] connettori1, string risoluzione1)
        {
            produttore = produttore1;   
            modello = modello1;
            connettori = connettori1;
            risoluzione = risoluzione1;
        }

        private void setcanale(int cambio)
        {
            canale = cambio;
        }
        private int getcanale()
        {
            return canale;
        }
        private void cambio_stato()
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
        private bool get_stato()
        {
            return stato;
        }
        private void volume_su()
        {
            volume = volume + 1;
        }
        private void volume_giu()
        {
            volume = volume - 1;
        }

        private int get_volume()
        {
            return volume;
        }
    }
}
