namespace ST10473980_Poe_ChatBot.Classes;

public class Chatbot
{
    private bool start = false;

    private void runProgram()
    {
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