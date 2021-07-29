using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RastreioEncomenda.Pages
{
    public class PessoasModel : PageModel
    {
        private readonly ILogger<PessoasModel> _logger;

        public PessoasModel(ILogger<PessoasModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
