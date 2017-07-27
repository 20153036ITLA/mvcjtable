using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jTableMvc.Startup))]
namespace jTableMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
