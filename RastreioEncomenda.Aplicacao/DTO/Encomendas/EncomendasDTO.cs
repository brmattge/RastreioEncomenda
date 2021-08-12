using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Aplicacao.DTO
{
    public class EncomendasDTO : EncomendasBaseDTO
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Status { get; set; }
    }
}
