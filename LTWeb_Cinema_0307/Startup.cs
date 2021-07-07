using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LTWeb_Cinema_0307.Startup))]
namespace LTWeb_Cinema_0307
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
