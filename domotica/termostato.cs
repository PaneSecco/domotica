using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domotica
{
    internal class termostato
    {
        //immutabili
        private string produttore;
        private string modello;
        private int numeroserie;

        public termostato(string produttore1, string modello1, int numeroserie1)
        {
            produttore= produttore1;
            modello= modello1;
            numeroserie= numeroserie1;
        }

        public void set_stato()
        {

        }
    }
}
