using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using Models.Generics.Exceptions;

namespace Models.Subject
{
    class SubjectFactory
    {
        public static readonly SubjectFactory Instance = new SubjectFactory();

        private SubjectFactory()
        {

        }

        public Subject CreateSubject(SubjectSituation sub)
        {
            Contract.Requires<ArgumentNullException>(sub != null);
          


            var subject = new Subject(
                                       new SubjectSituation(),
                                       new SubjectInformation());
            return subject;
        }

        public Models.Students.Student CreeazaStudnet(string numarMatricol, string numeStudent)
        {
            Contract.Requires<InvalidArgumentException>(numarMatricol.Length==7,"Registration number must be 7 characters long");

            return new Models.Students.Student(new Models.Generics.RegistrationNumber(numarMatricol), new Models.Generics.PlainText(numeStudent));
        }
    }
}
