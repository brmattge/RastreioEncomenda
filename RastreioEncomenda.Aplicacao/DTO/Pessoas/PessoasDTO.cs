using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Aplicacao.DTO
{
    public class PessoasDTO : PessoasBaseDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
    }
}
