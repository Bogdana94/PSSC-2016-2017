using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Disciplina
    {
        string nume_disciplina;
        int an_studiu;

        public string Nume_disciplina
        {
            get { return nume_disciplina; }
            set { nume_disciplina = value; }
        }
       

        public int An_studiu
        {
            get { return an_studiu; }
            set { an_studiu = value; }
        }
       
        public Disciplina(string nume_disciplina,int an_studiu)
        {
            this.nume_disciplina = nume_disciplina;
            this.an_studiu = an_studiu;
        }
    }
}
