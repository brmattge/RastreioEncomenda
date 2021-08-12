using RastreioEncomenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Dominio.Interfaces.Servicos
{
    public interface IEncomendasServicoBase<TEntidade>
        where TEntidade : EncomendasEntidadeBase
    {
        IEnumerable<TEntidade> Listar();
        IEnumerable<TEntidade> ListarPor(int Id);
        TEntidade SelecionarPorId(int Id);
        int Incluir(TEntidade entidade);
        void Alterar(TEntidade entidade);
        void Excluir(int id);        
    }
}
