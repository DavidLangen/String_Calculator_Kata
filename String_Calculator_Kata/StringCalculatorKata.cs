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
            if (s.Contains("+"))
            {
                return Plus(s);
            }

            return Minus(s);
        }

        private int Minus(String s)
        {
            String[] data = s.Split('-');
            int ergebnis = Int32.Parse(data[0]);

            for (int i = 1; i < data.Length; i++)
            {
                ergebnis -= Int32.Parse(data[i]);
            }

            return ergebnis;
        }

        private int Plus(String s)
        {
            String[] data = s.Split('+');
            int ergebnis = 0;

            for (int i = 0; i < data.Length; i++)
            {
                ergebnis += Int32.Parse(data[i]);
            }

            return ergebnis;
        }
    }
}
