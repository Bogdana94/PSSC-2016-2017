using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    //value object
    public class Attendance
    {
        private int _count;
        public int Count { get; internal set; }

        public Attendance(int count)
        {
            _count = count;
        }

        public override string ToString()
        {
            return _count.ToString();
        }

        public override bool Equals(object obj)
        {
            var attendance = (Attendance)obj;

            if (attendance != null)
            {
                return _count.Equals(attendance._count);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _count.GetHashCode();
        }
    }
}
