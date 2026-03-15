namespace ST10473980_Poe_ChatBot.Classes;

/// <summary>
/// Represents a user interacting with the chatbot.
/// This class stores the user's name and surname
/// so that responses can be personalised.
/// </summary>
public class User
{
    /// <summary>
    /// Stores the user's first name.
    /// </summary>
    private string _name { get; set; }

    /// <summary>
    /// Stores the user's surname.
    /// </summary>
    private string _surname { get; set; }

    /// <summary>
    /// Constructor used to create a new user.
    /// </summary>
    /// <param name="name">
    /// The user's first name.
    /// </param>
    /// <param name="surname">
    /// The user's surname.
    /// </param>
    public User(string name, string surname)
    {
        _name = name;
        _surname = surname;
    }

    /// <summary>
    /// Returns the user's first name.
    /// </summary>
    /// <returns>
    /// The stored first name.
    /// </returns>
    public string GetName()
    {
        return _name;
    }

    /// <summary>
    /// Returns the user's surname.
    /// </summary>
    /// <returns>
    /// The stored surname.
    /// </returns>
    public string GetSurname()
    {
        return _surname;
    }
}