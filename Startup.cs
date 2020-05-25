using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IT_GAMK_Aud5_MVC.Startup))]
namespace IT_GAMK_Aud5_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
