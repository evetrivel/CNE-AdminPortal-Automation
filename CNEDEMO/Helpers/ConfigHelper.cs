using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace CNEDEMO.Helpers
{
    public class ConfigHelper
    {
        public static IConfiguration GetConfig()
        {
            var builder = new ConfigurationBuilder().SetBasePath(System.AppContext.BaseDirectory).AddJsonFile("appSettings.PROD.json", optional: true, reloadOnChange: true); return builder.Build();
        }

        public static string GetBaseCneUrl()
        {
            return GetConfig()["url"];
        }
        public static string GetUserName()
        {
            return GetConfig()["username"];
        }
        public static string GetPassword()
        {
            return GetConfig()["password"];
        }

        public static string GetQA()
        {
            return GetConfig()["Q&A"];
        }


    }
}

