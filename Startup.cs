using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DNCHK_K1159610.Startup))]
namespace DNCHK_K1159610
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
