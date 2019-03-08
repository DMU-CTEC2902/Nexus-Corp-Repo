using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExampleNexusCorpMVC.Startup))]
namespace ExampleNexusCorpMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
