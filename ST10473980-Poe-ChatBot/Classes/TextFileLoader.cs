namespace ST10473980_Poe_ChatBot.Classes;

/// <summary>
/// Loads and displays text files in the console.
/// This class is used to read external text files such as
/// logos, banners, or ASCII art, and print them line by line.
/// </summary>
public class TextFileLoader
{
    /// <summary>
    /// Stores the file path of the text file to be loaded.
    /// </summary>
    private readonly string _filePath;
    
    /// <summary>
    /// Constructor that sets the file path of the text file.
    /// </summary>
    /// <param name="filePath">
    /// The relative or absolute path of the text file to be displayed.
    /// </param>
    public TextFileLoader(string filePath)
    {
        _filePath = filePath;
    }

    /// <summary>
    /// Reads the text file and displays each line in the console.
    /// </summary>
    public void DisplayFile()
    {
        string[] lines = File.ReadAllLines(_filePath);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}