using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RastreioEncomenda.Pages
{
    public class EncomendasModel : PageModel
    {
        private readonly ILogger<EncomendasModel> _logger;

        public EncomendasModel(ILogger<EncomendasModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
