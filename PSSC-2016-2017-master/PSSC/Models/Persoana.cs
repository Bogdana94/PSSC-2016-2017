using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Persoana
    {
        string nume;
        string studii;
        string adresa;
        string email;
        string telefon;
        Departament departament;

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        

        public string Studii
        {
            get { return studii; }
            set { studii = value; }
        }
        

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }
        

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        

        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        

        internal Departament Departament
        {
            get { return departament; }
            set { departament = value; }
        }

        public Persoana(string nume, string studii, string adresa, string email,string telefon, Departament departament)
        {
            this.nume = nume;
            this.studii = studii;
            this.adresa = adresa;
            this.email = email;
            this.telefon = telefon;
            this.departament = departament;
        }

    }
}
