using AutoMapper;
using RastreioEncomenda.Aplicacao.DTO;
using RastreioEncomenda.Aplicacao.Interface;
using RastreioEncomenda.Dominio.Entidades;
using RastreioEncomenda.Dominio.Interfaces.Servicos;
using System.Collections.Generic;

namespace RastreioEncomenda.Aplicacao.Servicos
{
    public class EncomendasServicoAppBase<TEntidade, TEntidadeDTO> : IEncomendasAppBase<TEntidade, TEntidadeDTO>
        where TEntidade : EncomendasEntidadeBase
        where TEntidadeDTO : EncomendasBaseDTO
    {
        protected readonly IEncomendasServicoBase<TEntidade> servico;
        protected readonly IMapper iMapper;

        public EncomendasServicoAppBase(IMapper iMapper, IEncomendasServicoBase<TEntidade> servico)
            : base()
        {
            this.iMapper = iMapper;
            this.servico = servico;
        }

        public IEnumerable<TEntidadeDTO> Listar()
        {
            return iMapper.Map<IEnumerable<TEntidadeDTO>>(servico.Listar());
        }

        public IEnumerable<TEntidadeDTO> ListarPor(int Id)
        {
            return iMapper.Map<IEnumerable<TEntidadeDTO>>(servico.ListarPor(Id));
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
