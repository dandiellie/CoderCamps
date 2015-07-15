using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingList2.Helpers
{
    public static class ImageHelper
    {
        public static MvcHtmlString Image(this HtmlHelper helper, string url)
        {
            TagBuilder tb = new TagBuilder("img");
            tb.MergeAttribute("scr", url);
            return MvcHtmlString.Create(tb.ToString(TagRenderMode.SelfClosing));
        }
    }
}