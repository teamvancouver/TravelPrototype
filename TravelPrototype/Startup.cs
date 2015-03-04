using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravelPrototype.Startup))]
namespace TravelPrototype
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
