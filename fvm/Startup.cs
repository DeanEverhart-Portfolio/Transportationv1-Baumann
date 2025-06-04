using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fvm.Startup))]
namespace fvm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
