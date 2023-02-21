using System;
using System.Net;
using System.Net.NetworkInformation;

namespace NetworkAndInternetConnect
{
    public class WebClientUtil
    {
        public static string GetExternalIpAddress()
        {
            try
            {
                using (var client = new WebClient { UseDefaultCredentials = true })
                {
                    string externalIpString = client.DownloadString("http://icanhazip.com").Replace("\\r\\n", "").Replace("\\n", "").Trim();
                    IPAddress? externalIp = null;
                    if (IPAddress.TryParse(externalIpString, out externalIp))
                    {
                        return externalIpString;
                    }
                }
            }
            catch { }
            return "";
        }
        public static bool DownloadFile(string uri, string fileName)
        {
            try
            {
                using (var client = new WebClient { UseDefaultCredentials = true })
                {
                    client.DownloadFile(uri, fileName);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static string GetHtmlSourceCode(string url)
        {
            try
            {
                using (var client = new WebClient { UseDefaultCredentials = true })
                {
                    return client.DownloadString(url);
                }
            }
            catch
            {
                return "";
            }
        }
    }
}