using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics.Exceptions
{
    class InvalidArgumentException:ArgumentException
    {
        public InvalidArgumentException(string parameterName)
            : base(string.Format("Argument {0} cannot be invalid string.", parameterName), parameterName)
        {

        }


    }
}
