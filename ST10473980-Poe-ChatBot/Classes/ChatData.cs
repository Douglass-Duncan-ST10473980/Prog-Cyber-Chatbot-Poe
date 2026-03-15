using System.Text.Json.Serialization;

namespace ST10473980_Poe_ChatBot.Classes;

public class ChatData
{
    [JsonPropertyName("general")]
    public List<GeneralData> General { get; set; } = new();
}