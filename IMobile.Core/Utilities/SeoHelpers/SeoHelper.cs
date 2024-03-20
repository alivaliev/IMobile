using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IMobile.Core.Utilities.SeoHelpers
{
    public static class SeoHelper
    {
        public static string SeoUrlCreater(string url)
        {
            url = url.ToLower();
            url.Replace("ə", "e").Replace("ü", "u").Replace("ö", "o");
            string result = Regex.Replace(url, "[^a-z0-9]", "-");
            return result;
        }
    }
}
