using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASM_1.Startup))]
namespace ASM_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
