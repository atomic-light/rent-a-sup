
using Figgle;

namespace RentASup;

internal static class ConsoleWrapper
{
    internal static void PrintHeader()
    {
        WriteLine(FiggleFonts.Standard.Render("Rent-a-SUP"));
    }

    internal static void PrintTitle(string title)
    {
        Console.Clear();
        Console.WriteLine(FiggleFonts.Standard.Render($"{title}"));
    }

    internal static ConsoleKeyInfo ReadKey()
    {
        return Console.ReadKey();
    }
    
    internal static void Clear()
    {
        Console.Clear();
    }

    internal static int ReadInteger()
    {
        var countSUPs = Console.ReadLine();

        if (int.TryParse(countSUPs, out int number))
        {
            return number;
        }
        else
        {
            return 0;
        }
    }

    internal static void WriteLine(string text)
    {        
        Console.WriteLine(text);
    }
    
    internal static bool ReadBoolean()
    {    
        while (true)
        {
            string input = Console.ReadLine()?.Trim().ToUpper();

            if (input == "Y") return true;
            if (input == "J") return true;
            if (input == "N") return false;

            Console.WriteLine("Ungültige Eingabe! Bitte nur 'Y' oder 'N' eingeben.");
        }
    }

    internal static string ReadString()
    {
        return Console.ReadLine();
    }

    internal static void SetForegroundColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }

    internal static void ResetColor()
    {
        Console.ResetColor();
    }
}

