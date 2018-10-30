using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using Championship.Application.Interfaces;
using Championship.Application;
using Championship.Domain.Services;
using Championship.Domain.Interfaces.Services;
using Championship.Domain.Interfaces;
using System.Web.Http;

namespace Championship.AutoMapper
{
    public class ContainerConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()); //Register WebApi Controllers

            builder
                .RegisterGeneric(typeof(AppServiceBase<>))
                .As(typeof(IAppServiceBase<>))
                .InstancePerDependency();
            
            builder.RegisterType<TournamentAppService>().As<ITournamentAppService>();

            builder
              .RegisterGeneric(typeof(ServiceBase<>))
              .As(typeof(IServiceBase<>))
              .InstancePerDependency();
            
            builder.RegisterType<TournamentService>().As<ITournamenteService>();

            var container = builder.Build();

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container); //Set the WebApi DependencyResolver
            
        }
    }
}