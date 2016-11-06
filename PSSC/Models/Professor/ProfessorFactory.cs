using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Professor
{
    class ProfessorFactory
    {
         public static readonly ProfessorFactory Instance = new ProfessorFactory();

         private ProfessorFactory()
        {

        }
    }
}
