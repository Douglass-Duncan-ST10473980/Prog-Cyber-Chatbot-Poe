namespace ST10473980_Poe_ChatBot.Classes;

public class Chatbot
{
    private readonly VisualElements _visualElements= new VisualElements();
     
    
    private bool start = false;

    private void runProgram()
    {
        TextFileLoader loader = new TextFileLoader("Data/Txts/Logo.txt");
        loader.DisplayFile();
        
        
        Console.Write("Bot>> ");
        _visualElements.TypeText($"Hello!, Welcome to the Cybersecurity Awareness bot.\n" +
                                 $"      I am here to help you stay safe online ",50);
        
        
        while (start)
        {
            
        }
    }
    
    public void Start()
    {
        start = true;
        runProgram();
    }

    private void Stop()
    {
        start = false;
    }
}