using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Yale_VisualStudio_MVC.Startup))]
namespace Yale_VisualStudio_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
