using ST10473980_Poe_ChatBot.Classes;

namespace ST10473980_Poe_ChatBot;

/// <summary>
/// Entry point of the chatbot application.
/// This class starts the program and creates the chatbot object.
/// </summary>
class Program
{
    /// <summary>
    /// Main method where the application begins execution.
    /// Creates a Chatbot instance and starts the program.
    /// </summary>
    /// <param name="args">
    /// Command line arguments (not used in this program).
    /// </param>
    static void Main(string[] args)
    {
        //create chatbot with typing delay value
        Chatbot chatbot = new Chatbot(20);

        //start chatbot
        chatbot.Start();
    }
}