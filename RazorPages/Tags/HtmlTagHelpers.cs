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
            string style = "bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded-full",
            Action<HtmlTag> buttonModifier = null)
        {
            buttonModifier ??= _ => { };

            var buttonTag = new HtmlTag("button")
            .Attr("type", type)
            .AddClasses(style)
            .Text(text);

            buttonModifier(buttonTag);

            return buttonTag;

            //return new HtmlTag("button")
            //.Attr("type", type)
            //.AddClasses("bg-blue-500 text-white font-bold py-2 px-4 rounded-full")
            //.AddClass("hover:bg-blue-700")
            //.Text(text);
        }



        public static HtmlTag SecondaryButton(this IHtmlHelper helper,
            string text, string type = "button")
        {
            return new HtmlTag("button")
                .Attr("type", type)
                .AddClasses("bg-green-500 text-white font-bold py-2 px-4 rounded-full")
                .AddClass("hover:bg-blue-700")
                .Text(text);
        }
    }
}
