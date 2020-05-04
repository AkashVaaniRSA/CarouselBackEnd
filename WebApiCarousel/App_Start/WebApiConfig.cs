using Carousel.BusinessLogic;
using Carousel.BusinessLogicData.CarouselBusinessLogic;
using Carousel.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Unity;
using Unity.Lifetime;

namespace WebApiCarousel
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            var container = new UnityContainer();
            container.RegisterType<IBL,CarouselBL>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);
            container.AddNewExtension<UnityExtension>();

        }
    }
}





