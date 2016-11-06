using Models.Generics.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Students
{
    class StudentFactory
    {
        public static readonly StudentFactory Instance = new StudentFactory();

        private StudentFactory()
        {

        }

        public Student createStudent(string regNumber, string name)
        {
            Contract.Requires<ArgumentNullException>(regNumber != null);
            Contract.Requires<InvalidArgumentException>(regNumber.Length == 7, "RegistrationNumber must be 7 characters long");
            Contract.Requires<ArgumentCannotBeEmptyStringException>(name != null);

            var student = new Models.Students.Student(new Models.Generics.RegistrationNumber(regNumber), new Models.Generics.PlainText(name));

            return student;
        }
    }


}
