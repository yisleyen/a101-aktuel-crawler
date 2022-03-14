string domain = "https://www.a101.com.tr";

string thisWeek = "/aldin-aldin-bu-hafta-brosuru";
string nextWeek = "/aldin-aldin-gelecek-hafta-brosuru";
string starsOfTheWeek = "/afisler-haftanin-yildizlari";

List<string> thisWeekImages = Crawler.GetImageList(domain, thisWeek);
List<string> nextWeekImages = Crawler.GetImageList(domain, nextWeek);
List<string> starsOfTheWeekImages = Crawler.GetImageList(domain, starsOfTheWeek);

Json.JsonCreate(thisWeekImages, nextWeekImages, starsOfTheWeekImages);

Console.ReadKey();