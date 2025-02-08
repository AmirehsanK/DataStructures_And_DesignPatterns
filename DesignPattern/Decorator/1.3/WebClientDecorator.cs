using System.Net;

namespace DesignPattern.Decorator._1._3;

public class WebClientDecorator(WebClient webClient) : WebClient
{
    public string DownloadString(string address)
    {
        if (address == null!)
            return string.Empty;

        return address.StartsWith("http://www.google.com") ? webClient.DownloadString(address) : string.Empty;
    }
}