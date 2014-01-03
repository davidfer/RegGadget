using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RegGadget.Startup))]
namespace RegGadget
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
