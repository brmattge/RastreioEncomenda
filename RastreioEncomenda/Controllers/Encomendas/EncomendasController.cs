using RastreioEncomenda.Aplicacao.DTO;
using RastreioEncomenda.Aplicacao.Interface;
using RastreioEncomenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RastreioEncomenda.Servico.Api.Controllers
{
    public class EncomendasController : EncomendasControllerBase<Encomendas, EncomendasDTO>
    {
        public EncomendasController(IEncomendasApp app)
            : base(app)
        { }
    }
}
