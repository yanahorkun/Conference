using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Conferense.Startup))]
namespace Conferense
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
