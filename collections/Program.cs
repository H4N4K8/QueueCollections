using System;
using System.Collections.Generic;

namespace QueueCollections
{
    internal class QueueCollection
    {
        static void Main(string[] args)
        {
            Queue<string> games = new Queue<string>();

            games.Enqueue("Overwatch");
            games.Enqueue("Genshin Impact");
            games.Enqueue("Honkai: Star Rail");
            games.Enqueue("Minecraft");
            games.Enqueue("Stardew Valley");

            if (games.Contains("Honkai: Star Rail"))
            {
                Console.WriteLine("Honkai: Star Rail is my favorite game!");
            }

            Console.WriteLine($"There are {games.Count()} games. Here are your current games.");

            foreach (var m in games)
            {
                Console.WriteLine(m);
            }

            Console.WriteLine("I think you finished this game, can we remove it?");
            string firstMem = games.Peek();
            Console.WriteLine($"Would you like to remove {firstMem} from your games list? Y or N.");
            string removeanwser = Console.ReadLine();
            if (removeanwser == "Y" || removeanwser == "y")
            {
                games.Dequeue();
                Console.WriteLine("game sucessfully removed!");
            }
            Console.WriteLine("Here is your new game list:");
            foreach (var m in games)
            {
                Console.WriteLine(m);
            }
        }
    }
}
