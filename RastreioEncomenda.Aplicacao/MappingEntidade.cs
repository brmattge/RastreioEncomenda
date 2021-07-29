using AutoMapper;
using RastreioEncomenda.Aplicacao.DTO;
using RastreioEncomenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Aplicacao
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
            CreateMap<Localidades, LocalidadesDTO>();
            CreateMap<LocalidadesDTO, Localidades>();

            CreateMap<Pessoas, PessoasDTO>();
            CreateMap<PessoasDTO, Pessoas>();
        }
    }
}
