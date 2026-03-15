using System.Text.Json;

namespace ST10473980_Poe_ChatBot.Classes;

/// <summary>
/// Handles all chatbot response logic.
/// This class loads response data from the JSON file,
/// stores keywords in a dictionary, and returns the
/// correct response based on the user input.
/// </summary>
public class ResponseSystem
{
    /// <summary>
    /// Dictionary used to store keywords and their associated responses.
    /// </summary>
    private Dictionary<string, string> generalDictionary = new();

    /// <summary>
    /// Stores the current user so that responses can be personalised.
    /// </summary>
    private User _user;

    /// <summary>
    /// Constructor for the ResponseSystem.
    /// Loads the JSON file and fills the dictionary with response data.
    /// </summary>
    public ResponseSystem(User user)
    {
        _user = user;

        //read JSON file
        string json = File.ReadAllText("Data/Jsons/General-Response.json");

        //deserialize JSON into ChatData object
        ChatData? data = JsonSerializer.Deserialize<ChatData>(json);

        if (data != null)
        {
            FillGeneralDictionary(data);
        }
        else
        {
            Console.WriteLine("JSON failed to load.");
        }
    }

    /// <summary>
    /// Fills the dictionary with keywords and responses
    /// from the JSON data structure.
    /// </summary>
    private void FillGeneralDictionary(ChatData data)
    {
        foreach (var item in data.General)
        {
            foreach (var keyword in item.Keywords)
            {
                generalDictionary[keyword.ToLower()] = item.Response;
            }
        }
    }

    /// <summary>
    /// Returns the correct chatbot response based on user input.
    /// The method searches for matching keywords and replaces
    /// placeholders with the user's name where required.
    /// </summary>
    public string GetResponse(string input)
    {
        input = input.ToLower().Trim();

        foreach (var pair in generalDictionary)
        {
            if ((" " + input + " ").Contains(" " + pair.Key + " "))
            {
                string addedUser = pair.Value;

                //replace name and surname placeholder
                if (addedUser.Contains("{name} {surname}"))
                {
                    addedUser = addedUser.Replace(
                        "{name} {surname}",
                        $"{_user.GetName()} {_user.GetSurname()}"
                    );
                }
                //replace name placeholder
                else if (addedUser.Contains("{name}"))
                {
                    addedUser = addedUser.Replace(
                        "{name}",
                        _user.GetName()
                    );
                }

                return addedUser;
            }
        }

        //default response if no keyword found
        return "Invalid entry:" +
               "\n\n      You can ask me about cyber safety topics." +
               "\n\n      Available topics:" +
               "\n      - Phishing" +
               "\n      - Password safety" +
               "\n      - Safe browsing" +
               "\n\n      You can ask:" +
               "\n      - what is phishing" +
               "\n      - how to avoid phishing" +
               "\n      - what is password safety" +
               "\n      - how to browse safely" +
               "\n\n      Type 'exit' to close the chatbot.";
    }
}