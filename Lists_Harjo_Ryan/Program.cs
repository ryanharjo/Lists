namespace Lists_Harjo_Ryan
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            // Create a string list called games and initialize it with some game titles
            List<string> games = new List<string> { "Minecraft", "Fortnite", "The Witcher 3", "Overwatch", "Stardew Valley" };

            // Create an array of strings called otherGames and initialize it with a couple more game titles
            string[] otherGames = { "Halo", "Cyberpunk 2077" };

            // Use a foreach loop to print each game in the games list
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // Print to console the number of items in the list
            Console.WriteLine($"Number of games: {games.Count}");

            // Add a range to the list using the array you made
            games.AddRange(otherGames);

            // Print to console the number of items in the list
            Console.WriteLine($"Number of games after adding more: {games.Count}");

            // If the list contains "Halo", then print to console, "MASTER CHIEF is in the house!".
            // Else, add "Halo" to the games list.
            if (games.Contains("Halo"))
            {
                Console.WriteLine("MASTER CHIEF is in the house!");
            }
            else
            {
                games.Add("Halo");
            }

            // Create an int and assign it the value of 6
            int index = 6;

            // If the int value is less than the number of games in the games list, then remove the game at index 6
            // Else, print out, "Game not found!".
            if (index < games.Count)
            {
                games.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Game not found!");
            }

            // Print to console, "All games in the list:"
            Console.WriteLine("All games in the list:");

            // Loop through the games list and print each game to console again
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // Sort the games list
            games.Sort();

            // Print to console, "Sorted Games List:"
            Console.WriteLine("Sorted Games List:");

            // Print each game to console again
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // Create a string array called newList and initialize it to the same size as the games list
            string[] newList = new string[games.Count];

            // Copy the games list to the string array newList
            games.CopyTo(newList);

            // Clear the games list
            games.Clear();

            // Print each of the strings in the new list
            Console.WriteLine("Contents of newList:");
            foreach (string game in newList)
            {
                Console.WriteLine(game);
            }
        }
    }

}
