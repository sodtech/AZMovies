using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A2ZMOVIES.Startup))]
namespace A2ZMOVIES
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
