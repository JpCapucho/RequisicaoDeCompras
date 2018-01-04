using RequisicaoAX.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RequisicaoAX.App_Start
{
    public static class WebToolsAndUtils
    {
        /// <summary>
        /// Recebe um context e seta a sessao com os dados do usuario
        /// </summary>
        /// <param name="context"><seealso cref="HttpContext"/></param>
        /// <returns>nome do usuario logado</returns>
        public static string GetUserName(HttpContext context)
        {
            if(context.User.Identity.Name.Contains("\\"))
            {
                var s = context.User.Identity.Name.Split(new string[] { "\\" }, StringSplitOptions.None);

                var ub = new UsuarioBusiness().GetById();

                return s[s.Length - 1].ToString();
            }

            return context.User.Identity.Name;
        }
    }
}