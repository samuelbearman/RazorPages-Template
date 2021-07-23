using HtmlTags;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RazorPages.Tags
{
    public static class HtmlHelperExtensions
    {
        public static HtmlTag FormBlock<T, TMember>(this IHtmlHelper<T> helper,
           Expression<Func<T, TMember>> expression,
           Action<HtmlTag> labelModifier = null,
           Action<HtmlTag> inputModifier = null
       ) where T : class
        {
            labelModifier ??= _ => { };
            inputModifier ??= _ => { };

            var divTag = new HtmlTag("div");
            divTag.AddClass("form-group");

            var labelTag = helper.Label(expression);
            labelModifier(labelTag);

            var inputTag = helper.Input(expression);
            inputModifier(inputTag);

            divTag.Append(labelTag);
            divTag.Append(inputTag);

            return divTag;
        }
    }
}
