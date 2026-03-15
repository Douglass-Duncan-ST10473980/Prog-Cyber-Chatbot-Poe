using System.Text.Json.Serialization;

namespace ST10473980_Poe_ChatBot.Classes;

/// <summary>
/// Represents the root structure of the chatbot JSON data file.
/// This class stores all general response entries that are loaded
/// from the external JSON configuration file.
/// </summary>
public class ChatData
{
    /// <summary>
    /// Stores the list of general chatbot responses.
    /// This list is populated from the "general" section
    /// of the JSON data file.
    /// </summary>
    [JsonPropertyName("general")]
    public List<GeneralData> General { get; set; } = new();
}