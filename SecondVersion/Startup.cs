using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecondVersion.Startup))]
namespace SecondVersion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
