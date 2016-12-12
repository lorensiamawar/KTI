using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KTI.Startup))]
namespace KTI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
