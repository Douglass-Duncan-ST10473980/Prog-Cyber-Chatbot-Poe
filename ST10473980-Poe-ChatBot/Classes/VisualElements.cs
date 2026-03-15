namespace ST10473980_Poe_ChatBot.Classes;

public class VisualElements
{
    public void TypeText(string text, int delay)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }

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

    public void ErrorText(string text, int delay)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        TypeText(text, delay);
        Console.ResetColor();
    }

    public void BotLabel(string text)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(text);
        Console.ResetColor();
    }

    public void UserLabel(string text)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(text);
        Console.ResetColor();
    }
    
    public void BotMessage(string text,int delay)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        TypeText(text, delay);
        Console.ResetColor();
    }
}