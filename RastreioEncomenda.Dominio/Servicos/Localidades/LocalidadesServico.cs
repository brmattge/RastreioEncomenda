using RastreioEncomenda.Dominio.Entidades;
using RastreioEncomenda.Dominio.Interfaces.Repositorios;
using RastreioEncomenda.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Dominio.Servicos
{
    public class LocalidadesServico : LocalidadesServicoBase<Localidades>, ILocalidadesServico
    {
        public LocalidadesServico(ILocalidadesRepositorio repositorio)
            : base(repositorio)
        {

        }
    }
}
