using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generics;
using System.Diagnostics.Contracts;

namespace Models.Subject
{
    //value object
    public class Course
    {
         public PlainText Nume { get; internal set; }
        public Uri LinkContinut { get; internal set; }

        internal Course(PlainText nume)
        {
            Contract.Requires(nume != null, "nume");
            Nume = nume;
        }

        #region operations
        internal void ActualizareLinkContinut(Uri url)
        {
            Contract.Requires(url != null, "url");
            LinkContinut = url;
        }
        #endregion

        #region override object
        public override string ToString()
        {
            return Nume.ToString();
        }

        public override bool Equals(object obj)
        {
            var curs = (Course)obj;

            if (curs != null)
            {
                return Nume.Equals(curs.Nume);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Nume.GetHashCode();
        }
        #endregion

    }
}
