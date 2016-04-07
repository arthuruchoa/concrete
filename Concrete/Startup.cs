using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Concrete.Startup))]
namespace Concrete
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
