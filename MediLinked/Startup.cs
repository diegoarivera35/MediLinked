using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MediLinked.Startup))]
namespace MediLinked
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
