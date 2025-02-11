

using RentASup;

internal class RentSupWorkflow{

    internal void Execute()
    { 
        ConsoleWrapper.WriteLine("Wie viele SUPs sollen gemietet werden?");
        ConsoleWrapper.ReadInteger();

        ConsoleWrapper.WriteLine("Bestehender Kunde? (Y/N)");
        var bestehenderKunde = ConsoleWrapper.ReadBoolean();

        if (bestehenderKunde)
        {
            ConsoleWrapper.WriteLine("Kundennummer:");
            var Kundennummer = ConsoleWrapper.ReadString();

            // kunde suchen
        }
        else
        {
            ConsoleWrapper.WriteLine("Name:");
            var KundenName = ConsoleWrapper.ReadString();
            ConsoleWrapper.WriteLine("Addresse:");
            var KundenAdresse = ConsoleWrapper.ReadString();

            var kunde = new Kunde();
        }

        ConsoleWrapper.WriteLine("Hat Kunde Sicherheitscheck aufgefüllt?");
        var Sicherheitscheck = ConsoleWrapper.ReadBoolean();

        if (Sicherheitscheck)
        {

        }
        else {
            ConsoleWrapper.WriteLine("Sicherheitscheck ausdrucken...");
        }

        ConsoleWrapper.WriteLine("Gepäck?");

        var gepaeck = ConsoleWrapper.ReadBoolean();

        ConsoleWrapper.WriteLine("Gepaeck registrieren...");

        // Buchung bestätigen

        // sup unterwegs

        // sup retournieren

    }
   
}



