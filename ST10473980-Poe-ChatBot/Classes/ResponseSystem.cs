using System.Text.Json;

namespace ST10473980_Poe_ChatBot.Classes;

public class ResponseSystem
{
    private Dictionary<string, string> generalDictionary = new();
    private User _user;

    public ResponseSystem(User user)
    {
        _user = user;
        string json = File.ReadAllText("Data/Jsons/General-Response.json");

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

    public string GetResponse(string input)
    {
        input = input.ToLower().Trim();

        foreach (var pair in generalDictionary)
        {
            if ((" " + input + " ").Contains(" " + pair.Key + " "))
            {
                string addedUser = pair.Value;

                if (addedUser.Contains("{name} {surname}"))
                {
                    addedUser = addedUser.Replace("{name} {surname}", $"{_user.GetName()} {_user.GetSurname()}");
                }
                else if (addedUser.Contains("{name}"))
                {
                    addedUser = addedUser.Replace("{name}", _user.GetName());
                }

                return addedUser;
            }
        }

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