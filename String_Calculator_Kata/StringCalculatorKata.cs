using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Calculator_Kata
{
    public class StringCalculatorKata
    {
        private List<String> _berechnungen;

        public StringCalculatorKata()
        {
            _berechnungen = new List<String>();
        }

        public int Calculator(String s)
        {
            if (s.Contains("\\+"))
            {
                return Plus(s);
            }

            return Minus(s);
        }

        private int Minus(String s)
        {
            return 0;
        }

        private int Plus(String s)
        {
            return 0;
        }
    }
}
