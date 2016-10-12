using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Departament:Facultate
    {
        string nume_departament;

        public string Nume_departament
        {
            get { return nume_departament; }
            set { nume_departament = value; }
        }

        public Departament(string nume,string adresa,string email,string telefon,string nume_departament):base(nume,adresa,email,telefon)
        {
            this.nume_departament = nume_departament;
        }
    }
}
