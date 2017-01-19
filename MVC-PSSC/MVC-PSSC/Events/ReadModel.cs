using Models.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_PSSC.Events
{
        public interface IReadModel
        {
            IEnumerable<SubjectsList> GetSubjectList();
        
        }


        public class SubjectsList
        {
            public Guid Id;
            public string Professor;

            public SubjectsList(Guid id, string professor)
            {
                Id = id;
                Professor = professor;
            }
        }

        public class SubjectListView : ActivityGradeAdded, ActivityGradeProportionSet, AttendanceAdded, ExamGradeAdded, ExamGradeRetakeAdded, GradeAdded, SubjectListRequested
        {
            public void Handle(ActivityGradeAdded message)
            {
                Database.list.Add(new SubjectsList(message.Id, message.Professor));
            }

            public void Handle(ActivityGradeProportionSet message)
            {
                ActivityGradeProportionSet p;

            }

            public void Handle(AttendanceAdded message)
            {
                Database.list.Add(new SubjectsList(message.Id, message.Professor));
            }

            public void Handle(ExamGradeAdded message)
            {
                Database.list.Add(new SubjectsList(message.Id, message.Items));
            }

            public void Handle(ExamGradeRetakeAdded message)
            {
                Database.list.Add(new SubjectsList(message.Id, message.Items));
            }

            public void Handle(GradeAdded message)
            {
                Database.list.Add(new SubjectsList(message.Grade, message.IsExamRetakeGrade));
            }

            public void Handle(SubjectListRequested message)
            {
                var item = Database.list.Find(x => x.Id == message.Id);
                item.Professor = message.Professor;
            }
        }

       
        public class ReadModelFacade : IReadModel
        {
            public IEnumerable<SubjectsList> GetInventoryItems()
            {
                return Database.list;
            }

           
        }

        public static class Database
        {
            public static List<SubjectsList> list = new List<SubjectsList>();
        }
    }