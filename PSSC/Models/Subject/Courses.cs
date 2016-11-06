using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;

namespace Models.Subject
{
    //value object
    public class Courses
    {
        private List<Course> _cursuri;
        public ReadOnlyCollection<Course> Valori { get { return _cursuri.AsReadOnly(); } }

        internal Courses()
        {
            _cursuri = new List<Course>();
        }

        internal Courses(List<Course> cursuri)
        {
            Contract.Requires(cursuri != null, "lista de cursuri");
            _cursuri = cursuri;
        }

        internal void AdaugaCurs(Course curs){
            Contract.Requires(curs != null, "curs");
            _cursuri.Add(curs);
        }

        #region override object
        public override string ToString()
        {
            return _cursuri.Aggregate(new StringBuilder(), (builder, curs) => {
                if (builder.Length > 0) builder.Append(", ");
                builder.Append(curs);
                return builder;
            }).ToString();

        }

        public override bool Equals(object obj)
        {
            var cursuri = (Courses)obj;

            if (cursuri != null && cursuri._cursuri.Count == _cursuri.Count)
            {
                return _cursuri.Select((curs, idx) => new {Curs1 = curs, Curs2 = cursuri._cursuri[idx]})
                    .Aggregate(true, (equal, pair)=> equal && pair.Curs1.Equals(pair.Curs2));

            }
            return false;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        #endregion
    }
}
