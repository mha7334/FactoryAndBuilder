using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FactoryAndBuilderPatternApp.Startup))]
namespace FactoryAndBuilderPatternApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
