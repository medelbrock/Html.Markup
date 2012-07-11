using System;
using System.Collections.Generic;
using System.Linq;

namespace Html.Markup
{
    public static class Extensions
    {
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