using Models.Events;
using Models.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Commands
{
    class CommandHandlers : IHandleCommand<RequestSubjectList>
    {
        private readonly IRepository<SubjectsRepository> _repository;

        public CommandHandlers(IRepository<SubjectsRepository> repository)
        {
            _repository = repository;
        }


            public IEnumerable Handle(RequestSubjectList c)
            {
                var item = new SubjectsRepository();
                _repository.Save(item, -1);

                //yield is used to make it easy for a command handler to produce zero or many events as well as just one
                yield return new RequestSubjectList
                {
                    Id = c.Id,
                    Professor = c.Professor
                };

            }

            public IEnumerable Handle(SetGradesExamAndRetake c)
            {

                var retakeExamGrade = c.Items.Where(i => i.IsExamRetakeGrade).ToList();
                if (retakeExamGrade.Any())
                    yield return new ExamGradeRetakeAdded
                    {
                        Id = c.Id,
                        Items = retakeExamGrade
                    };

                var examGrade = c.Items.Where(i => !i.IsExamRetakeGrade).ToList();
                if (examGrade.Any())
                    yield return new ExamGradeAdded
                    {
                        Id = c.Id,
                        Items = examGrade
                    };
            }
     }
}

