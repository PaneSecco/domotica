using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domotica
{
    internal class caldaia
    {
        //immutabili
        private string produttore;
        private string modello;
        private int numeroserie;
        private int data;
        private int tempmaxrisc;
        private int tempminrisc;
        private int tempmaxacqua;
        private int tempminacqua;

        //mutabili
        private bool stato;
        private bool riscaldamento;
        private int temprisc;
        private int tempacqua;

        public caldaia(string produttore1,string modello1, int numeroserie1, int data1, int tempminrisc1, int tempmaxrisc1, int tempminacqua1, int tempmaxacqua1)
        {
            produttore=produttore1;
            modello=modello1;
            numeroserie=numeroserie1;
            data=data1;
            tempminrisc = tempminrisc1;
            tempmaxrisc =tempmaxrisc1;
            tempminacqua = tempminacqua1;
            tempmaxacqua = tempmaxacqua1;

            stato = false;
            riscaldamento=false;
            tempacqua=0;
            temprisc = 0;
        }

        public void set_stato()
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

        public void set_riscaldamento()
        {
            if (stato != false)
            {
                if (riscaldamento == false)
                {
                    riscaldamento = true;
                }
                else
                {
                    riscaldamento = false;
                }
            }
        }
        public bool get_riscaldamento()
        {
            return riscaldamento;
        }

        public void set_temprisc(int temp)
        {
            if (stato != false) 
            {
                if (temp > tempminrisc && temp < tempmaxrisc)
                {
                    temprisc = temp;
                }
            }
        }

        public int get_temprisc()
        {
            return temprisc;
        }

        public void set_tempacqua(int temp)
        {
            if (stato != false)
            {
                if (temp > tempminacqua && temp < tempmaxacqua)
                {
                    tempacqua = temp;
                }
            }
        }

        public int get_tempacqua()
        {
            return tempacqua;
        }
    }
}
