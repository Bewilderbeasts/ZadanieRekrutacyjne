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
                return UsaDateReturner (isSameYear, isSameMonthAndYear, firstDate, secondDate, separator);
            }
            else if (cultureInfoFormat == "CHN")
            {
                return ChnDateReturner(isSameYear, isSameMonthAndYear, firstDate, secondDate, separator);
            }
            else
            {
                return RowDateReturner(isSameYear, isSameMonthAndYear, firstDate, secondDate, separator);
            }
            
        }

        private static string UsaDateReturner(bool isSameYear, bool isSameMonthAndYear, DateTime firstDate, DateTime secondDate, string separator)
        {
            if (isSameMonthAndYear)
                {
                    return  $"{firstDate.Month}{separator}{firstDate.Day} - {secondDate.Day}{separator}{firstDate.Year}";
                }
                else if (isSameYear)
                {
                   return  $"{firstDate.Month}{separator}{firstDate.Day} - {secondDate.Month}{separator}{secondDate.Day}{separator}{firstDate.Year}";
                }
                else
                {
                    return $"{firstDate.Month}{separator}{firstDate.Day}{separator}{firstDate.Year} - {firstDate.Month}{separator}{firstDate.Day}{separator}{firstDate.Year}";

                }
        }

        private static string ChnDateReturner(bool isSameYear, bool isSameMonthAndYear, DateTime firstDate, DateTime secondDate, string separator)
        {
            if (isSameMonthAndYear)
            {
                return $"{firstDate.Year}{separator}{firstDate.Month}{separator}{firstDate.Day} - {secondDate.Day}";
            }
            else if (isSameYear)
            {
                return $"{firstDate.Year}{separator}{firstDate.Month}{separator}{firstDate.Day} - {secondDate.Month}{separator}{secondDate.Day}";
            }
            else
            {
                return $"{firstDate.Year}{separator}{firstDate.Month}{separator}{firstDate.Day} - {secondDate.Year}{separator}{secondDate.Month}{separator}{secondDate.Day}";
            }
        }

        private static string RowDateReturner(bool isSameYear, bool isSameMonthAndYear, DateTime firstDate, DateTime secondDate, string separator)
        {
            if (isSameMonthAndYear)
            {
                return $"{firstDate.Day} - {secondDate.Day}{separator}{firstDate.Month}{separator}{firstDate.Year}";
            }
            else if (isSameYear)
            {
                return $"{firstDate.Day}{separator}{firstDate.Month} - {secondDate.Day}{separator}{secondDate.Month}{separator}{firstDate.Year}";
            }
            else
            {
                return $"{firstDate.Day}{separator}{firstDate.Month}{separator}{firstDate.Year} - {secondDate.Day}{separator}{secondDate.Month}{separator}{secondDate.Year}";
            }
        }
    }
}
