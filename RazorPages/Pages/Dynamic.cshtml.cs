using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages
{
    public class DynamicModel : PageModel
    {

        public void OnGet()
        {
            Data = new Command();
            Data.LineItems.Add(new Command.LineItem() { Name = "Test", Value = 2 });
        }


        public class Command
        {
            public string Name { get; set; }
            public List<LineItem> LineItems { get; set; } = new List<LineItem>();

            public class LineItem
            {
                public string Name { get; set; }
                public decimal Value { get; set; }
            }

        }
        
        [BindProperty]
        public Command Data { get; set; }


        public IActionResult OnPostAddItem([Bind(Prefix = "Data")]Command command)
        {
            command.LineItems.Add(new Command.LineItem());
            return Partial("_LineItemsEditor", command);
        }

        public IActionResult OnPost()
        {
            var test = "";
            return Page();
        }

    }
}
