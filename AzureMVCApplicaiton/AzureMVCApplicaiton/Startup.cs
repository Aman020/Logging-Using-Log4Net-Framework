using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureMVCApplicaiton.Startup))]
namespace AzureMVCApplicaiton
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
