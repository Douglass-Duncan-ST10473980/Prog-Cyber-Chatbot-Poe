namespace ST10473980_Poe_ChatBot.Classes;

public class Chatbot
{
    private readonly VisualElements _visualElements= new VisualElements();
    private User _user;
     
    
    private bool start = false;

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
        
        _user= new User(name, surname);
        
        Console.WriteLine($"-------------------------------------------\n");
        
        Console.Write("BOT>> ");
        _visualElements.TypeText($"Welcome {_user.GetName()} {_user.GetSurname()}.\n" +
                                 $"      How can I assist you today",20);

        while (start)
        {
            
        }
    }
    
    public void Start()
    {
        start = true;
        RunProgram();
    }

    private void Stop()
    {
        start = false;
    }
}