namespace ST10473980_Poe_ChatBot.Classes;

public class TextFileLoader
{
    private readonly string _filePath;
    
    public TextFileLoader(string filePath)
    {
        _filePath = filePath;
    }

    public void DisplayFile()
    {
        string[] lines = File.ReadAllLines(_filePath);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}