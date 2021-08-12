using RastreioEncomenda.Aplicacao.DTO;
using RastreioEncomenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RastreioEncomenda.Aplicacao.Interface
{
    public interface IEncomendasAppBase<TEntidade, TEntidadeDTO>
        where TEntidade : EncomendasEntidadeBase
        where TEntidadeDTO : EncomendasBaseDTO
    {
        IEnumerable<TEntidadeDTO> Listar();
        IEnumerable<TEntidadeDTO> ListarPor(int idPessoa);
        TEntidadeDTO SelecionarPorId(int Id);
        int Incluir(TEntidadeDTO entidade);
        void Alterar(TEntidadeDTO entidade);
        void Excluir(int id);
    }
}
