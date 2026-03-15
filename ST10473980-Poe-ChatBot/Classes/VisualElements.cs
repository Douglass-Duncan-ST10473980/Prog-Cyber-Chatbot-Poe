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
        Console.Write("Cyber Chat Bot is shutting down");

        for (int i = 0; i < 4; i++)
        {
            Console.Write(".");
            Thread.Sleep(400);
        }
        Console.WriteLine();
    }
    
    public void Start()
    {
        Console.Write("Cyber Chat Bot is starting up");

        for (int i = 0; i < 4; i++)
        {
            Console.Write(".");
            Thread.Sleep(400);
        }
        Console.WriteLine();
    }

    public void ErrorText(string text, int delay)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        TypeText(text, delay);
        Console.ResetColor();
    }
}