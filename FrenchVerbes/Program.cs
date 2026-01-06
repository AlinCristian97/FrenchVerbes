using FrenchVerbes.Verbes;

namespace FrenchVerbes;

internal class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("Choose a verb to summarize:");
            Console.WriteLine("1. Specific Verb");
            Console.WriteLine("2. Random Verb");
            Console.WriteLine("Q. Quit");
            Console.Write("Your choice: ");

            var choice = Console.ReadLine()?.Trim().ToLowerInvariant();

            Console.WriteLine();

            if (choice == "q")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            switch (choice)
            {
                case "1":
                    HandleSpecificVerb();
                    break;

                case "2":
                    HandleRandomVerb();
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.WriteLine("\nPress any key to start over...");
            Console.ReadKey();
        }
    }

    private static void HandleSpecificVerb()
    {
        Console.Write("Type a verb (or Q to cancel): ");
        var input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Verb cannot be empty.");
            return;
        }

        if (input.Trim().Equals("q", StringComparison.OrdinalIgnoreCase))
        {
            return;
        }

        var verb = VerbRepository.GetByInfinitive(input);

        if (verb is null)
        {
            Console.WriteLine("This verb is not implemented yet.");
            return;
        }

        Console.WriteLine();
        verb.PrintSummary();
    }

    private static void HandleRandomVerb()
    {
        var verb = VerbRepository.GetRandom();
        verb.PrintSummary();
    }
}