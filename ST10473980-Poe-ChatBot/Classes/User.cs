namespace ST10473980_Poe_ChatBot.Classes;

public class User
{
    private string _name { get; set; }
    private string _surname { get; set; }

    public User(string name, string surname)
    {
        _name = name;
        _surname = surname;
    }
}