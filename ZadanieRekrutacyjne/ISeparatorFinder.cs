using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieRekrutacyjne
{
    interface ISeparatorFinder
    {
        public bool ContainsSlash(string date);
        public bool ContainsPause(string date);
        public bool ContainsDot(string date);

        public string Separator(bool dot, bool pause, bool slash);

    }
}
