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
        private caldaia cal;

        public termostato(string produttore1, string modello1, int numeroserie1)
        {
            produttore= produttore1;
            modello= modello1;
            numeroserie= numeroserie1;

            set_caldaia(cal);
        }

        public void set_caldaia(caldaia cal1)
        {
            cal = cal1;
        }
        public void set_stato()
        {
            cal.set_stato();
        }

        public void set_riscaldamento()
        {
            cal.set_riscaldamento();
        }

        public void set_temprisc(int temp)
        {
            cal.set_temprisc(temp);
        }

        public void set_tempacqua(int temp)
        {
            cal.set_tempacqua(temp);
        }

        public int get_temprisc()
        {
            return cal.get_temprisc();
        }

        public int get_tempacqua()
        {
            return cal.get_tempacqua();
        }

        /*      ???????????????
        public void get_statofunz()
        {

        }
        */
    }
}
