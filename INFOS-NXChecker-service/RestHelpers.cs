using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;

namespace INFOS_NXChecker_service
{
    class RestHelpers
    {
        #region REST parameters
        const string ISM_REST_ROOT  = "http://192.168.5.200/infos/ism/public";
        const string CONTENT_TYPE     = "application/json";
        #endregion

        public static string GetDataSync(string endpoint)
        {
            string url = ISM_REST_ROOT + endpoint;

            try
            {
                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage response = client.GetAsync(url).Result)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        using (HttpContent content = response.Content)
                        {
                            string data = content.ReadAsStringAsync().Result;

                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }

                    return String.Empty;                    
                }
            }
            catch (Exception ex)
            {
                return String.Empty;
            }

        }

        public static bool PostDataSync(string endpoint, string jsonData)
        {
            string url = ISM_REST_ROOT + endpoint;

            StringContent postContent = new StringContent(jsonData, Encoding.UTF8, CONTENT_TYPE);

            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = client.PostAsync(url, postContent).Result)
            using (HttpContent content = response.Content)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }

                return false;

                //string data = await content.ReadAsStringAsync();
                //if(data != null)
                //{
                //    Console.WriteLine("");
                //}
            }
        }


    }
}
