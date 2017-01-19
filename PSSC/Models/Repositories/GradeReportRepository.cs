using Models.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public class GradeReportRepository:IRepository<Models.Students.GradeReport>
    {
        GradeReport report;
        public void Add(GradeReport entity)
        {
            report.Add(entity);
        }

        public void Delete(GradeReport entity)
        {
            report.Remove(entity);
        }


        public GradeReport FindById(Guid Id)
        {
            return report.FirstOrDefault(s => s.Id.Equals(Id));
        }
    }
}
