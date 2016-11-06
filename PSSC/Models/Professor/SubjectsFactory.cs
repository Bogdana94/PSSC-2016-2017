using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Professor
{
    //factory for subjects root
    class SubjectsFactory
    {
        public static readonly SubjectsFactory Instance = new SubjectsFactory();

        private SubjectsFactory()
        {

        }

        
        public Subjects CreateSubjects(List<Subject.Subject> subjectName, int numarator, int numitor)
        {
            Contract.Requires<ArgumentNullException>(subjectName != null);

            var subjects = new Subjects(new List<Subject.Subject>(subjectName), new Generics.Proportion(numarator, numitor));
            return subjects;


        }
    }
}
