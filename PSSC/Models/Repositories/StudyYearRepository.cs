using Models.Deanship;
using Models.Generics;
using Models.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public class StudyYearRepository : IRepository<StudyYear>
    {
        public List<StudyYear> subjects;

        public StudyYearRepository()
        {
            List<Subject.Subject> _definedSubjects = new List<Subject.Subject>();
 
        }

        public void Add(StudyYear entity)
        {
            subjects.Add(entity);
        }

        public void Delete(StudyYear entity)
        {
            subjects.Remove(entity);
        }


        public StudyYear FindById(Guid Id)
        {
            return subjects.FirstOrDefault(s => s.Id.Equals(Id)); 
        }

         public void DefineSubject(Guid Id,PlainText subjectName, Credits credits, EvaluationType type, Proportion activity)
        {
             var subjects = FindById(Id);
             subjects.DefineSubject(subjectName, credits, type, activity);
        }

        public void DefineSubject(Guid Id,PlainText subjectName, Credits credits, EvaluationType type, Proportion activity, Professor.Professor professor)
         {
             var subjects = FindById(Id);
             subjects.DefineSubject(subjectName, credits, type, activity,professor);
         }

        public void SignUpStudentToSubject(Guid Id, PlainText subjectName, Students.Student student)
        {
            var subjects = FindById(Id);
            subjects.SignUpStudentToSubject(subjectName, student);
        }
    }
}
