using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using CalendArt.Models;
using System.Configuration;

namespace CalendArt.App_Start
{
    public class AuthConfig
    {
        public void RegisterAuth()
        {
            string clientId;
            string clientSecret;

            clientId = ConfigurationManager.AppSettings["clientId"] ;
            clientSecret = ConfigurationManager.AppSettings["clientSecret"];

            OAuthWebSecurity.RegisterClient(new GoogleClient(clientId, clientSecret), "Google", null);
        }






    }
}