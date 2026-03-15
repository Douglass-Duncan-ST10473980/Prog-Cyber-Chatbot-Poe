namespace ST10473980_Poe_ChatBot.Classes;

/// <summary>
/// Controls the main execution flow of the chatbot application.
/// This class is responsible for starting the program, collecting user input,
/// displaying visual elements, and managing the conversation loop.
/// </summary>
public class Chatbot(int textDelay)
{
    /// <summary>
    /// Handles all console visual formatting such as labels, colours, and animations.
    /// </summary>
    private readonly VisualElements _visualElements= new VisualElements();

    /// <summary>
    /// Handles the response logic of the chatbot.
    /// </summary>
    private ResponseSystem ResponseSystem { get; set; } = null!;

    /// <summary>
    /// Stores the current user interacting with the chatbot.
    /// </summary>
    private User User { get; set; } = null!;

    /// <summary>
    /// Plays the voice introduction sound when the program starts.
    /// </summary>
    private VoiceIntro voiceintro=new VoiceIntro();

    /// <summary>
    /// Determines whether the chatbot conversation loop should continue running.
    /// </summary>
    private bool StartFlag { get; set; }

    /// <summary>
    /// Runs the main program logic including startup animation,
    /// logo display, user input, and chatbot conversation loop.
    /// </summary>
    private void RunProgram()
    {
        //start animation
        _visualElements.Start();

        //play voice introduction
        voiceintro.PlaySound();
        
        //display logo from text file
        Console.ForegroundColor = ConsoleColor.Cyan;
        TextFileLoader loader = new TextFileLoader("Data/Txts/Logo.txt");
        loader.DisplayFile();
        Console.WriteLine();
        Console.ResetColor();
        
        //welcome label
        Console.WriteLine("+----------------------------------------+");
        Console.WriteLine("|                WELCOME                 |");
        Console.WriteLine("+----------------------------------------+");
        
        
        //request user details
        _visualElements.BotLabel($"\nBOT>>");
        _visualElements.BotMessage($" Please enter your name and surname: ",textDelay);
        _visualElements.UserLabel($"Name: ");
        string? name = Console.ReadLine();
        _visualElements.UserLabel($"Surname: ");
        string? surname = Console.ReadLine();
        
        
        //validate user input to ensure name and surname are entered
        while (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
        {
            Console.Write($"BOT>>");
            _visualElements.ErrorText($" Name and surname cannot be empty.",textDelay);

            Console.Write($"Name: ");
            name = Console.ReadLine();

            Console.Write($"Surname: ");
            surname = Console.ReadLine();
        }
        
        //create user object and response system
        User= new User(name, surname);
        ResponseSystem = new ResponseSystem(User);
        
        Console.WriteLine($"-------------------------------------------\n");
        
        //welcome message
        _visualElements.BotLabel($"BOT>> ");
        _visualElements.BotMessage($"Welcome {User.GetName()} {User.GetSurname()}.\n" +
                                 $"      How can I assist you today?\n",textDelay);

        //main chatbot loop
        while (StartFlag)
        {
           _visualElements.UserLabel($"{User.GetName()}>> ");
           string? input = Console.ReadLine()?.ToLower();
           Console.WriteLine();
           
           _visualElements.BotLabel($"BOT>> ");
           
           if (input != null)
           {
               //get response from response system
               _visualElements.BotMessage(ResponseSystem.GetResponse(input), textDelay);
               Console.WriteLine();

               //exit condition
               if ((input.Contains("good bye") || input.Contains("exit")))
               {
                   Stop();
               }
           }
        }
    }
    
    /// <summary>
    /// Starts the chatbot program.
    /// Sets the start flag to true and runs the main program.
    /// </summary>
    public void Start()
    {
        StartFlag = true;
        RunProgram();
    }

    /// <summary>
    /// Stops the chatbot program and ends the conversation loop.
    /// Also stops any running visual animations.
    /// </summary>
    private void Stop()
    {
        StartFlag = false;
        _visualElements.Stop();
        Console.WriteLine($"-------------------------------------------\n");
    }
}