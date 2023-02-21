using System.Net;
using NetworkAndInternetConnect;

Console.WriteLine($"External IP (WebClient): {WebClientUtil.GetExternalIpAddress()}");
Console.WriteLine($"External IP (WebReqRes): {WebReqRes.GetExternalIp()}");
Console.WriteLine($"External IP (HttpClient): {await HttpClientUtil.GetExternalIp()}");

if (NetUtil.CheckInternetConnection())
{
    Console.WriteLine("Internet connected!");
}

string name = "sinhnx.dev";
foreach (string ip in NetUtil.GetIpAddress(name))
{
    Console.WriteLine("{0} - {1}", name, ip);
}

if (WebClientUtil.DownloadFile("https://sinhnx.dev/uploads/6ce95b86-9a66-4d16-a97f-0a9f6e789cf1/dotnet-01_1140x450.jpg", "dotNet.jpg"))
{
    Console.WriteLine("Download file with WebClient completed!");
}

if (WebReqRes.DownloadFile("https://sinhnx.dev/uploads/6ce95b86-9a66-4d16-a97f-0a9f6e789cf1/dotnet-01_1140x450.jpg", "dotNet.jpg"))
{
    Console.WriteLine("Download file with WebRequest & WebResponse completed!");
}
else
{
    Console.WriteLine($"url not exists.");
}

if (await HttpClientUtil.DownloadFile("https://sinhnx.dev/uploads/6ce95b86-9a66-4d16-a97f-0a9f6e789cf1/dotnet-01_1140x450.jpg", "dotNet.jpg"))
{
    Console.WriteLine("Download file with HttpClient completed!");
}
else
{
    Console.WriteLine($"url not exists.");
}

// Console.WriteLine($"HTML Source code:");
// Console.WriteLine(WebClientUtil.GetHtmlSourceCode("https://sinhnx.dev"));