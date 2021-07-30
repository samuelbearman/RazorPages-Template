using HtmlTags;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace RazorPages.Tags
{
    public static class HtmlTagHelpers
    {
        public static HtmlTag PrimaryButton(this IHtmlHelper helper,
            string text,
            string type = "button",
            string style = "bg-blue hover:bg-blue-light text-white font-primary py-2 px-4 rounded-sm",
            Action<HtmlTag> buttonModifier = null)
        {
            buttonModifier ??= _ => { };

            var buttonTag = new HtmlTag("button")
            .Attr("type", type)
            .AddClasses(style)
            .Text(text);

            buttonModifier(buttonTag);

            return buttonTag;
        }

        public static HtmlTag SecondaryButton(this IHtmlHelper helper,
            string text,
            string type = "button",
            string style = "bg-green hover:bg-green-light text-white font-primary py-2 px-4 rounded-sm",
            Action<HtmlTag> buttonModifier = null)
        {
            buttonModifier ??= _ => { };

            var buttonTag = new HtmlTag("button")
            .Attr("type", type)
            .AddClasses(style)
            .Text(text);

            buttonModifier(buttonTag);

            return buttonTag;
        }
    }
}
