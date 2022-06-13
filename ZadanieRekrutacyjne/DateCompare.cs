using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieRekrutacyjne
{
    public class DateCompare : IDateCompare
    {
  
        public bool CheckIfSameMonthAndYear(string firstDate, string secondDate)
        {
            DateTime date1 = DateTime.Parse(firstDate);
            DateTime date2 = DateTime.Parse(secondDate);

            if (date1.Month == date2.Month && date1.Year == date2.Year)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckIfSameYear(string firstDate, string secondDate)
        {
            DateTime date1 = DateTime.Parse(firstDate);
            DateTime date2 = DateTime.Parse(secondDate);

            if (date1.Year == date2.Year)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsEarlier(int result)
        {
            if (result >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
