using RastreioEncomenda.Dominio.Entidades;
using RastreioEncomenda.Dominio.Interfaces.Repositorios;
using RastreioEncomenda.Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Infra.Data.Repositorios
{
    public class LocalidadesRepositorioBase<TEntidade> : ILocalidadesRepositorioBase<TEntidade>
        where TEntidade : LocalidadesEntidadeBase
    {
        protected readonly Contexto contexto;

        public LocalidadesRepositorioBase(Contexto contexto)
            : base()
        {
            this.contexto = contexto;
        }

        public TEntidade SelecionarPorId(string Cep)
        {
            return contexto.Set<TEntidade>().Find(Cep);
        }
    }
}
