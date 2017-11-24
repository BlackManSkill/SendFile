using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SendFile.Startup))]
namespace SendFile
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
