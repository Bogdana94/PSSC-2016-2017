using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    //value object
    public class Grade
    {
        private decimal _value;
        public decimal Value { get { return _value; } }

        public Grade(decimal value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        public override bool Equals(object obj)
        {
            var grade = (Grade)obj;

            if (grade != null)
            {
                return _value.Equals(grade._value);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }
    }
}
