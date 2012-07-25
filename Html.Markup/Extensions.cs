using System;
using System.Collections.Generic;
using System.Linq;

namespace Html.Markup
{
    public static class Extensions
    {
        public static string UnencodeCharacters(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;
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
                return string.Empty;
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

        public static Markup FindChild(this Markup m, Func<Markup, bool> p)
        {
            try
            {
                if (p.Invoke(m))
                    return m;
                else if (m.Wrap != null)
                    return m.Wrap.FindChild(p);
                else if (m.Children != null && m.Children.Count() > 0)
                    return m.Children.FindChild(p);
                else
                    return null;
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }

        public static Markup FindChild(this IEnumerable<Markup> m, Func<Markup, bool> p)
        {
            foreach (Markup m1 in m)
                if (m1.FindChild(p) != null)
                    return m1;
            return null;
        }

        public static IEnumerable<Markup> FindChildren(this Markup m, Func<Markup, bool> p)
        {
            bool isCurrent = false;
            try
            {
                if (p.Invoke(m))
                    isCurrent = true;
            }
            catch (NullReferenceException) { }
            if (isCurrent)
                yield return m;
            if (m.Wrap != null)
                foreach (Markup m1 in m.Wrap.FindChildren(p))
                    yield return m1;
            if (m.Children != null && m.Children.Count() > 0)
                foreach (Markup m2 in m.Children.FindChildren(p))
                    yield return m2;
        }

        public static IEnumerable<Markup> FindChildren(this IEnumerable<Markup> m, Func<Markup, bool> p)
        {
            foreach (Markup m1 in m)
                if (m1.FindChild(p) != null)
                    yield return m1.FindChild(p);
        }
    }
}