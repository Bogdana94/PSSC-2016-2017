using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Nota
    {
        string disciplina;
        int nota_evaluare;
        int nota_activitate_parcurs;

        public Nota(string disciplina, int nota_evaluare, int nota_activitate_parcurs)
        {
            this.disciplina = disciplina;
            this.nota_evaluare = nota_evaluare;
            this.nota_activitate_parcurs = nota_activitate_parcurs;
        }

    }
}
