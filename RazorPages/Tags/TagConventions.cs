using System;
using System.ComponentModel.DataAnnotations;
using HtmlTags;
using HtmlTags.Conventions;

namespace RazorPages.Tags
{
    public class TagConventions : HtmlConventionRegistry
    {
        public TagConventions()
        {
            CssClassNameValidator.AllowInvalidCssClassNames = true;

            Editors.Always.AddClass("form-control");

            Editors.IfPropertyIs<DateTime?>().ModifyWith(m => m.CurrentTag
                .AddPattern("9{1,2}/9{1,2}/9999")
                .AddPlaceholder("MM/DD/YYYY")
                .AddClass("datepicker")
                .Value(m.Value<DateTime?>() != null ? m.Value<DateTime>().ToShortDateString() : string.Empty));
            Editors.If(er => er.Accessor.Name.EndsWith("id", StringComparison.OrdinalIgnoreCase)).BuildBy(a => new HiddenTag().Value(a.StringValue()));
            Editors.IfPropertyIs<byte[]>().ModifyWith(m => m.CurrentTag.Value(Convert.ToBase64String(m.Value<byte[]>())));
            Editors.IfPropertyIs<byte[]>().BuildBy(a => new HiddenTag());

            Labels.Always.AddClass("control-label");
            Labels.ModifyForAttribute<DisplayAttribute>((t, a) => t.Text(a.Name));

            Labels
                .Always
                .ModifyWith(er => er.CurrentTag.Text(er.CurrentTag.Text().Replace("Data ", "")));

            DisplayLabels.ModifyForAttribute<DisplayAttribute>((t, a) => t.Text(a.Name));
            Displays.IfPropertyIs<DateTime>().ModifyWith(m => m.CurrentTag.Text(m.Value<DateTime>().ToShortDateString()));
            Displays.IfPropertyIs<DateTime?>().ModifyWith(m => m.CurrentTag.Text(m.Value<DateTime?>()?.ToShortDateString()));
            Displays.IfPropertyIs<decimal>().ModifyWith(m => m.CurrentTag.Text(m.Value<decimal>().ToString("C")));

            Editors.IfPropertyIs<bool>().ModifyWith(m => m.CurrentTag.AddClass("rounded border-black-300 text-indigo-600 shadow-sm focus:border-indigo-300 focus:ring focus:ring-offset-0 focus:ring-indigo-200 focus:ring-opacity-50"));
        }

        public ElementCategoryExpression DisplayLabels => new ElementCategoryExpression(Library.TagLibrary.Category(nameof(DisplayLabels)).Profile(TagConstants.Default));
    }
}
