using System.Configuration;
using System.Text;

public class Utilities
{
    private static string _logFileName = ConfigurationManager.AppSettings["LogFileName"];

    public static void InsertLogs(string method, string errorMsg)
    {
        StreamWriter writer;

        try
        {
            writer = new StreamWriter(_logFileName, true);
        }
        catch (Exception)
        {
            writer = new StreamWriter(_logFileName, true);
        }

        var stringBuilder = new StringBuilder();

        stringBuilder.AppendLine("Date: " + DateTime.Now.ToString("g"));
        stringBuilder.AppendLine("Method: " + method);
        stringBuilder.AppendLine("Error Message: " + errorMsg);
        stringBuilder.AppendLine("*************************************************************************");

        var errorMessage = stringBuilder.ToString();

        try
        {
            writer.WriteLine(errorMessage);
        }
        catch (Exception)
        {
            writer.WriteLine(errorMessage);
        }
        finally
        {
            writer.Close();
        }
    }
}