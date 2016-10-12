using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Sala
    {
        string nume_sala;
        int capacitate;

        public string Nume_sala
        {
            get { return nume_sala; }
            set { nume_sala = value; }
        }
       

        public int Capacitate
        {
            get { return capacitate; }
            set { capacitate = value; }
        }

        public Sala(string nume_sala, int capacitate)
        {
            this.nume_sala = nume_sala;
            this.capacitate = capacitate;
        }
    }
}
