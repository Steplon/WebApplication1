using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace WebApplication1.pages
{
    public class timeModel : PageModel
    {

        public string[] Days { get; set; } = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        [BindProperty]
        public bool[] DaysChoice { get; set; } = new bool[7];

        public List<SelectListItem> Months = new List<SelectListItem>
        {
            new SelectListItem("January","January"),
            new SelectListItem("February","February"),
            new SelectListItem("March","March"),
            new SelectListItem("April","April"),
            new SelectListItem("May","May"),
            new SelectListItem("June","June"),
            new SelectListItem("July","July"),
            new SelectListItem("August","August"),
            new SelectListItem("September","September"),
            new SelectListItem("October","October"),
            new SelectListItem("November","November"),
            new SelectListItem("December","December"),
        };

        [BindProperty]
        public List<string> ChoosenMonths { get; set; }

        public void OnPost()
        {

        }

        public void OnGet()
        {

        }
    }
}