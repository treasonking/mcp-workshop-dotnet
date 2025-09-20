using System;
using MyMonkeyApp.Models;

namespace MyMonkeyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] asciiArts = new string[]
            {
                @"  (\__/)
  (•ㅅ•)
  / 　 づ",
                @"  (o.o)
  (   )
  (\")_(\")",
                @"  (""`-''-/\").___..--''\"\"`-._
   `6_ 6  )   `-.  (     ).`-.__.`)
   (_Y_.)'  ._   )  `._ `. ``-..-'
 _..`--'_..-_/  /--'_.' ,'
(il),-''  (li),'  ((!.-'",
                @"  (\\(\\
  (-.-)
  o_(\")(\")",
                @"  (\\_/)
  ( •_•)
  / >🍌",
            };
            var rand = new Random();
            Console.WriteLine(asciiArts[rand.Next(asciiArts.Length)]);
            Console.WriteLine("Welcome to the Monkey Console App!\n");

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. List all monkeys");
                Console.WriteLine("2. Get details for a specific monkey by name");
                Console.WriteLine("3. Get a random monkey");
                Console.WriteLine("4. Exit app");
                Console.Write("Select an option: ");
                var input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        foreach (var monkey in MonkeyHelper.GetAllMonkeys())
                        {
                            Console.WriteLine($"- {monkey.Name} ({monkey.Location})");
                        }
                        break;
                    case "2":
                        Console.Write("Enter monkey name: ");
                        var name = Console.ReadLine();
                        var found = MonkeyHelper.FindMonkeyByName(name);
                        if (found != null)
                        {
                            Console.WriteLine($"Name: {found.Name}\nLocation: {found.Location}\nDetails: {found.Details}\nPopulation: {found.Population}\nCoords: ({found.Latitude}, {found.Longitude})");
                            if (!string.IsNullOrWhiteSpace(found.AsciiArt))
                                Console.WriteLine($"\n{found.AsciiArt}");
                        }
                        else
                        {
                            Console.WriteLine("Monkey not found.");
                        }
                        break;
                    case "3":
                        var randomMonkey = MonkeyHelper.GetRandomMonkey();
                        Console.WriteLine($"Random Monkey: {randomMonkey.Name}\nLocation: {randomMonkey.Location}\nDetails: {randomMonkey.Details}\nPopulation: {randomMonkey.Population}\nCoords: ({randomMonkey.Latitude}, {randomMonkey.Longitude})");
                        if (!string.IsNullOrWhiteSpace(randomMonkey.AsciiArt))
                            Console.WriteLine($"\n{randomMonkey.AsciiArt}");
                        Console.WriteLine("\nRandom pick count: " + MonkeyHelper.GetRandomPickCount());
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
                // 랜덤하게 재미있는 ASCII 아트 출력
                if (rand.NextDouble() < 0.3)
                {
                    Console.WriteLine("\n--- Funny ASCII Art ---");
                    Console.WriteLine(asciiArts[rand.Next(asciiArts.Length)]);
                }
                Console.WriteLine();
            }
        }
    }
}