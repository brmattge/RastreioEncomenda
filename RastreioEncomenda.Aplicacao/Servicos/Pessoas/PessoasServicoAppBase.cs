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
    public class PessoasServicoAppBase<TEntidade, TEntidadeDTO> : IPessoasAppBase<TEntidade, TEntidadeDTO>
        where TEntidade : PessoasEntidadeBase
        where TEntidadeDTO : PessoasBaseDTO
    {
        protected readonly IPessoasServicoBase<TEntidade> servico;
        protected readonly IMapper iMapper;

        public PessoasServicoAppBase(IMapper iMapper, IPessoasServicoBase<TEntidade> servico)
            : base()
        {
            this.iMapper = iMapper;
            this.servico = servico;
        }

        public IEnumerable<TEntidadeDTO> Listar()
        {
            return iMapper.Map<IEnumerable<TEntidadeDTO>>(servico.Listar());
        }

        public TEntidadeDTO SelecionarPorId(int Id)
        {
            return iMapper.Map<TEntidadeDTO>(servico.SelecionarPorId(Id));
        }
        public int Incluir(TEntidadeDTO entidade)
        {
            return servico.Incluir(iMapper.Map<TEntidade>(entidade));
        }

        public void Alterar(TEntidadeDTO entidade)
        {
            servico.Alterar(iMapper.Map<TEntidade>(entidade));
        }

        public void Excluir(int id)
        {
            servico.Excluir(id);
        }
    }
}
