using RastreioEncomenda.Dominio.Entidades;
using RastreioEncomenda.Dominio.Interfaces.Repositorios;
using RastreioEncomenda.Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Infra.Data.Repositorios
{
    public class EncomendasRepositorio : EncomendasRepositorioBase<Encomendas>, IEncomendasRepositorio
    {
        public EncomendasRepositorio(Contexto contexto)
            : base(contexto)
        {
        }
    }
}
