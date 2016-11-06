using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    //value object
    public class RegistrationNumber
    {
        private string _number;
        public string Number { get { return _number; } }

        public RegistrationNumber(string number)
        {
            _number = number;
        }

        public override string ToString()
        {
            return _number.ToString();
        }

        public override bool Equals(object obj)
        {
            var registrationNumber = (RegistrationNumber)obj;

            if (registrationNumber != null)
            {
                return _number.Equals(registrationNumber._number);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _number.GetHashCode();
        }
    }
}
