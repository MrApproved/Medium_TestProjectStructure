using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExample
{
    public static class StringExtensions
    {
        public static string SafeTrim(this string s)
            => string.IsNullOrEmpty(s) ? "" : s.Trim();
    }
}
