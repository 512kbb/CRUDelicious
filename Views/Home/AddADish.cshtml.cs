using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CRUDelicious.Views.Home
{
    public class AddADish : PageModel
    {
        private readonly ILogger<AddADish> _logger;

        public AddADish(ILogger<AddADish> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}