Html.Markup 
==
**[Html.Markup in .ASPX web applications](https://github.com/medelbrock/Html.Markup#htmlmarkup-in-aspx-web-applications)**  
**[Html.Markup in MVC3/MVC4](https://github.com/medelbrock/Html.Markup#htmlmarkup-in-mvc3mvc4)**  
**[Html.Markup into jQuery objects](https://github.com/medelbrock/Html.Markup#markup-properties)**  
**[Markup properties](https://github.com/medelbrock/Html.Markup#markup-properties)**  
**[Markup styling and attributes](https://github.com/medelbrock/Html.Markup#markup-styling-and-attributes)**  

Html.Markup is a library that was created to assist in generating implicit html markup using C\# codebehind.
This library is a work in progress and additions are more than welcome. All of the elements inherit from Html.Markup and follow the same structure of a DOM hierarchy.
The class uses implicit string conversion and overrides the *ToString()* method which allows you to push it as you would a string.

Html.Markup in .ASPX web applications
---

For instance putting a dynamic span inside of a div on an 
#####.ASPX page markup
	<div id="sample" runat="server"></div>
#####C\# syntax
	sample.InnerHtml = new Span
	{
		Text="this is sample text"
	};
#####.ASPX will render as
	<div id="sample" runat="server"><span>this is sample text</span></div>
Html.Markup in MVC3/MVC4
---
Using Html.Markup in MVC is easier to use than forms because all you need is the Html.Raw() helper on your model
#####Razor syntax
	@model Html.Markup
	@Html.Raw(@Model)

Html.Markup into jQuery objects
---
You can generate dynamic jQuery objects 
#####C\# syntax
	public IEnumerable<string> Get()
	{
		yield return new Option
		{
			Value = "Value1",
			Text = "Option1"
		};
		yield return new Option
		{
			Value = "Value2",
			Text = "Option2"
		};
	}
#####Javascript syntax
	var select = $("<select/>");
	$.get("/ajaxservice")
	.done(function(markup) {
		$.each(markup, function(k,v) {
			$(v).appendTo(select);
		});
	});
###Markup properties
- - -
Markup includes properties that every Document Object contains. The class is *abstract* and only inherited by the Element classes. Currently the following elements are supported:
**Anchor**,	**Br**, **Div**, **Li**, **Ol**, **Option**, **Paragraph**,**ParsedHtml** (raw html), **Select**, **Span**, **Table**, **Td**, **Tr**, **Th**, **Ul**,**TextArea**, **Input and input types**  
The Markup class a Parent Child element relationship as well. You can either wrap a child Markup or wrap an array of children.
#####C\# syntax
	Div d = new Div
	{
		Wrap = new Span
		{
			Text = "I'm wrapped in a div"
		}
	};
#####Html rendered
	<div><span>I'm wrapped in a div</span></div>
  
One step further is to wrap multiple children into a parent
#####C\# syntax
	Select s = new Select
	{
		Children = new Markup[]
		{
			new Option
			{
				Text = "Option 1",
				Value = "1"
			},
			new Option
			{
				Text = "Option 2",
				Value = "2"
			},
			new Option
			{
				Text = "Option 3",
				Value = "3"
			}
		}
	};
#####Html rendered
	<select>
		<option value="1">Option 1</option>
		<option value="2">Option 2</option>
		<option value="3">Option 3</option>
	</select>
  
#####C\# syntax
	public class StyleAttributes
    {
        public Font Font { get; set; }
        public Background Background { get; set; }
        public Border Border { get; set; }
        public LineStyle OutlineStyle { get; set; }
        public ListStyle ListStyle { get; set; }
        public Overflow Overflow { get; set; }
        public Dimensions Dimensions { get; set; }
        public Margin Margin { get; set; }
        public Padding Padding { get; set; }
        public Float Float { get; set; }
        public Clear Clear { get; set; }
        public Cursor Cursor { get; set; }
        public Display Display { get; set; }
        public Visibility Visibility { get; set; }
        public Position Position { get; set; }
        public string Color { get; set; }
        public double? LineHeight { get; set; }
        public MarkupMetric LineHeightMetric { get; set; }
        public VerticalAlign VerticalAlign { get; set; }
        public Text Text { get; set; }
	}
###Markup styling and attributes
- - -
Each Markup element has an inline-style object called **StyleAttributes**. The properties are broken out into general categories based on CSS rule groupings.  
**Font**, **Background**, **Border**, **LineStyle**, **Overflow**, **Dimensions**, **Margin**, **Padding**, **Float**, **Cursor**, **Display**, **Visibility**, **Position**, **Color**, **Line height**, **Vertical align**, **Text**  
  

These groups are mainly created with sub classes created with *public static readonly* properties with a private constructor and an implicit operator. The ListStyleType class is listed below to show how they are built.
#####C\# syntax
	public sealed class ListStyleType
    {
		private readonly string _attr;

        private ListStyleType(string attr)
        {
            _attr = attr;
        }

        public static implicit operator string(ListStyleType n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return _attr;
        }

        public static readonly ListStyleType Armenian = new ListStyleType("armenian");
        public static readonly ListStyleType Circle = new ListStyleType("circle");
        public static readonly ListStyleType CjkIdeographic = new ListStyleType("cjk-ideographic");
        public static readonly ListStyleType Decimal = new ListStyleType("decimal");
        public static readonly ListStyleType DecimalLeadingZero = new ListStyleType("decimal-leading-zero");
        public static readonly ListStyleType Disc = new ListStyleType("disc");
        public static readonly ListStyleType Georgian = new ListStyleType("georgian");
        public static readonly ListStyleType Hebrew = new ListStyleType("hebrew");
        public static readonly ListStyleType Hiragana = new ListStyleType("hiragana");
        public static readonly ListStyleType HiraganaIroha = new ListStyleType("hiragana-iroha");
        public static readonly ListStyleType Katakana = new ListStyleType("katakana");
        public static readonly ListStyleType Inherit = new ListStyleType("inherit");
        public static readonly ListStyleType KatakanaIroha = new ListStyleType("katakana-iroha");
        public static readonly ListStyleType LowerAlpha = new ListStyleType("lower-alpha");
        public static readonly ListStyleType LowerGreek = new ListStyleType("lower-greek");
        public static readonly ListStyleType LowerLatin = new ListStyleType("lower-latin");
        public static readonly ListStyleType LowerRoman = new ListStyleType("lower-roman");
        public static readonly ListStyleType None = new ListStyleType("none");
        public static readonly ListStyleType Square = new ListStyleType("square");
        public static readonly ListStyleType UpperAlpha = new ListStyleType("upper-alpha");
        public static readonly ListStyleType UpperLatin = new ListStyleType("upper-latin");
        public static readonly ListStyleType UpperRoman = new ListStyleType("upper-roman");
    }
When you use this property, it acts like an Enum. The following sets a span to display as inline block
#####C\# syntax
	Span s = new Span
	{
		Text = "This is inline block",
		Style = new StyleAttributes
		{
			Display = Display.InlineBlock
		}
	};

More complex
#####C\# syntax
	Span s = new Span
	{
		Text = "This is inline block",
		Class = "css-class1 css-class2",
		Width = 130,
		Style = new StyleAttributes
		{
			Display = Display.InlineBlock,
			Margin = new Margin(0,0,0,5),
			Float = Float.Right,
			Color = "#CCCCCC",
			Padding = new Padding(2),
			Font = new Font(size:14)
		}
	};
#####Html rendered
	<span style="font-size:14px;width:130px;margin-top:0px;margin-right:0px;margin-left:5px;margin-bottom:0px;padding:2px;float:right;display:inline-block;color:#CCCCCC" class="css-class1 css-class2">This is inline block</span>

*More documentation coming soon*