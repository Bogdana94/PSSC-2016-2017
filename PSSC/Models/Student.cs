using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student:Persoana
    {
        int an_studiu;
        float medie;
        Orar orar;

        public int An_studiu
        {
            get { return an_studiu; }
            set { an_studiu = value; }
        }
       

        public float Medie
        {
            get { return medie; }
            set { medie = value; }
        }
       

        internal Orar Orar
        {
            get { return orar; }
            set { orar = value; }
        }

        public Student(string nume, string studii, string adresa, string email,string telefon, Departament departament, int an_studiu,float medie,Orar orar):base(nume,studii,adresa,email,telefon,departament)
        {
            this.an_studiu = an_studiu;
            this.medie = medie;
            this.orar = orar;
        }
    }
}
