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
        const string ISM_REST_ROOT = "http://192.168.5.200/infos/ism/public";
        const string MEDIA_TYPE = "application/json";
        #endregion

        public static string GetDataSync(string endpoint, int waitFlag)
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
                    else
                    {
                        throw new Exception();
                    }

                    return null;
                }
            }
            catch (Exception ex)
            {
                if (waitFlag == 0)
                {
                    waitFlag++;
                    return GetDataSync(endpoint, waitFlag);
                }
                else if (waitFlag == 4)
                {
                    Thread.Sleep(1000 * 3600 * 24);
                    return GetDataSync(endpoint, waitFlag);
                }
                else
                {
                    Thread.Sleep(1000 * 3600 * waitFlag);
                    waitFlag++;
                    return GetDataSync(endpoint, waitFlag);
                }
            }

        }


    }
}
