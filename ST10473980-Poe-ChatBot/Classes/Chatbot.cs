namespace ST10473980_Poe_ChatBot.Classes;

public class Chatbot
{
    private readonly VisualElements _visualElements= new VisualElements();
    private ResponseSystem ResponseSystem { get; set; } = null!;
    private User User { get; set; } = null!;


    private bool _start { get; set; }

    private void RunProgram()
    {
        TextFileLoader loader = new TextFileLoader("Data/Txts/Logo.txt");
        loader.DisplayFile();
        Console.WriteLine();
        
        Console.WriteLine("+----------------------------------------+");
        Console.WriteLine("|                WELCOME                 |");
        Console.WriteLine("+----------------------------------------+");
        
        Console.Write($"\nBOT>>");
        _visualElements.TypeText($" Please enter your name and surname: ",50);
        Console.Write("Name: ");
        string? name = Console.ReadLine();
        Console.Write("Surname: ");
        string? surname = Console.ReadLine();
       

        while (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
        {
            
            Console.Write($"BOT>>");
            _visualElements.TypeText($" Name and surname cannot be empty.",50);

            Console.Write($"Name: ");
            name = Console.ReadLine();

            Console.Write($"Surname: ");
            surname = Console.ReadLine();
        }
        
        User= new User(name, surname);
        ResponseSystem = new ResponseSystem(User);
        
        Console.WriteLine($"-------------------------------------------\n");
        
        Console.Write("BOT>> ");
        _visualElements.TypeText($"Welcome {User.GetName()} {User.GetSurname()}.\n" +
                                 $"      How can I assist you today?\n",20);

        while (_start)
        {
           Console.Write($"{User.GetName()}>> ");
           string? input = Console.ReadLine().ToLower();
           Console.WriteLine();
           
           Console.Write($"BOT>> ");
           if (input != null) _visualElements.TypeText(ResponseSystem.GetResponse(input), 20);
           Console.WriteLine();

           if (input != null && (input.Contains("good bye") || input.Contains("exit")))
           {
               Stop();
           }
           
        }
    }
    
    public void Start()
    {
        _start = true;
        RunProgram();
    }

    private void Stop()
    {
        _start = false;
        _visualElements.Stop();
        Console.WriteLine($"-------------------------------------------\n");
    }
}