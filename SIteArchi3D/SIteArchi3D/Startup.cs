using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SIteArchi3D.Startup))]
namespace SIteArchi3D
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
