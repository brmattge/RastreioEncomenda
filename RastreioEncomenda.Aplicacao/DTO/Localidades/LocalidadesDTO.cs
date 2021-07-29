using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Aplicacao.DTO
{
    public class LocalidadesDTO : LocalidadesBaseDTO
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
