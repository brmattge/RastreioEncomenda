using RastreioEncomenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RastreioEncomenda.Dominio.Interfaces.Repositorios
{
    public interface IEncomendasRepositorioBase<TEntidade>
        where TEntidade : EncomendasEntidadeBase
    {
        IEnumerable<TEntidade> Listar();
        IQueryable<TEntidade> ListarPor(Expression<Func<TEntidade, bool>> where, params Expression<Func<TEntidade, object>>[] includeProperties);
        TEntidade SelecionarPorId(int Id);
        int Incluir(TEntidade entidade);
        void Alterar(TEntidade entidade);
        void Excluir(int id);
    }
}
