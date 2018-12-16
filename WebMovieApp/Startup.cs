using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMovieApp.Startup))]
namespace WebMovieApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
