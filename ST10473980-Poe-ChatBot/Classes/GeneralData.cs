namespace ST10473980_Poe_ChatBot.Classes;
using System.Text.Json.Serialization;

public class GeneralData
{
    [JsonPropertyName("keywords")]
    public List<string> Keywords { get; set; } = new();

    [JsonPropertyName("response")]
    public string Response { get; set; } = string.Empty;
}