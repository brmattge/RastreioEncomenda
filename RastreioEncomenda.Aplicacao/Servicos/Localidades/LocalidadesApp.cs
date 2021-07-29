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
    public class LocalidadesApp : LocalidadesServicoAppBase<Localidades, LocalidadesDTO>, ILocalidadesApp
    {
        public LocalidadesApp(IMapper iMapper, ILocalidadesServico servico)
            : base(iMapper, servico)
        {

        }
    }
}
