using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetReact.Startup))]
namespace AspNetReact
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
