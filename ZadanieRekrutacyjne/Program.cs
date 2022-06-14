using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

namespace ZadanieRekrutacyjne
{
    class Program
    {
        private static string firstDate;
        private static string secondDate;
        private static bool IsSameYear;
        private static bool IsSameMonthAndYear;
       
        public static void Main(string[] args)
        {
            DatetimeVerifier dateTime = new DatetimeVerifier();
            DateCompare dateCompare = new DateCompare();
            DateFormatter dateFormatter = new DateFormatter();
            SeparatorFinder separatorFinder = new SeparatorFinder(); 

            if (args == null || args.Length == 0)
            {
                Console.WriteLine("You must enter at least two dates!");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("You must enter the second date!");
            }
            else if (args.Length > 2)
            {
                Console.WriteLine("Only two dates are required!");
            }
            else
            {
                string placeholderfDate = args[0];
                string placeholdersDate = args[1];

                if (dateTime.IsDateTime(placeholderfDate) && dateTime.IsDateTime(placeholdersDate))
                {
                    CultureInfo ci = Thread.CurrentThread.CurrentCulture;
                    //CultureInfo customCulture = new CultureInfo("mn-MN");
                    
                    //CultureInfo ci = new CultureInfo("zh-CN");
                    //Thread.CurrentThread.CurrentCulture = ci;
                    //Thread.CurrentThread.CurrentUICulture = ci;
                    string cultureInfoFormat = dateFormatter.CultureInfoCheckerDate(ci);

                    DateTime fDate = DateTime.Parse(placeholderfDate);
                    DateTime sDate = DateTime.Parse(placeholdersDate);

                    firstDate = fDate.Date.ToShortDateString();
                    secondDate = sDate.Date.ToShortDateString();

                    int result = DateTime.Compare(fDate, sDate);
                    if (dateCompare.IsEarlier(result))
                    {   
                        DateTime tempDate = fDate;
                        fDate = sDate;
                        sDate = tempDate;
                    }

                    IsSameYear = dateCompare.CheckIfSameYear(firstDate, secondDate);
                    IsSameMonthAndYear = dateCompare.CheckIfSameMonthAndYear(firstDate, secondDate);

                    string separator = separatorFinder.Separator(separatorFinder.ContainsDot(placeholderfDate), separatorFinder.ContainsPause(placeholderfDate),
                                                    separatorFinder.ContainsSlash(placeholderfDate));
                    
                    Console.WriteLine(dateFormatter.DateReturner(cultureInfoFormat, IsSameYear, IsSameMonthAndYear, fDate, sDate, separator));
                }
                else
                {
                    Console.WriteLine("Dates are invalid");
                    Environment.Exit(0);
                }
            }


        }
    }
}