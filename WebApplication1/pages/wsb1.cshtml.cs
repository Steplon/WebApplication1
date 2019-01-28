using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.pages
{
    [BindProperties]
    public class wsb1Model : PageModel
    {
       
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public string Message { get; set; }
        public string Math { get; set; }

        public void OnGet()
        {
            Message = "Pick two numbers to add";
        }

        public void OnPost()
        {
            switch (Math)
            {
                case "Add":
                    Message = String.Format("{0} plus {1} is {2}", Number1, Number2, Number1 + Number2);
                    break;
                case "Subtract":
                    Message = String.Format("{0} minus {1} is {2}", Number1, Number2, Number1 - Number2);
                    break;
                case "Multiply":
                    Message = String.Format("{0} by {1} is {2}", Number1, Number2, Number1 * Number2);
                    break;
                case "Divide":
                    Message = String.Format("{0} divided by {1} is {2}", Number1, Number2, Number1 / Number2);
                    break;
                default:
                    break;
            }
        }
    }
}