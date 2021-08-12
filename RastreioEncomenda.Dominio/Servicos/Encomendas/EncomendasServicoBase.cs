using RastreioEncomenda.Dominio.Entidades;
using RastreioEncomenda.Dominio.Interfaces.Repositorios;
using RastreioEncomenda.Dominio.Interfaces.Servicos;
using System.Collections.Generic;

namespace RastreioEncomenda.Dominio.Servicos
{
    public class EncomendasServicoBase<TEntidade> : IEncomendasServicoBase<TEntidade>
        where TEntidade: EncomendasEntidadeBase
    {
        protected readonly IEncomendasRepositorioBase<TEntidade> repositorio;

        public EncomendasServicoBase(IEncomendasRepositorioBase<TEntidade> repositorio)
        {
            this.repositorio = repositorio;
        }

        public IEnumerable<TEntidade> Listar()
        {
            return repositorio.Listar();
        }

        public IEnumerable<TEntidade> ListarPor(int IdPessoa)
        {
            return repositorio.ListarPor(x => x.IdPessoa == IdPessoa);
        }

        public TEntidade SelecionarPorId(int Id)
        {
            return repositorio.SelecionarPorId(Id);
        }
        public int Incluir(TEntidade entidade)
        {
            return repositorio.Incluir(entidade);
        }

        public void Alterar(TEntidade entidade)
        {
            repositorio.Alterar(entidade);
        }

        public void Excluir(int id)
        {
            repositorio.Excluir(id);
        }
    }
}
