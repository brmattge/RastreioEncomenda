using RastreioEncomenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Dominio.Interfaces.Servicos
{
    public interface ILocalidadesServicoBase<TEntidade>
        where TEntidade : LocalidadesEntidadeBase
    {
        TEntidade SelecionarPorId(string Cep);
    }
}
