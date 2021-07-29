using RastreioEncomenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Dominio.Interfaces.Servicos
{
    public interface IPessoasServicoBase<TEntidade>
        where TEntidade : PessoasEntidadeBase
    {
        IEnumerable<TEntidade> Listar();
        TEntidade SelecionarPorId(int Id);
        int Incluir(TEntidade entidade);
        void Alterar(TEntidade entidade);
        void Excluir(int id);        
    }
}
