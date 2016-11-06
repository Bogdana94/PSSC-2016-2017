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
    class Lab
    {
        public PlainText Nume { get; internal set; }

        //aceasta proprietate ar putea fi si o lista de linkuri
        public Uri LinkContinut { get; internal set; }

        internal Lab(PlainText nume)
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
            var laborator = (Lab)obj;

            if (laborator != null)
            {
                return Nume.Equals(laborator.Nume);
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
