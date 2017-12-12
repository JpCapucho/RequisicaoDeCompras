using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RequisicaoAX.App_Start
{
    public static class WebToolsAndUtils
    {

        public static string GetUserName(HttpContext context)
        {
            if(context.User.Identity.Name.Contains("\\"))
            {
                var s = context.User.Identity.Name.Split(new string[] { "\\" }, StringSplitOptions.None);
                return s[s.Length - 1].ToString();
            }

            return context.User.Identity.Name;
        }
    }
}