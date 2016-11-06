using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using Models.Generics.Exceptions;

namespace Models.Deanship
{
    //factory for studyYear root
    class StudyYearFactory
    {
        public static readonly StudyYearFactory Instance = new StudyYearFactory();

        private StudyYearFactory()
        {

        }

        public StudyYear CreateStudyYear(List<Subject.Subject> definedSubjects)
        {
            Contract.Requires<ArgumentCannotBeEmptyStringException>(definedSubjects != null, " Subject name must not be null");


            var studyYear = new StudyYear(definedSubjects);
            return studyYear;
        }
    }
}
