using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieRekrutacyjne
{
    interface IDateFormatter
    {
        public string CultureInfoCheckerDate(CultureInfo cultureInfo);
        public string DateReturner(string cultureInfoFormat, bool isSameMonth, bool isSameMonthAndYear,
                                    DateTime firstDate, DateTime secodDate, string separator);
    }
}
