using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Game.Api_Helper
{
    public enum HTTPMETHOD
    {
        Get,
        Post,
        Put,
        Delet
    }
    class ApiManager
    {
        public static HttpWebRequest ClientHandler(HTTPMETHOD method, string path) {
            var url = path;

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = ApiManager.GetHttpMethod(method);

            httpRequest.Accept = "application/json";
            httpRequest.ContentType = "application/json";

            return httpRequest;
        }

        private static string GetHttpMethod(HTTPMETHOD method)
        {
            switch (method)
            {
                case HTTPMETHOD.Get: return "GET";
                case HTTPMETHOD.Post: return "POST";
                case HTTPMETHOD.Put: return "PUT";
                case HTTPMETHOD.Delet: return "DELETE";
                default:  return "GET";
            }
        }
    }
}
