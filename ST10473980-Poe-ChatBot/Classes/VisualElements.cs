namespace ST10473980_Poe_ChatBot.Classes;

/// <summary>
/// Handles all visual output displayed in the console.
/// This includes colours, labels, typing effects,
/// startup and shutdown animations, and formatted messages.
/// </summary>
public class VisualElements
{
    /// <summary>
    /// Displays text one character at a time to create a typing effect.
    /// </summary>
    /// <param name="text">
    /// The text to display.
    /// </param>
    /// <param name="delay">
    /// The delay in milliseconds between each character.
    /// </param>
    public void TypeText(string text, int delay)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Displays the shutdown animation when the chatbot closes.
    /// </summary>
    public void Stop()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Cyber Chat Bot is shutting down");

        for (int i = 0; i < 4; i++)
        {
            Console.Write(".");
            Thread.Sleep(400);
        }

        Console.WriteLine();
        Console.ResetColor();
    }
    
    /// <summary>
    /// Displays the startup animation when the chatbot begins.
    /// </summary>
    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Cyber Chat Bot is starting up");

        for (int i = 0; i < 4; i++)
        {
            Console.Write(".");
            Thread.Sleep(400);
        }

        Console.WriteLine();
        Console.ResetColor();
    }

    /// <summary>
    /// Displays error text in red colour with typing effect.
    /// </summary>
    /// <param name="text">
    /// The error message to display.
    /// </param>
    /// <param name="delay">
    /// The typing delay in milliseconds.
    /// </param>
    public void ErrorText(string text, int delay)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        TypeText(text, delay);
        Console.ResetColor();
    }

    /// <summary>
    /// Displays the chatbot label in green colour.
    /// </summary>
    /// <param name="text">
    /// The label text to display.
    /// </param>
    public void BotLabel(string text)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(text);
        Console.ResetColor();
    }

    /// <summary>
    /// Displays the user label in yellow colour.
    /// </summary>
    /// <param name="text">
    /// The label text to display.
    /// </param>
    public void UserLabel(string text)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(text);
        Console.ResetColor();
    }
    
    /// <summary>
    /// Displays a chatbot message in green colour using the typing effect.
    /// </summary>
    /// <param name="text">
    /// The message to display.
    /// </param>
    /// <param name="delay">
    /// The typing delay in milliseconds.
    /// </param>
    public void BotMessage(string text,int delay)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        TypeText(text, delay);
        Console.ResetColor();
    }
}