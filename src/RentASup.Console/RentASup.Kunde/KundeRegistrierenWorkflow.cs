namespace RentASup;

internal class KundeRegistrierenWorkflow
{
    internal Kunde Execute()
    {
        Kunde kunde;        
        kunde = KundeRegistrieren();
        ConsoleWrapper.WriteLine($"Kunde erfolgreich erfasst.");
        ConsoleWrapper.WriteLine("");
        kunde.print();
        return kunde;
    }


    private Kunde KundeRegistrieren()
    {        
        ConsoleWrapper.PrintTitle("Kundendaten erfassen");
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