using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureSql.Startup))]
namespace AzureSql
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
