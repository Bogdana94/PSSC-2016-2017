using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Profesor:Persoana
    {
        Disciplina disciplina;
        int vechime;

        internal Disciplina Disciplina
        {
            get { return disciplina; }
            set { disciplina = value; }
        }
       

        public int Vechime
        {
            get { return vechime; }
            set { vechime = value; }
        }

        public Profesor(string nume, string studii, string adresa, string email,string telefon, Departament departament,Disciplina disciplina,int vechime):base(nume,studii,adresa,email,telefon,departament)
        {
            this.disciplina=disciplina;
            this.vechime=vechime;

        }
       
    }
}
