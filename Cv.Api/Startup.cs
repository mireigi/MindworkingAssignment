using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Cv.Api.Startup))]

namespace Cv.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}