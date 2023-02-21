using System;
using System.Net;
using System.Net.NetworkInformation;

namespace NetworkAndInternetConnect
{
    public class NetUtil
    {
        public static string[] GetIpAddress(string domain)
        {
            try
            {
                IPHostEntry hostInfo = Dns.GetHostEntry(domain);
                IPAddress[] ips = hostInfo.AddressList;
                string[] sIps = new string[ips.Length];
                for (int i = 0; i < ips.Length; i++)
                {
                    sIps[i] = ips[i].ToString();
                }
                return sIps;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error message: {ex.Message}");
                return new string[0];
            }
        }
        public static bool CheckInternetConnection()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}