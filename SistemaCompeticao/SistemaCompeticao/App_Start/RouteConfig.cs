using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SistemaCompeticao
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Membro_Cadastro",
                url: "Membro/Cadastro/{id}",
                defaults: new { controller = "Members", action = "Create", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Membro_Excluir",
                url: "Membro/Excluir/{id}",
                defaults: new { controller = "Members", action = "Delete", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Membro_Detalhes",
                url: "Membro/Detalhes/{id}",
                defaults: new { controller = "Members", action = "Details", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Membro_Editar",
                url: "Membro/Editar/{id}",
                defaults: new { controller = "Members", action = "Edit", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Membro_Listar",
                url: "Membros",
                defaults: new { controller = "Members", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
