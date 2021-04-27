using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public bool num(string y)
        {
            foreach (char a in y)
                if (Char.IsDigit(a))
                    return true;
            return false;
        }

        public bool let(string q)
        {
            foreach (char a in q)
                if (Char.IsLetter(a))
                    return true;
            return false;
        }
    }
}
