using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CourtFeedback4.Startup))]
namespace CourtFeedback4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
