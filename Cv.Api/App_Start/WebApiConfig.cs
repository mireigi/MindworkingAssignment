using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Microsoft.Extensions.DependencyInjection;
using Cv.Api.DependencyInjection;
using Cv.Core.Data;
using Cv.Data.InMemory;
using System.Web.Http.Controllers;
using Cv.GraphQL;
using Cv.GraphQL.Queries;
using Cv.Data.Source.InMemory;

namespace Cv.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            ConfigureDependencyInjection(config);
        }

        private static void ConfigureDependencyInjection(HttpConfiguration config)
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);

            config.DependencyResolver = new DefaultDependencyResolver(services.BuildServiceProvider());
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ISkillRepository, SkillRepository>();
            services.AddTransient<ICompanyRepository, CompanyRepository>();
            services.AddTransient<IProjectRepository, ProjectRepository>();
            services.AddTransient<IEducationRepository, EducationRepository>();

            services.AddTransient<DataSource>();
            services.AddTransient<GraphQueryService>();
            services.AddTransient<MultiQuery>();
            services.AddClassesAsServices<Startup, IHttpController>();
        }
    }
}