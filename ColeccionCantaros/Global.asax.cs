using ColeccionCantaros.App_Start;
using ColeccionCantaros.DAL;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ColeccionCantaros
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // Ejecutar inicializador BBDD
            Database.SetInitializer<CantarosContext>(new CantarosDbInitializer());
        }
    }
}
