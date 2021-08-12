using RastreioEncomenda.Dominio.Entidades;
using RastreioEncomenda.Dominio.Interfaces.Repositorios;
using RastreioEncomenda.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Dominio.Servicos
{
    public class EncomendasServico : EncomendasServicoBase<Encomendas>, IEncomendasServico
    {
        public EncomendasServico(IEncomendasRepositorio repositorio)
            : base(repositorio)
        {

        }
    }
}
