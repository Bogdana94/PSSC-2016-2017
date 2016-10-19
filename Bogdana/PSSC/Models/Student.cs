using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student
    {
        string nume;
        string telefon;
        string email;
        int an_studiu;
        List<Disciplina> listaDiscipline = new List<Disciplina>();
        List<Nota> listaNote = new List<Nota>();

        public Student(string nume, string telefon, string email,int an_studiu)
        {
            this.nume = nume;
            this.telefon = telefon;
            this.email = email;
            this.an_studiu = an_studiu;
        }
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int An_studiu
        {
            get { return an_studiu; }
            set { an_studiu = value; }
        }
    }
}
