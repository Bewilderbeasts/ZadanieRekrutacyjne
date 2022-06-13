using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieRekrutacyjne
{
    public class DateFormatter : IDateFormatter
    {
        public string CultureInfoCheckerDate(CultureInfo cultureInfo)
        {
            string DateFormatString = cultureInfo.DateTimeFormat.ShortDatePattern;
            if (DateFormatString == "M/d/yyyy" || DateFormatString == "MM/dd/yyyy")
            {
                return "USA";
            }
            else if (DateFormatString == "yyyy/M/d" || DateFormatString == "yyyy/MM/dd")
            {
                return "CHN";
            }
            else
            {
                return "ROW";
            }
        }

        public string DateReturner(string cultureInfoFormat, bool isSameYear, bool isSameMonthAndYear, DateTime firstDate, DateTime secondDate, string separator)
        {

            if (cultureInfoFormat == "USA")
            {
                if (isSameMonthAndYear == true)
                {
                    string date = $"{firstDate.Month}{separator}{firstDate.Day} - {secondDate.Day}{separator}{firstDate.Year}";
                    return date;
                }
                else if (isSameYear == true)
                {
                    string date = $"{firstDate.Month}{separator}{firstDate.Day} - {secondDate.Month}{separator}{secondDate.Day}{separator}{firstDate.Year}";
                    return date;
                }
                else
                {
                    string date = $"{firstDate.Month}{separator}{firstDate.Day}{separator}{firstDate.Year} - {firstDate.Month}{separator}{firstDate.Day}{separator}{firstDate.Year}";
                    return date;
                }
            }
            else if (cultureInfoFormat == "CHN")
            {
                
                if (isSameMonthAndYear == true)
                {
                    string date = $"{firstDate.Year}{separator}{firstDate.Month}{separator}{firstDate.Day} - {secondDate.Day}";
                    return date;
                }
                else if (isSameYear == true)
                {
                    string date = $"{firstDate.Year}{separator}{firstDate.Month}{separator}{firstDate.Day} - {secondDate.Month}{separator}{secondDate.Day}";
                    return date;
                }
                else
                {
                    string date = $"{firstDate.Year}{separator}{firstDate.Month}{separator}{firstDate.Day} - {secondDate.Year}{separator}{secondDate.Month}{separator}{secondDate.Day}";
                    return date;
                }
            }
            else
            {

                if (isSameMonthAndYear == true)
                {
                    string date = $"{firstDate.Day} - {secondDate.Day}{separator}{firstDate.Month}{separator}{firstDate.Year}";
                    return date;
                }
                else if (isSameYear == true)
                {
                    string date = $"{firstDate.Day}{separator}{firstDate.Month} - {secondDate.Day}{separator}{secondDate.Month}{separator}{firstDate.Year}";
                    return date;
                }
                else
                {
                    string date = $"{firstDate.Day}{separator}{firstDate.Month}{separator}{firstDate.Year} - {secondDate.Day}{separator}{secondDate.Month}{separator}{secondDate.Year}";
                    return date;
                }
            }
            
        }
    }
}
