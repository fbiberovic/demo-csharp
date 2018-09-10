﻿using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "This is Nikolay's About page.";
        }
    }
}
