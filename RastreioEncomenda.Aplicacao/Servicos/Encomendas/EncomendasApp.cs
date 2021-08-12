using AutoMapper;
using RastreioEncomenda.Aplicacao.DTO;
using RastreioEncomenda.Aplicacao.Interface;
using RastreioEncomenda.Dominio.Entidades;
using RastreioEncomenda.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Aplicacao.Servicos
{
    public class EncomendasApp : EncomendasServicoAppBase<Encomendas, EncomendasDTO>, IEncomendasApp
    {
        public EncomendasApp(IMapper iMapper, IEncomendasServico servico)
            : base(iMapper, servico)
        {

        }
    }
}
