using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Dominio.Entidades
{
    public class Localidades : LocalidadesEntidadeBase
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
