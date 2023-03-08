using System;
using System.Net;

namespace NetworkAndInternetConnect
{
    public class HttpClientUtil
    {
        public static async Task<string> GetExternalIp()
        {
            HttpClient client = new HttpClient();
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                // using HttpResponseMessage response = await client.GetAsync("http://icanhazip.com");
                // response.EnsureSuccessStatusCode();
                // string responseBody = await response.Content.ReadAsStringAsync();

                string responseBody = await client.GetStringAsync("http://icanhazip.com");

                string externalIpString = responseBody.Replace("\\r\\n", "").Replace("\\n", "").Trim();
                IPAddress? externalIp;
                if (IPAddress.TryParse(externalIpString, out externalIp))
                {
                    return externalIpString;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return "";
        }

        public static async Task<bool> DownloadFile(string uri, string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            HttpClient client = new HttpClient();
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                using (var s = await client.GetStreamAsync(uri))
                using (var fs = new FileStream(filePath, FileMode.CreateNew))
                {
                    await s.CopyToAsync(fs);
                }
                return true;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return false;
        }
    }
}