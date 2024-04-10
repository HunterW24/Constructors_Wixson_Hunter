using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Game object and initialize it with values of a favorite game
        Game favoriteGame = new Game("The Legend of Zelda: Breath of the Wild", "Action-Adventure");

        // Print the title and genre of the favorite game
        Console.WriteLine("Favorite Game:");
        Console.WriteLine("Title: " + favoriteGame.Title);
        Console.WriteLine("Genre: " + favoriteGame.Genre);

        // Create another Game object without initializing it with values
        Game anotherGame = new Game();

        // Print the title and genre of the second game
        Console.WriteLine("\nAnother Game:");
        Console.WriteLine("Title: " + anotherGame.Title);
        Console.WriteLine("Genre: " + anotherGame.Genre);
    }
}