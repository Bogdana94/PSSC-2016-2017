using Models.Generics;
using Models.Professor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public class SubjectsRepository: IRepository<Subjects>
    {
        public List<Subjects> _subjects;
       public Generics.Proportion proportion { get; set; }
       public SubjectsRepository()
        {
            List<Subjects> subjects=new List<Subjects>();
 
        }
 
        public void Add(Subjects entity)
        {
            _subjects.Add(entity);
        }

        public void Delete(Subjects entity)
        {
            _subjects.Remove(entity);
        }


        public Subjects FindById(Guid Id)
        {
            return _subjects.FirstOrDefault(s=>s.Id.Equals(Id)); 
        }

        public void AddExamGrade(Guid Id, PlainText subjectName, RegistrationNumber regNumber, Grade grade)
        {
            var subjects = FindById(Id);
            subjects.AddExamGrade(subjectName, regNumber, grade);
        }

        public void AddActivityGrade(Guid Id, PlainText subjectName, RegistrationNumber regNumber, Grade grade)
        {
            var subjects = FindById(Id);
            subjects.AddActivityGrade(subjectName, regNumber, grade);

        }

        public void AddAttendance(Guid Id, PlainText subjectName, RegistrationNumber regNumber, Attendance attendance)
        {
            var subjects = FindById(Id);
            subjects.AddAttendance(subjectName,regNumber,attendance);
        }

        public void SetActivityProportion(Guid Id, PlainText subjectName, Proportion proportion)
        {
            var subjects = FindById(Id);
            subjects.SetActivityProportion(subjectName, proportion);
        }


        
    }
}
