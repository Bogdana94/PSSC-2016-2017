using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Facultate
    {
        string nume_facultate;
        string adresa_facultate;
        string email_facultate;
        string telefon_facultate;

        public string Telefon_facultate
        {
            get { return telefon_facultate; }
            set { telefon_facultate = value; }
        }

        public string Email_facultate
        {
            get { return email_facultate; }
            set { email_facultate = value; }
        }
        

        public string Adresa_facultate
        {
            get { return adresa_facultate; }
            set { adresa_facultate = value; }
        }
       

        public string Nume_facultate
        {
            get { return nume_facultate; }
            set { nume_facultate = value; }
        }
        

        public Facultate(string nume,string adresa,string email,string telefon)
        {
            this.nume_facultate = nume;
            this.adresa_facultate = adresa;
            this.email_facultate = email;
            this.telefon_facultate = telefon;
        }

    }
}
