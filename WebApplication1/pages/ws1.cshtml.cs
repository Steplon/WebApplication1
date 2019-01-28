using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.pages
{
    public class ws1Model : PageModel
    {
        public string[] MyTestArray { get; set; } = { "Ireland", "England", "Wales", "Scotland" };

        public string Message { get; set; }

        [BindProperty]
        public string Firstname { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            Message = String.Format("Hello {0}", Firstname);
        }
    }
}