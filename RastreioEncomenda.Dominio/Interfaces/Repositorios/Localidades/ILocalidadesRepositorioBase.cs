using RastreioEncomenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Dominio.Interfaces.Repositorios
{
    public interface ILocalidadesRepositorioBase<TEntidade>
        where TEntidade : LocalidadesEntidadeBase
    {
        TEntidade SelecionarPorId(string Cep);
    }
}
