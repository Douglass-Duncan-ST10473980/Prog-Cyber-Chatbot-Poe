namespace ST10473980_Poe_ChatBot.Classes;

public class Chatbot(int textDelay)
{
    private readonly VisualElements _visualElements= new VisualElements();
    private ResponseSystem ResponseSystem { get; set; } = null!;
    private User User { get; set; } = null!;


    private bool StartFlag { get; set; }

    private void RunProgram()
    {
        //start animation
        _visualElements.Start();
        
        //display logo
        Console.ForegroundColor = ConsoleColor.Cyan;
        TextFileLoader loader = new TextFileLoader("Data/Txts/Logo.txt");
        loader.DisplayFile();
        Console.WriteLine();
        Console.ResetColor();
        
        //welcome label
        Console.WriteLine("+----------------------------------------+");
        Console.WriteLine("|                WELCOME                 |");
        Console.WriteLine("+----------------------------------------+");
        
        
        //sets user
        _visualElements.BotLabel($"\nBOT>>");
        _visualElements.BotMessage($" Please enter your name and surname: ",textDelay);
        _visualElements.UserLabel($"Name: ");
        string? name = Console.ReadLine();
        _visualElements.UserLabel($"Surname: ");
        string? surname = Console.ReadLine();
        
        
       
        //if user is empty re sets ueser
        while (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
        {
            
            Console.Write($"BOT>>");
            _visualElements.ErrorText($" Name and surname cannot be empty.",textDelay);

            Console.Write($"Name: ");
            name = Console.ReadLine();

            Console.Write($"Surname: ");
            surname = Console.ReadLine();
        }
        
        User= new User(name, surname);
        ResponseSystem = new ResponseSystem(User);
        
        Console.WriteLine($"-------------------------------------------\n");
        
        //welcomes user
        _visualElements.BotLabel($"BOT>> ");
        _visualElements.BotMessage($"Welcome {User.GetName()} {User.GetSurname()}.\n" +
                                 $"      How can I assist you today?\n",textDelay);

        //starts chat bot logic
        while (StartFlag)
        {
           _visualElements.UserLabel($"{User.GetName()}>> ");
           string? input = Console.ReadLine()?.ToLower();
           Console.WriteLine();
           
           _visualElements.BotLabel($"BOT>> ");
           
           if (input != null)
           {
               _visualElements.BotMessage(ResponseSystem.GetResponse(input), textDelay);
               Console.WriteLine();

               if ((input.Contains("good bye") || input.Contains("exit")))
               {
                   Stop();
               }
           }
        }
    }
    
    public void Start()
    {
        StartFlag = true;
        RunProgram();
    }

    private void Stop()
    {
        StartFlag = false;
        _visualElements.Stop();
        Console.WriteLine($"-------------------------------------------\n");
    }
}