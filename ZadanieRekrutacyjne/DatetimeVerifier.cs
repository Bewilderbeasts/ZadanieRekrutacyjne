using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieRekrutacyjne
{
    public class DatetimeVerifier : IDatetimeVerifier
    {
        public bool IsDateTime(string date)
        {
            DateTime validDate;
            var formats = new[] { "dd/MM/yyyy", "yyyy/MM/dd", "dd.MM.yyyy", "yyyy.MM.dd", "yyyy-MM-dd", "dd-MM-yyyy", "yyyy'-'MM'-'dd'" };
            return DateTime.TryParseExact(date, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out validDate);
        }
    }
}
