using RastreioEncomenda.Dominio.Entidades;
using RastreioEncomenda.Dominio.Interfaces.Repositorios;
using RastreioEncomenda.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Dominio.Servicos
{
    public class PessoasServicoBase<TEntidade> : IPessoasServicoBase<TEntidade>
        where TEntidade: PessoasEntidadeBase
    {
        protected readonly IPessoasRepositorioBase<TEntidade> repositorio;

        public PessoasServicoBase(IPessoasRepositorioBase<TEntidade> repositorio)
        {
            this.repositorio = repositorio;
        }

        public IEnumerable<TEntidade> Listar()
        {
            return repositorio.Listar();
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
