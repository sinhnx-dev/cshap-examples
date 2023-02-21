using System;
using System.Net;
using System.Net.NetworkInformation;

namespace NetworkAndInternetConnect
{
    public class WebReqRes
    {
        public static string GetExternalIp()
        {
            WebRequest request = WebRequest.Create("http://icanhazip.com");
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Method = "GET";
            // Get the response.
            using (WebResponse response = request.GetResponse())
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                string externalIpString = responseFromServer.Replace("\\r\\n", "").Replace("\\n", "").Trim();
                IPAddress? externalIp;
                if (IPAddress.TryParse(externalIpString, out externalIp))
                {
                    return externalIpString;
                }
            }
            return "";
        }
        public static bool DownloadFile(string urlAddress, string filePath)
        {
            try
            {
                HttpWebRequest request;
                HttpWebResponse response;
                request = (HttpWebRequest)HttpWebRequest.Create(urlAddress);
                request.Timeout = 30000;  //8000 Not work 
                response = (HttpWebResponse)request.GetResponse();
                using (Stream s = response.GetResponseStream())
                using (FileStream os = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buff = new byte[102400];
                    int c = 0;
                    while ((c = s.Read(buff, 0, 10400)) > 0)
                    {
                        os.Write(buff, 0, c);
                        os.Flush();
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}