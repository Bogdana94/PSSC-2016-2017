using Models.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Commands
{
    public class SetGradesExamAndRetake
    {
        public Guid Id;
        public List<GradeAdded> Items;
    }
}
