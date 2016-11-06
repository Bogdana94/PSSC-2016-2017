using Models.Generics;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Subject
{
    //Entity
    public class Subject
    {
        public SubjectInformation SubjectInfo { get; internal set; }

        private Dictionary<Students.Student, SubjectSituation> _signedUpStudentsGrades;
        private SubjectSituation subjectSituation;
        private SubjectInformation subjectInformation;
        public Dictionary<Students.Student, SubjectSituation> SignedUpStudentsGrades { get { return _signedUpStudentsGrades; } }

        public Subject()
        {
            _signedUpStudentsGrades = new Dictionary<Students.Student, SubjectSituation>();
        }

        public Subject(Dictionary<Students.Student, SubjectSituation> signedUpStudentsGrades, SubjectInformation subjectInfo)
        {
            _signedUpStudentsGrades = signedUpStudentsGrades;
            SubjectInfo = subjectInfo;
        }

        public Subject(SubjectInformation subjectInfo) : this()
        {
            SubjectInfo = subjectInfo;
        }

        public Subject(SubjectSituation subjectSituation, SubjectInformation subjectInformation)
        {
            // TODO: Complete member initialization
            this.subjectSituation = subjectSituation;
            this.subjectInformation = subjectInformation;
        }

        public void SignUpStudent(Students.Student student)
        {
            _signedUpStudentsGrades.Add(student, new SubjectSituation());
        }

        public Grade GetAverageForStudent(RegistrationNumber regNumber)
        {
            SubjectSituation situation = _signedUpStudentsGrades.First(d => d.Key.RegNumber == regNumber).Value;

            decimal activityGrade = situation.ActivityGrade.Value;
            decimal examAverage = situation.GetExamAverage(SubjectInfo.Evaluation);
            decimal proportion = SubjectInfo.ActivityProportion.Fraction;

            return new Grade(activityGrade * proportion + (1 - proportion) * examAverage);
        }

        public SubjectSituation GetSituationForStudent(RegistrationNumber regNumber)
        {
            return _signedUpStudentsGrades.First(d => d.Key.RegNumber == regNumber).Value;
        }
    }
}
