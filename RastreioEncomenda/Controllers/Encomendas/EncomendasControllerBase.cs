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
    public class EncomendasControllerBase<Entidade, EntidadeDTO> : Controller
        where Entidade : EncomendasEntidadeBase
        where EntidadeDTO : EncomendasBaseDTO
    {
        readonly protected IEncomendasAppBase<Entidade, EntidadeDTO> app;

        public EncomendasControllerBase(IEncomendasAppBase<Entidade, EntidadeDTO> app)
        {
            this.app = app;
        }

        [HttpGet]
        [Route("Listar")]
        public IActionResult Listar()
        {
            try
            {
                var encomendas = app.Listar();
                return new OkObjectResult(encomendas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("ListarPorId/{IdPessoa}")]
        public IActionResult ListarPorId(int IdPessoa)
        {
            try
            {
                var encomendas = app.ListarPor(IdPessoa);
                return new OkObjectResult(encomendas);
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
                var encomenda = app.SelecionarPorId(Id);
                return new OkObjectResult(encomenda);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("Incluir")]
        public IActionResult Incluir(EntidadeDTO dado)
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
        public IActionResult Alterar(EntidadeDTO dado)
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
