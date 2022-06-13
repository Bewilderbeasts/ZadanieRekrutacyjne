using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieRekrutacyjne
{
    interface IDateCompare
    {
        public bool CheckIfSameMonthAndYear(string firstDate, string secondDate);
        public bool CheckIfSameYear(string firstDate, string secondDate);
        public  bool IsEarlier(int result);
    }
}
