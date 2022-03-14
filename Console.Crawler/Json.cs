using Newtonsoft.Json;

public class Json
{
    public static void JsonCreate(List<string> thisWeekImages, List<string> nextWeekImages, List<string> starsOfTheWeekImages)
    {
        Links links = new Links();

        links.ThisWeek = thisWeekImages;
        links.NextWeek = nextWeekImages;
        links.StarsOfTheWeek = starsOfTheWeekImages;

        string result = JsonConvert.SerializeObject(links);

        string path = "A101.json";

        using (var jsonWriter = new StreamWriter(path, true))
        {
            jsonWriter.WriteLine(result);
            jsonWriter.Close();
        }
    }
}