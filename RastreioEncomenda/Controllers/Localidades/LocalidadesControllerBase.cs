using Microsoft.AspNetCore.Mvc;
using RastreioEncomenda.Aplicacao.DTO;
using RastreioEncomenda.Aplicacao.Interface;
using RastreioEncomenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RastreioEncomenda.Servico.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class LocalidadesControllerBase<Entidade, EntidadeDTO> : Controller
        where Entidade : LocalidadesEntidadeBase
        where EntidadeDTO : LocalidadesBaseDTO
    {
        readonly protected ILocalidadesAppBase<Entidade, EntidadeDTO> app;

        public LocalidadesControllerBase(ILocalidadesAppBase<Entidade, EntidadeDTO> app)
        {
            this.app = app;
        }

        [HttpGet]
        [Route("SelecionarPorId/{Cep}")]
        public IActionResult SelecionarPorId(string Cep)
        {
            try
            {
                var localidade = app.SelecionarPorId(Cep);
                return new OkObjectResult(localidade);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
