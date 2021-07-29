using Microsoft.Extensions.DependencyInjection;
using RastreioEncomenda.Aplicacao.Interface;
using RastreioEncomenda.Aplicacao.Servicos;
using RastreioEncomenda.Dominio.Interfaces.Repositorios;
using RastreioEncomenda.Dominio.Interfaces.Servicos;
using RastreioEncomenda.Dominio.Servicos;
using RastreioEncomenda.Infra.Data.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreioEncomenda.Infra.IoC
{
    public class InjetorDependencias
    {
        public static void Registrar(IServiceCollection svcCollection)
        {
            //Aplicação
            svcCollection.AddScoped(typeof(ILocalidadesAppBase<,>), typeof(LocalidadesServicoAppBase<,>));
            svcCollection.AddScoped<ILocalidadesApp, LocalidadesApp>();

            svcCollection.AddScoped(typeof(IPessoasAppBase<,>), typeof(PessoasServicoAppBase<,>));
            svcCollection.AddScoped<IPessoasApp, PessoasApp>();

            //Domínio
            svcCollection.AddScoped(typeof(ILocalidadesServicoBase<>), typeof(LocalidadesServicoBase<>));
            svcCollection.AddScoped<ILocalidadesServico, LocalidadesServico>();

            svcCollection.AddScoped(typeof(IPessoasServicoBase<>), typeof(PessoasServicoBase<>));
            svcCollection.AddScoped<IPessoasServico, PessoasServico>();

            //Repositório
            svcCollection.AddScoped(typeof(ILocalidadesRepositorioBase<>), typeof(LocalidadesRepositorioBase<>));
            svcCollection.AddScoped<ILocalidadesRepositorio, LocalidadesRepositorio>();

            svcCollection.AddScoped(typeof(IPessoasRepositorioBase<>), typeof(PessoasRepositorioBase<>));
            svcCollection.AddScoped<IPessoasRepositorio, PessoasRepositorio>();
        }
    }
}
