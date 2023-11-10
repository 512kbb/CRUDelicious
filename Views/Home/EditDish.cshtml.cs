using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CRUDelicious.Views.Home
{
    public class EditDish : PageModel
    {
        private readonly ILogger<EditDish> _logger;

        public EditDish(ILogger<EditDish> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}