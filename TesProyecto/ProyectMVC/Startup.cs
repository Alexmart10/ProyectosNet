using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectMVC.Startup))]
namespace ProyectMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
