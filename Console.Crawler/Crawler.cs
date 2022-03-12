using HtmlAgilityPack;
using System.Net;

public class Crawler
{
    public static List<string> GetImageList(string domain, string type)
    {
        string url = domain + type;
        List<string> list = new List<string>();

        try
        {
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "A101Crawler/1.0");
            string html = client.DownloadString(url);

            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(html);

            HtmlNodeCollection images = document.DocumentNode.SelectNodes("//div[@class='view-area']//img/@src");

            foreach (var image in images)
            {
                list.Add(image.GetAttributeValue("src", "nothing"));
            }
        }
        catch (Exception ex)
        {
            Utilities.InsertLogs("GetImageList()", ex.Message);
        }

        return list;
    }
}