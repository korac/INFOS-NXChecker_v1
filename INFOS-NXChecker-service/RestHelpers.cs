using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;

namespace INFOS_NXChecker_service
{
    static class RestHelpers
    {
        #region REST parameters
        //const string ISM_REST_ROOT  = "http://192.168.5.200/infos/ism/public";
        const string CONTENT_TYPE   = "application/json";
        #endregion

        public static string GetDataSync(string url)
        {
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

        public static string PostDataSync(string url, string jsonData)
        {
            StringContent postContent = new StringContent(jsonData, Encoding.UTF8, CONTENT_TYPE);

            try
            {
                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage response = client.PostAsync(url, postContent).Result)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
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
            catch
            {
                return String.Empty;
            }
        }


    }
}
