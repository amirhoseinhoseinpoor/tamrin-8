using System;
using System.Net;
class Currency
{
    static void ReadAPI(string[] args)
    {
        using var client = new WebClient();
        var content = client.DownloadString("https://api.kucoin.com/api/v1/market/stats?symbol=btc-USDT");
        StreamWriter writer = new StreamWriter(content);
        writer.WriteLine(content);
        Console.WriteLine(content);
    }

}
