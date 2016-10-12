using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Orar
    {
        string zi;
        Disciplina disciplina;
        int durata;
        int ora_start;
        Sala sala;

        internal Sala Sala
        {
            get { return sala; }
            set { sala = value; }
        }

        public int Ora_start
        {
            get { return ora_start; }
            set { ora_start = value; }
        }
       

        public int Durata
        {
            get { return durata; }
            set { durata = value; }
        }
        

        internal Disciplina Disciplina
        {
            get { return disciplina; }
            set { disciplina = value; }
        }
       

        public string Zi
        {
            get { return zi; }
            set { zi = value; }
        }
        

        public Orar(string zi,Disciplina disciplina,int durata,int ora_start,Sala sala)
        {
            this.zi = zi;
            this.disciplina = disciplina;
            this.durata = durata;
            this.ora_start = ora_start;
            this.sala = sala;
        }
    }
}
