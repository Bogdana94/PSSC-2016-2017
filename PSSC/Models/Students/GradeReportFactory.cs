using Models.Generics.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Students
{
    //factory for gradeReport root
    class GradeReportFactory
    {
        public static readonly GradeReportFactory Instance = new GradeReportFactory();

        private GradeReportFactory()
        {

        }

        public Models.Students.Student createGradeReport(string regNumber, string name)
        {
            Contract.Requires<ArgumentNullException>(regNumber != null);
            Contract.Requires<InvalidArgumentException>(regNumber.Length == 7, "RegistrationNumber must be 7 characters long");
            Contract.Requires<ArgumentCannotBeEmptyStringException>(name != null);

            var student = new Models.Students.Student(new Models.Generics.RegistrationNumber(regNumber),new Models.Generics.PlainText(name));

            return student;
        }
    }


}
