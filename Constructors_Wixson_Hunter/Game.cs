using System;

public class Game
{
    // Public fields for the title and genre of the game
    public string Title;
    public string Genre;

    // Constructor with default parameter values
    public Game(string title = "Unknown Title", string genre = "Casual")
    {
        // Setting the initial values for title and genre
        Title = title;
        Genre = genre;
    }
}
