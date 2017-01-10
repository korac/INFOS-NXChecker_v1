using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace INFOS_NXChecker_service
{
    class RestHelpers
    {
        #region REST parameters
        const string ISM_REST_ROOT = "http://192.168.5.200/infos/ism/public";
        const string MEDIA_TYPE = "application/json";
        #endregion

        public static string GetData(string endpoint)
        {
            string url = ISM_REST_ROOT + endpoint;

            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = client.GetAsync(url).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = content.ReadAsStringAsync().Result;

                        if(data != null)
                        {
                            return data;
                        }
                    }
                }

                return null;
            }
        }
    }
}
