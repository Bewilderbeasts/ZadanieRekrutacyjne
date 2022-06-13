using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieRekrutacyjne
{
    class SeparatorFinder : ISeparatorFinder
    {
        public const string dotChar = ".";
        public const string pauseChar = "-";
        public const string slashChar = "/";
        public bool ContainsDot(string date)
        {
            return date.Contains(".");
        }

        public bool ContainsPause(string date)
        {
            return date.Contains("-");
        }

        public bool ContainsSlash(string date)
        {
            return date.Contains("/");
        }

        public string Separator(bool dot, bool pause, bool slash)
        {
            if (dot)
            {
                return dotChar;
            }
            else if (pause)
            {
                return pauseChar;
            }
            else if (slash)
            {
                return slashChar;
            } else
            {
                throw new Exception("No separator found");
            }
        }
    }
}
