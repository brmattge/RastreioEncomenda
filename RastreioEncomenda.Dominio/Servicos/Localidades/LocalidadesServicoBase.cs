using RastreioEncomenda.Dominio.Entidades;
using RastreioEncomenda.Dominio.Interfaces.Repositorios;
using RastreioEncomenda.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Dominio.Servicos
{
    public class LocalidadesServicoBase<TEntidade> : ILocalidadesServicoBase<TEntidade>
        where TEntidade: LocalidadesEntidadeBase
    {
        protected readonly ILocalidadesRepositorioBase<TEntidade> repositorio;

        public LocalidadesServicoBase(ILocalidadesRepositorioBase<TEntidade> repositorio)
        {
            this.repositorio = repositorio;
        }

        public TEntidade SelecionarPorId(string Cep)
        {
            return repositorio.SelecionarPorId(Cep);
        }
    }
}
