using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AplikacijaZaEvidencijuKupaca.Startup))]
namespace AplikacijaZaEvidencijuKupaca
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
