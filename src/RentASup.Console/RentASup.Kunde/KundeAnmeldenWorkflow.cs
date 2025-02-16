namespace RentASup;

internal class KundeAnmeldenWorkflow
{
    internal Kunde Execute()
    {
        Kunde kunde;
        
        ConsoleWrapper.WriteLine("Kunden Id:");
        var id = ConsoleWrapper.ReadInteger();
        kunde = SucheKunde(id);
        ConsoleWrapper.WriteLine("");
        kunde.print();
        return kunde;
    }

    private Kunde SucheKunde(int id)
    {
        return new Kunde(id, "Max Muster", "Musterstrasse 1", 1111, "Musterhausen");
    }
}