using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Events
{
    public class ExamGradeAdded
    {
        public Guid Id;
        public List<GradeAdded> Items;
    }
}
