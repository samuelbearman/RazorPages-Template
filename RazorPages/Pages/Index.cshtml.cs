using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public Result Data { get; set; }

        public class Result
        {
            public string Name { get; set; }
            public bool IsHere { get; set; }
            public DateTime? CurrentDate { get; set; } = DateTime.Now;
            public DateTime? EmptyDate { get; set; }

        }

        public void OnGet()
        {
            Data = new Result();
        }
    }
}
