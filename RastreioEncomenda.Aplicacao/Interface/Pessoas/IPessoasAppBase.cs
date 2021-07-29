using RastreioEncomenda.Aplicacao.DTO;
using RastreioEncomenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Aplicacao.Interface
{
    public interface IPessoasAppBase<TEntidade, TEntidadeDTO>
        where TEntidade : PessoasEntidadeBase
        where TEntidadeDTO : PessoasBaseDTO
    {
        IEnumerable<TEntidadeDTO> Listar();
        TEntidadeDTO SelecionarPorId(int Id);
        int Incluir(TEntidadeDTO entidade);
        void Alterar(TEntidadeDTO entidade);   
        void Excluir(int id);
    }
}
