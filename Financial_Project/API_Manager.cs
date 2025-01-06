using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
//using System.Web.Script.Serialization;
using System.Web;
using System.Text.Json;

namespace Financial_Project
{
    public class API_Manager
    {
        private static API_Manager aMan = new API_Manager();
        private string apiKey;
        HttpClient client = new HttpClient();
        JsonDocument data;
        private API_Manager()
        {
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string filePath = Path.GetDirectoryName(exePath);
            string projectPath = exePath.Substring(0, exePath.IndexOf("Financial_Project") + "Financial_Project".Length);
            filePath = Path.Combine(projectPath,"Financial_Project\\", "api_key.txt.user");
            apiKey = LoadApiKeyFromFile(filePath);
        }

        public static API_Manager GetInstance()
        {
            return aMan;
        }

        public async Task<JsonDocument> CallApiAsync(string address)
        {
            string data = client.GetStringAsync(address).Result;
            return JsonDocument.Parse(data);
        }

        public JsonDocument getFullHistorical(string ticker)
        {
            return data;//placeholder
        }

        public JsonDocument getShortHistorical(string ticker)
        {
            string address = $"https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={ticker}&apikey={apiKey}";
            data = CallApiAsync(address).Result;
            using (var stream = new MemoryStream())
            {
                using (var writer = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true }))
                {
                    data.WriteTo(writer);
                }
                string formattedJson = Encoding.UTF8.GetString(stream.ToArray());
            }
            return data;
        }

        public JsonDocument getIntraday(string ticker)
        {
            return data;//placeholder
        }

        public void setApiKey(string key)
        {
            apiKey = key;
        }

        private string LoadApiKeyFromFile(string filePath)
        {
            try
            {
                return File.ReadAllText(filePath).Trim();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading API key from file: {ex.Message}");
                return string.Empty;
            }
        }
    }
}
