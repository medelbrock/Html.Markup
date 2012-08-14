using System;
using System.Collections.Generic;
using System.Linq;

namespace Html.Markup
{
    public static class Extensions
    {
        public static string UnescapeParameter(this string s)
        {
            if (!string.IsNullOrEmpty(s))
                return Uri.UnescapeDataString(s);
            else
                return string.Empty;
        }
        public static string UnencodeCharacters(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;
            return s.Replace("&amp;", "&")  // ampersand
                 .Replace("&lt;", "<")       // less than
                 .Replace("&gt;", ">")       // greater than
                 .Replace("&quot", "\"")     // left opening quotation
                 .Replace("&#8220;", "“")    // left opening quotation
                 .Replace("&ldquo;", "“")    // left opening quotation
                 .Replace("&#8221;", "”")    // right closing quotation
                 .Replace("&rdquo;", "”")    // right closing quotation
                 .Replace("&#8216;", "‘")    // left opening single quote
                 .Replace("&lsquo;", "‘")    // left opening single quote
                 .Replace("&#8217;", "’")    // right closing single quote
                 .Replace("&rsquo;", "’")    // right closing single quote
                 .Replace("&#39;", "'")      // apostrophe
                 .Replace("&#x0027;", "'")   // apostrophe
                 .Replace("&apos;", "'");    // apostrophe
        }
        public static string EncodeCharacters(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;
            return s.Replace("&", "&amp;")  // ampersand
                 .Replace("<", "&lt;")      // less than
                 .Replace(">", "&gt;")      // greater than
                 .Replace("\"", "&quot")    // opening double quotation
                 .Replace("“", "&#8220;")   // left opening double quotation
                 .Replace("”", "&#8221;")   // right closing double quotation
                 .Replace("‘", "&#8216;")   // left opening single quote
                 .Replace("’", "&#8217;")   // right closing single quote
                 .Replace("'", "&#39;");    // apostrophe
        }
        public static bool CanParseToInt(this string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            for (int i = 0; i < s.Length; i++)
                if (!char.IsNumber(s[i]))
                    return false;
            return true;
        }
        public static bool CanParseToDate(this string s)
        {
            DateTime d = DateTime.MinValue;
            return DateTime.TryParse(s, out d);
        }
        public static bool InsideOf(this string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
                return false;
            if (s2.ToLower().Contains(s1.ToLower()))
                return true;
            return false;
        }
        public static bool InputIsChecked(this string s)
        {
            return s == "on" ? true : false;
        }
        public static T Assume<T>(this bool? n, T ifNull = default(T))
        {
            if (!n.HasValue)
                return ifNull;
            else
                return (T)Convert.ChangeType(n, typeof(T));
        }

        public static T Assume<T>(this DateTime? n, T ifNull = default(T))
        {
            if (!n.HasValue)
                return ifNull;
            else
                return (T)Convert.ChangeType(n, typeof(T));
        }

        public static T Assume<T>(this int? n, T ifNull = default(T))
        {
            if (!n.HasValue)
                return ifNull;
            else
                return (T)Convert.ChangeType(n, typeof(T));
        }
        public static T Assume<T>(this decimal? n, T ifNull = default(T))
        {
            if (!n.HasValue)
                return ifNull;
            else
                return (T)Convert.ChangeType(n, typeof(T));
        }
        public static string AssumeFormat(this DateTime? n, string format = "MM-dd-yyyy")
        {
            if (!n.HasValue)
                return string.Empty;
            else
                return n.Assume<DateTime>().ToString(format);
        }
        public static string AssumeFormat(this decimal? n, string format = "C")
        {
            if (!n.HasValue)
                return string.Empty;
            else
                return n.Assume<decimal>().ToString(format);
        }
        public static IEnumerable<char> CastAsCharacter(this int[] n)
        {
            for (int i = 0; i < n.Length; i++)
                yield return (char)n[i];
        }
    }
}