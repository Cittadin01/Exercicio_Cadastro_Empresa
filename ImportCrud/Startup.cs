using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImportCrud.Startup))]
namespace ImportCrud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
