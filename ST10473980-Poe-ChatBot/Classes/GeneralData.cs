namespace ST10473980_Poe_ChatBot.Classes;
using System.Text.Json.Serialization;

/// <summary>
/// Represents a single response entry in the chatbot data file.
/// Each entry contains a list of keywords and the response that
/// should be returned when one of the keywords is detected.
/// </summary>
public class GeneralData
{
    /// <summary>
    /// List of keywords used to match user input.
    /// If the user message contains any of these keywords,
    /// the associated response will be returned.
    /// </summary>
    [JsonPropertyName("keywords")]
    public List<string> Keywords { get; set; } = new();

    /// <summary>
    /// The response text that the chatbot will display
    /// when a matching keyword is found.
    /// </summary>
    [JsonPropertyName("response")]
    public string Response { get; set; } = string.Empty;
}