﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using Rentoolo;
using System.Web.Http;

namespace Rentoolo
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();

            RegisterRoutes(RouteTable.Routes);

        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = System.Web.Http.RouteParameter.Optional }
            );

            routes.MapPageRoute("advertsRoute",
                "Adverts/{id}",
                "~/Adverts.aspx");

            routes.MapPageRoute("testRoute",
                "test",
                "~/Test.aspx");

            routes.MapPageRoute("addItemRoute",
                "addItem",
                "~/Account/AddItem.aspx");

            routes.MapPageRoute("addRoute",
                "add",
                "~/Account/AddItem.aspx");

            routes.MapPageRoute("cashIn",
                "Account/CashIn",
                "~/Account/CashIn.aspx");

            routes.MapPageRoute("tokensRoute",
                "tokens",
                "~/Tokens.aspx");

            routes.MapPageRoute("tokensOperationsRoute",
                "tokensOperations",
                "~/TokensOperations.aspx");

            routes.MapPageRoute("TokensBuyingRoute",
                "TokensBuying",
                "~/TokensBuying.aspx");

            routes.MapPageRoute("TokensSellingRoute",
                "TokensSelling",
                "~/TokensSelling.aspx");


        }
    }
}
