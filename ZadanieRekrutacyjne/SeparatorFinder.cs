using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieRekrutacyjne
{
    class SeparatorFinder : ISeparatorFinder
    {
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
                return ".";
            }
            else if (pause)
            {
                return "-";
            }
            else if (slash)
            {
                return "/";
            } else
            {
                throw new Exception("No separator found");
            }
        }
    }
}
