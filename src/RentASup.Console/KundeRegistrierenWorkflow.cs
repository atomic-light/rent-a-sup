namespace RentASup;

internal class KundeRegistrierenWorkflow
{
    internal Kunde Execute()
    {
        ConsoleWrapper.WriteLine("Bestehender Kunde? (Y/N)");
        var bestehenderKunde = ConsoleWrapper.ReadBoolean();

        Kunde kunde;
        if (bestehenderKunde)
        {
            ConsoleWrapper.WriteLine("Kundennummer:");
            var Kundennummer = ConsoleWrapper.ReadInteger();
            kunde = SucheKunde(Kundennummer);
        }
        else
        {
            kunde = KundeRegistrieren();
        }

        kunde.print();
        return kunde;
    }

    private Kunde SucheKunde(int kundennummer)
    {
        return new Kunde(kundennummer, "Max Muster", "Musterstrasse 1", 1111, "Musterhausen");
    }

    private Kunde KundeRegistrieren()
    {
        ConsoleWrapper.WriteLine("Name:");
        var kundenName = ConsoleWrapper.ReadString();
        ConsoleWrapper.WriteLine("Addresse:");
        var kundenAdresse = ConsoleWrapper.ReadString();
        ConsoleWrapper.WriteLine("PLZ:");
        var plz = ConsoleWrapper.ReadInteger();
        ConsoleWrapper.WriteLine("Ort:");
        var ort = ConsoleWrapper.ReadString();

        return new Kunde(1000, kundenName, kundenAdresse, plz, ort);
    }

}