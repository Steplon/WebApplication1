using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.pages
{
    public class taghelpplayModel : PageModel
    {

        [BindProperty]
        public int Number1 { get; set; }
        [BindProperty]
        public int? Number2 { get; set; }
        [BindProperty]
        public double MyDouble { get; set; }
        [BindProperty]
        public double? MyDouble2 { get; set; }
        [BindProperty]
        public decimal MyDecimal { get; set; }
        [BindProperty]
        public decimal? MyDecimal2 { get; set; }
        [BindProperty]
        public float MyFloat { get; set; }
        [BindProperty]
        public float? MyFloat2 { get; set; }

        [BindProperty]
        public string MyString { get; set; }

        [BindProperty]
        [DataType(DataType.Date)]
        public DateTime MydateTime { get; set; }
        [BindProperty]
        public DateTime? MydateTime2 { get; set; }

        [BindProperty]
        public bool IsContactAllowed { get; set; }

        [BindProperty]
        public string Season { get; set; }
        [BindProperty]
        public string Message { get; set; }


        public void OnGet()
        {

        }

        public void OnPost()
        {
            Message = "It is " + Season;
        }
    }
}