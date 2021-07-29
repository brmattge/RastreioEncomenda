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
    public class PessoasControllerBase<Entidade, EntidadeDTO> : Controller
        where Entidade : PessoasEntidadeBase
        where EntidadeDTO : PessoasBaseDTO
    {
        readonly protected IPessoasAppBase<Entidade, EntidadeDTO> app;

        public PessoasControllerBase(IPessoasAppBase<Entidade, EntidadeDTO> app)
        {
            this.app = app;
        }

        [HttpGet]
        [Route("Listar")]
        public IActionResult Listar()
        {
            try
            {
                var pessoas = app.Listar();
                return new OkObjectResult(pessoas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("SelecionarPorId/{Id}")]
        public IActionResult SelecionarPorId(int Id)
        {
            try
            {
                var pessoa = app.SelecionarPorId(Id);
                return new OkObjectResult(pessoa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("Incluir")]
        public IActionResult Incluir([FromBody] EntidadeDTO dado)
        {
            try
            {
                return new OkObjectResult(app.Incluir(dado));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("Alterar")]
        public IActionResult Alterar([FromBody] EntidadeDTO dado)
        {
            try
            {
                app.Alterar(dado);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            try
            {
                app.Excluir(id);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
