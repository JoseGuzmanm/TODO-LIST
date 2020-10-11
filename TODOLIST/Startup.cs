using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TODOLIST.Startup))]
namespace TODOLIST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
