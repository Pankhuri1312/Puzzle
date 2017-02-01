using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScramblePuzzle.Startup))]
namespace ScramblePuzzle
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            //ConfigureAuth(app);
        }
    }
}
