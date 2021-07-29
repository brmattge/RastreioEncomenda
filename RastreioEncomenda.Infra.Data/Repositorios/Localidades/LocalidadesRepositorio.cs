using RastreioEncomenda.Dominio.Entidades;
using RastreioEncomenda.Dominio.Interfaces.Repositorios;
using RastreioEncomenda.Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Infra.Data.Repositorios
{
    public class LocalidadesRepositorio : LocalidadesRepositorioBase<Localidades>, ILocalidadesRepositorio
    {
        public LocalidadesRepositorio(Contexto contexto)
            : base(contexto)
        {
        }
    }
}
