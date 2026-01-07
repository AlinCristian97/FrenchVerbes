using FrenchVerbes.Extensions;

namespace FrenchVerbes;

public static class PrintUtils
{
    public static void PrintSectionDivider(bool newLine = true)
    {
        if (newLine)
        {
            Console.WriteLine(Constants.SectionDivider);
            return;
        }
        Console.Write(Constants.SectionDivider);
    }
    
    public static void PrintHeadline(string headline)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(headline.ToHeadline());
        Console.ResetColor();
    }
}