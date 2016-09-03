using System.Web.Http;

namespace Demo03
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                // 當接收到 uri 含有 api/Products 或 api/products, 就會自動對應到 ProductsController
            );
        }
    }
}
