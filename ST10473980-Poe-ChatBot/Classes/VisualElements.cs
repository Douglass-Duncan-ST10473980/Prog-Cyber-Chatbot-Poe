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
}