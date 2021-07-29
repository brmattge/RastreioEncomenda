using Microsoft.EntityFrameworkCore;
using RastreioEncomenda.Dominio.Entidades;
using RastreioEncomenda.Dominio.Interfaces.Repositorios;
using RastreioEncomenda.Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RastreioEncomenda.Infra.Data.Repositorios
{
    public class PessoasRepositorioBase<TEntidade> : IPessoasRepositorioBase<TEntidade>
        where TEntidade : PessoasEntidadeBase
    {
        protected readonly Contexto contexto;

        public PessoasRepositorioBase(Contexto contexto)
            : base()
        {
            this.contexto = contexto;
        }

        public IEnumerable<TEntidade> Listar()
        {
            return contexto.Set<TEntidade>().ToList();
        }

        public TEntidade SelecionarPorId(int Id)
        {
            return contexto.Set<TEntidade>().Find(Id);
        }

        public int Incluir(TEntidade entidade)
        {
            contexto.InitTransacao();
            var id = contexto.Set<TEntidade>().Add(entidade).Entity.Id;
            contexto.SendChanges();
            return id;
        }

        public void Alterar(TEntidade entidade)
        {
            contexto.InitTransacao();
            contexto.Set<TEntidade>().Attach(entidade);
            contexto.Entry(entidade).State = EntityState.Modified;
            contexto.SendChanges();
        }

        public void Excluir(int id)
        {
            var entidade = SelecionarPorId(id);
            if (entidade != null)
            {
                contexto.InitTransacao();
                contexto.Set<TEntidade>().Remove(entidade);
                contexto.SendChanges();
            }
        }        
    }
}
