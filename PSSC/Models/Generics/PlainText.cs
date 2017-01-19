using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    //value object
    public class PlainText
    {
        private string _text;
        public string Text { get { return _text; } }

        public PlainText(string text)
        {
            _text = text;
        }

        public override string ToString()
        {
            return _text.ToString();
        }

        public override bool Equals(object obj)
        {
            var plaintext = (PlainText)obj;

            if (plaintext != null)
            {
                return _text.Equals(plaintext._text);
            }
            return false;
        }

    /*    public override int GetHashCode()
        {
            return Nume.GetHashCode();
        }*/
    }
}
