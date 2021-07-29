using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RastreioEncomenda.Pages
{
    public class RastreioModel : PageModel
    {
        private readonly ILogger<RastreioModel> _logger;

        public RastreioModel(ILogger<RastreioModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
