﻿using System.Collections.Generic;
using System.Linq;

namespace Html.Markup
{
    public abstract class Markup
    {
        protected virtual string Tag { get; set; }

        protected IList<AttributePair> AttrList { get; set; }

        public IList<AttributePair> Attributes { get; set; }

        public string ID { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public StyleAttributes Style { get; set; }

        public string Text { get; set; }

        public Markup Wrap { get; set; }

        public IEnumerable<Markup> Children { get; set; }

        public string Class { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }

        public string Html { get; set; }

        public Markup()
        {
            AttrList = new List<AttributePair>();
            Attributes = new List<AttributePair>();
        }

        public static implicit operator string(Markup n)
        {
            if (n != null)
                return n.ToString();
            else
                return string.Empty;
        }

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(ID))
                AttrList.Add(new AttributePair { Set = "id", Value = ID });
            if (!string.IsNullOrEmpty(Name))
                AttrList.Add(new AttributePair { Set = "name", Value = Name });
            if (!string.IsNullOrEmpty(Title))
                AttrList.Add(new AttributePair { Set = "title", Value = Title });
            if (Height.HasValue || Width.HasValue)
            {
                if (Style == null)
                    Style = new StyleAttributes
                    {
                        Dimensions = new Dimensions
                        {
                            Height = Height ?? null,
                            Width = Width ?? null
                        }
                    };
                else if (Style != null && Style.Dimensions == null)
                {
                    Style.Dimensions = new Dimensions
                    {
                        Height = Height ?? null,
                        Width = Width ?? null
                    };
                }
                else if (Style != null && Style.Dimensions != null)
                {
                    Style.Dimensions.Height = Height ?? null;
                    Style.Dimensions.Width = Width ?? null;
                }
            }
            if (Style != null)
                AttrList.Add(new AttributePair { Set = "style", Value = Style });
            if (Class != null)
                AttrList.Add(new AttributePair { Set = "class", Value = Class });
            List<string> l = new List<string>();
            foreach (var x in Attributes)
                if (!string.IsNullOrEmpty(x.Value)) l.Add(string.Format("{0}=\"{1}\"", x.Set, x.Value));
            foreach (var x in AttrList)
                if (!string.IsNullOrEmpty(x.Value)) l.Add(string.Format("{0}=\"{1}\"", x.Set, x.Value));
            if (this is Br || this is Input)
                return string.Format("<{0}{1}/>", Tag, l.Count > 0 ? " " + string.Join(" ", l.ToArray()) : string.Join(" ", l.ToArray()), Text.EncodeCharacters(), Wrap);
            if (Wrap != null && Children != null)
                throw new MarkupException("Cannot have a wrapped element when children are specified");
            if (Wrap != null)
                return string.Format("<{0}{1}>{2}{3}{4}</{0}>", Tag, l.Count > 0 ? " " + string.Join(" ", l.ToArray()) : string.Join(" ", l.ToArray()), Text, Wrap, !string.IsNullOrEmpty(Html) ? Html : string.Empty);
            if (Children != null && Children.Count() > 0)
            {
                List<string> ml = new List<string>();
                foreach (var h in Children)
                    ml.Add(h);
                return string.Format("<{0}{1}>{2}{3}{4}</{0}>", Tag, l.Count > 0 ? " " + string.Join(" ", l.ToArray()) : string.Join(" ", l.ToArray()), Text, string.Join(string.Empty, ml.ToArray()), !string.IsNullOrEmpty(Html) ? Html : string.Empty);
            }
            return string.Format("<{0}{1}>{2}{3}</{0}>", Tag, l.Count > 0 ? " " + string.Join(" ", l.ToArray()) : string.Join(" ", l.ToArray()), Text, !string.IsNullOrEmpty(Html) ? Html : string.Empty);
        }
    }
}