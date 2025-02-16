
namespace RentASup;

internal class RentSupWorkflow(Standort standort)
{
    private Kunde kunde;
    private Vermietung vermietung;
    private Standort standort = standort;

    internal void Execute()
    {
        standort.Print();

        var kundeRegistrieren = new KundeRegistrierenWorkflow();
        kunde = kundeRegistrieren.Execute();
        
        vermietung = new Vermietung(kunde);

        ConsoleWrapper.WriteLine("Sicherheitscheck ausdrucken...");
        var sicherheitscheck = new Sicherheitscheck(kunde.Kundennummer);
        ConsoleWrapper.WriteLine("Sicherheitscheck bestätigt? (Y/N)");
        var sicherheitscheckBestaetigt = ConsoleWrapper.ReadBoolean();

        if (sicherheitscheckBestaetigt)
        {
            sicherheitscheck.Bestaetigen(kunde);
        }
        else {
            ConsoleWrapper.WriteLine("Vermietung storniert.");
            return;
        }

        ConsoleWrapper.WriteLine("Anzahl 1er SUPs: ");
        var sup1 = ConsoleWrapper.ReadInteger();
        ConsoleWrapper.WriteLine("Anzahl 2er SUPs: ");
        var sup2 = ConsoleWrapper.ReadInteger();

        var bestandOk = standort.BestandPruefen(sup1, sup2);

        if (bestandOk)
        {
            ConsoleWrapper.WriteLine("Gepäck registrieren? (Y/N)");
            var gepaeck = ConsoleWrapper.ReadBoolean();
            if (gepaeck)
            {
                gepaeckRegistrieren();
            }

            VermietungBestätigen(vermietung, sup1, sup2);
        }
        else 
        {

        }
    }

    private void gepaeckRegistrieren()
    {
        var gepaeck = new Gepaeck(1111, kunde, standort);
        gepaeck.Registrieren();
        vermietung.AddGepaeck(gepaeck);
    }

    private void VermietungBestätigen(Vermietung vermietung, int sup1, int sup2)
    {
        vermietung.Bestaetigen(sup1, sup2);
    }
}
