using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Profesor
    {
        string nume;
        string telefon;
        string email;
        int vechime;
        List<Disciplina> listaDiscipline = new List<Disciplina>();

        public Profesor(string nume, string email, string telefon, int vechime)
        {
            this.nume = nume;
            this.email = email;
            this.telefon = telefon;
            this.vechime = vechime;

        }

        public void adauga_note(Student s, Disciplina d, Nota n)
        {

        }

        public void adauga_nota_marire(Student s, Disciplina d, Nota n)
        {

        }

        public void selectare_proportie(Disciplina d, proportie p)
        {

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

        public int Vechime
        {
            get { return vechime; }
            set { vechime = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

       
       
    }
}
