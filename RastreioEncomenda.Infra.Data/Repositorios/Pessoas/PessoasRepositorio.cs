using RastreioEncomenda.Dominio.Entidades;
using RastreioEncomenda.Dominio.Interfaces.Repositorios;
using RastreioEncomenda.Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Infra.Data.Repositorios
{
    public class PessoasRepositorio : PessoasRepositorioBase<Pessoas>, IPessoasRepositorio
    {
        public PessoasRepositorio(Contexto contexto)
            : base(contexto)
        {
        }
    }
}
