using System;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace FrozenInventorySystem
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Configuration spécifique à l'authentification
            System.Web.Helpers.AntiForgeryConfig.UniqueClaimTypeIdentifier =
                System.Security.Claims.ClaimTypes.NameIdentifier;
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            if (HttpContext.Current.User != null)
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    if (HttpContext.Current.User.Identity is FormsIdentity)
                    {
                        // Récupérer le ticket d'authentification
                        var id = (FormsIdentity)HttpContext.Current.User.Identity;
                        var ticket = id.Ticket;

                        // Récupérer les rôles depuis le ticket
                        string[] roles = ticket.UserData.Split(',');

                        // Créer le principal avec les rôles
                        HttpContext.Current.User = new GenericPrincipal(id, roles);
                    }
                }
            }
        }
    }
}