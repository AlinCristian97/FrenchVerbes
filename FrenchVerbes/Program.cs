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
            Console.WriteLine("2. Random Regular ER Verb");
            Console.WriteLine("3. Random Regular IR Verb");
            Console.WriteLine("4. Random Regular RE Verb");
            Console.WriteLine("5. Random Regular Verb");
            Console.WriteLine("6. Random Irregular Verb");
            Console.WriteLine("7. Random Verb");
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
                    HandleRandomVerb(Constants.VerbTypes.RegularTypes.Er);
                    break;

                case "3":
                    HandleRandomVerb(Constants.VerbTypes.RegularTypes.Ir);
                    break;

                case "4":
                    HandleRandomVerb(Constants.VerbTypes.RegularTypes.Re);
                    break;

                case "5":
                    HandleRandomVerb(Constants.VerbTypes.Regular);
                    break;

                case "6":
                    HandleRandomVerb(Constants.VerbTypes.Irregular);
                    break;

                case "7":
                    HandleRandomVerb(null); // no filter
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

    private static void HandleRandomVerb(string? type)
    {
        Verb verb = type switch
        {
            Constants.VerbTypes.RegularTypes.Er => VerbRepository.GetRandomRegularByGroup(Constants.VerbTypes.RegularTypes.Er),
            Constants.VerbTypes.RegularTypes.Ir => VerbRepository.GetRandomRegularByGroup(Constants.VerbTypes.RegularTypes.Ir),
            Constants.VerbTypes.RegularTypes.Re => VerbRepository.GetRandomRegularByGroup(Constants.VerbTypes.RegularTypes.Re),
            Constants.VerbTypes.Regular => VerbRepository.GetRandomRegular(),
            Constants.VerbTypes.Irregular => VerbRepository.GetRandomIrregular(),
            _ => VerbRepository.GetRandom()
        };

        verb.PrintSummary();
    }
}
