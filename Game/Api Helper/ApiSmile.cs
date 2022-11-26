using Newtonsoft.Json;
using Game.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Game.Api_Helper
{
    class ApiSmile
    {
        public static Smile GetSmileData(HTTPMETHOD method) {
            try
            {
                var httpRequest = ApiManager.ClientHandler(method, "https://marcconrad.com/uob/smile/api.php");

                var httResponse = (HttpWebResponse)httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return JsonConvert.DeserializeObject<Smile>(result);
                }
            }
            catch 
            {
                return null;
            }
        }
    }
}
