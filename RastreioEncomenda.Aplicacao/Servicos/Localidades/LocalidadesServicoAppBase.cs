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
    public class LocalidadesServicoAppBase<TEntidade, TEntidadeDTO> : ILocalidadesAppBase<TEntidade, TEntidadeDTO>
        where TEntidade : LocalidadesEntidadeBase
        where TEntidadeDTO : LocalidadesBaseDTO
    {
        protected readonly ILocalidadesServicoBase<TEntidade> servico;
        protected readonly IMapper iMapper;

        public LocalidadesServicoAppBase(IMapper iMapper, ILocalidadesServicoBase<TEntidade> servico)
            : base()
        {
            this.iMapper = iMapper;
            this.servico = servico;
        }
        
        public TEntidadeDTO SelecionarPorId(string Cep)
        {
            return iMapper.Map<TEntidadeDTO>(servico.SelecionarPorId(Cep));
        }
    }
}
