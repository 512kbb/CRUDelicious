using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CRUDelicious.Views.Home
{
    public class DishDetails : PageModel
    {
        private readonly ILogger<DishDetails> _logger;

        public DishDetails(ILogger<DishDetails> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}