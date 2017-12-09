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
        }
    }
}