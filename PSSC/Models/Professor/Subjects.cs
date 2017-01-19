using Models.Generics;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repositories;

namespace Models.Professor
{
    //Aggregate Root
    public class Subjects:IEntity
    {
        public int Id { get; set; }
        private List<Subject.Subject> _subjects;
        private Generics.Proportion _proportion;
        public ReadOnlyCollection<Subject.Subject> AllSubjects { get { return _subjects.AsReadOnly(); } }
        private Models.Subject.Labs Labs { get;/* internal*/ set; }
        private Models.Subject.Courses Courses { get;/* internal*/ set; }
        public Subjects(List<Subject.Subject> subjects, Generics.Proportion proportion)
        {
            _subjects = subjects;
            Labs = new Subject.Labs();
            Courses = new Subject.Courses();
            _proportion = proportion;
        }

        public void AddExamGrade(PlainText subjectName, RegistrationNumber regNumber, Grade grade)
        {
            _subjects.Find(d => d.SubjectInfo.Name == subjectName)
                .GetSituationForStudent(regNumber)
                .AddExamGrade(grade);
        }

        public void AddActivityGrade(PlainText subjectName, RegistrationNumber regNumber, Grade grade)
        {
            _subjects.Find(d => d.SubjectInfo.Name == subjectName)
                .GetSituationForStudent(regNumber)
                .AddActivityGrade(grade);
        }

        public void AddAttendance(PlainText subjectName, RegistrationNumber regNumber, Attendance attendance)
        {
            _subjects.Find(d => d.SubjectInfo.Name == subjectName)
                .GetSituationForStudent(regNumber)
                .AddAttendance(attendance);
        }

        public void SetActivityProportion(PlainText subjectName, Proportion proportion)
        {
            _subjects.Find(d => d.SubjectInfo.Name == subjectName).SubjectInfo.SetActivityProportion(proportion);
        }
    }
}
