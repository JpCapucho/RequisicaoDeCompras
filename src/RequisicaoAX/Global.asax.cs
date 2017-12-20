using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;

namespace RequisicaoAX
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Esta linha eh responsavel por ativar o log4net
            log4net.Config.XmlConfigurator.Configure();

            //Ao inicializar a aplicação inicia o NHibernateSessionFactory da Aplicação
            NHibernate.Helper.Management.SessionManager.Instance.InitializeSessionFactory();

            //new RequisicaoAX.Dynamics.Services.Service().fazerAlgo();
        }


        void Session_Start(object sender, EventArgs e)
        {
            
        }

        void Application_BeginRequest(object sender, EventArgs e)
        {
            // url sempre minuscula
            string cTheLowerUrl = HttpContext.Current.Request.Path.ToLowerInvariant();
            if (cTheLowerUrl != HttpContext.Current.Request.Path)
            {
                HttpContext.Current.Response.Redirect(cTheLowerUrl + HttpContext.Current.Request.Url.Query);
            }
        }

        void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        void Application_Error(object sender, EventArgs e)
        {

        }

        void Session_End(object sender, EventArgs e)
        {

        }

        void Application_End(object sender, EventArgs e)
        {

        }
    }
}