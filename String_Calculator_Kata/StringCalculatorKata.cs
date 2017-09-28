using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            Regex r = new Regex("^([0-9]*[+-][0-9]*)+$");
            Match m = r.Match(s);
            if (s == "" || !m.Success)
            {
                return 0;
            }

            if (s.Contains("+"))
            {
                return Plus(s);
            }

            return Minus(s);
        }

        private int Minus(String s)
        {
            String[] data = s.Split('-');
            int ergebnis = 0;
            if (data[0] != "")
            {
                ergebnis = Int32.Parse(data[0]);
            }

            int wert = 0;
            Regex r = new Regex(".*[+-]+.*");

            for (int i = 1; i < data.Length; i++)
            {
                if (r.Match(data[i]).Success)
                {
                    wert = Calculator(data[i]);
                }
                else
                {
                    wert = Int32.Parse(data[i]);
                }
                ergebnis -= wert;

            }

            return ergebnis;
        }

        private int Plus(String s)
        {
            String[] data = s.Split('+');
            int ergebnis = 0;
            int wert = 0;
            Regex r = new Regex(".*[+-]+.*");

            for (int i = 0; i < data.Length; i++)
            {

                if (data[i] == "")
                {
                    continue;

                } else if (r.Match(data[i]).Success)
                {
                    wert = Calculator(data[i]);
                }
                else
                {
                    wert = Int32.Parse(data[i]);
                }

                ergebnis += wert;
            }

            return ergebnis;
        }

        public void AddCalculation(String c)
        {
            _berechnungen.Add(c);
        }

        public String LastCalculation()
        {
            return _berechnungen.Last();
        }
    }
}
