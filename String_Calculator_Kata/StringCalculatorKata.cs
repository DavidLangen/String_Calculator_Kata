using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Calculator_Kata
{
    class StringCalculatorKata
    {
        private List<String> _berechnungen;

        public StringCalculatorKata()
        {
            _berechnungen = new List<String>();
        }

        public int calculator(String s)
        {
            if (s.Contains("\\+"))
            {
                return plus(s);
            }

            return minus(s);
        }

        private int minus(String s)
        {
            return 0;
        }

        private int plus(String s)
        {
            return 0;
        }
    }
}
