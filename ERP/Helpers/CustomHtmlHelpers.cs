using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace ERP.Helpers
{
    public static class CustomHtmlHelpers
    {
        public static MvcHtmlString HightlightKeyWord(this HtmlHelper helper, string SourceStr,string Keyword,string ClassName)
        {
            string RegexPattern = "(("+Keyword+")+)";
            string RegexReplace = "<span class=\"" + ClassName + "\">$1</span>";

            if(Regex.Match(SourceStr, RegexPattern).Success)
            {
                return MvcHtmlString.Create(Regex.Replace(SourceStr, RegexPattern, RegexReplace));
            }
            else
            {
                return MvcHtmlString.Create(SourceStr);
            }
        }
    }
}
