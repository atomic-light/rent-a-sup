namespace RentASup;

internal static class ConsoleWrapper
{
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
}

