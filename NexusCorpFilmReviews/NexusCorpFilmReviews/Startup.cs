using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NexusCorpFilmReviews.Startup))]
namespace NexusCorpFilmReviews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
