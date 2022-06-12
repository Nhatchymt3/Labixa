using Labixa.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Labixa
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            #region HomePage

            //routes.MapRoute("BeLabixa", "be-labixa-ngoi-nha-giua-bien",
            // new { controller = "Home", action = "Belabixa", id = UrlParameter.Optional });


            routes.MapRoute("LabixaTour", "tour-labixa",
           new { controller = "Home", action = "HomePageTour", id = UrlParameter.Optional });

            routes.MapRoute("LabixaService", "dich-vu-labixa",
        new { controller = "Home", action = "HomePageNews", slug = "dich-vu-labixa" });

            routes.MapRoute("Blogs", "tin-tuc-su-kien",
           new { controller = "Home", action = "HomePageNews", slug = "tin-tuc-su-kien" });

            routes.MapRoute("BlogsPromotion", "tin-khuyen-mai",
         new { controller = "Home", action = "HomePageNews", slug = "tin-khuyen-mai" });

            routes.MapRoute("Contact", "lien-he",
          new { controller = "Home", action = "Contact", id = UrlParameter.Optional });

            #endregion
            routes.MapRoute("LabixaDetailTour6", "be-labixa-ngoi-nha-giua-bien",
new { controller = "Home", action = "AlbumTravelBoat" });

            routes.MapRoute("LabixaDetailTour4", "daily-tour-labixa",
    new { controller = "Home", action = "MoreDailyTour" });

            routes.MapRoute("LabixaDetailTour5", "long-tour-labixa",
    new { controller = "Home", action = "MoreLongTour" });

            routes.MapRoute("LabixaDetailTour", "tour-labixa/{slug}",
                            new { controller = "Home", action = "DetailTour", slug = UrlParameter.Optional });
            routes.MapRoute("LabixaDetailTour2", "daily-tour-labixa/{slug}",
                     new { controller = "Home", action = "DetailTour", slug = UrlParameter.Optional });
            routes.MapRoute("LabixaDetailTour3", "long-tour-labixa/{slug}",
                     new { controller = "Home", action = "DetailTour", slug = UrlParameter.Optional });

            routes.MapRoute("LabixaDetailNews", "tin-tuc-su-kien/{slug}",
                            new { controller = "Home", action = "DetailNews", slug = UrlParameter.Optional });
            routes.MapRoute("LabixaDetailNews2", "tin-khuyen-mai/{slug}",
                          new { controller = "Home", action = "DetailNews", slug = UrlParameter.Optional });
            routes.MapRoute("LabixaDetailNews3", "dich-vu-labixa/{slug}",
                       new { controller = "Home", action = "DetailNews", slug = UrlParameter.Optional });
            routes.MapRoute("LabixaDetailStatic", "gioi-thieu",
                     new { controller = "Home", action = "DetailNews", slug = "gioi-thieu" });

            routes.MapRoute("LabixaDetailStatic2", "thong-tin/{slug}",
              new { controller = "Home", action = "DetailNews", slug = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }


    }
}
