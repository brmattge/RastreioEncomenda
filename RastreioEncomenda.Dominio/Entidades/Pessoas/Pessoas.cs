using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Dominio.Entidades
{
    public class Pessoas : PessoasEntidadeBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
    }
}
