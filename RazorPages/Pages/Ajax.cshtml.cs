using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages
{
    public class AjaxModel : PageModel
    {
        public void OnGet()
        {

        }

        public JsonResult OnGetData()
        {
            return new JsonResult(new { test = "hello" });
        }
    }
}
