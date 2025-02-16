namespace RentASup.SUPManagement;

using RentASup.Bestand;
using RentASup.Gepaeck;

internal class RentSupWorkflow(Standort standort)
{
    private Kunde kunde;
    private Vermietung vermietung;
    private Standort standort = standort;

    internal void Execute()
    {
        ConsoleWrapper.PrintTitle("SUP Vermieten");
        standort.Print();

        Console.WriteLine("");
        ConsoleWrapper.WriteLine("Bestehender Kunde? (Y/N)");
        var bestehenderKunde = ConsoleWrapper.ReadBoolean();
        if (bestehenderKunde)
        {
            var kundeAnmeldenWorkflow = new KundeAnmeldenWorkflow();
            kunde = kundeAnmeldenWorkflow.Execute();
        }
        else
        {
            var kundeRegistrierenWorkflow = new KundeRegistrierenWorkflow();
            kunde = kundeRegistrierenWorkflow.Execute();
        }
        
        vermietung = new Vermietung(kunde, standort);

        ConsoleWrapper.WriteLine("Sicherheitscheck ausdrucken...");
        var sicherheitscheck = new Sicherheitscheck(kunde.Id);
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

        ConsoleWrapper.WriteLine("");
        ConsoleWrapper.WriteLine("Anzahl 1er SUPs: ");
        var sup1 = ConsoleWrapper.ReadInteger();
        ConsoleWrapper.WriteLine("Anzahl 2er SUPs: ");
        var sup2 = ConsoleWrapper.ReadInteger();

        ConsoleWrapper.WriteLine("");
        var bestandOk = standort.BestandPruefen(sup1, sup2);
        ConsoleWrapper.WriteLine("");

        if (bestandOk)
        {
            ConsoleWrapper.WriteLine("Gepäck registrieren? (Y/N)");
            var gepaeck = ConsoleWrapper.ReadBoolean();
            if (gepaeck)
            {
                gepaeckRegistrieren();
            }

            ConsoleWrapper.WriteLine("");
            VermietungBestätigen(vermietung, sup1, sup2);
            UpdateBestand(sup1, sup2);
            
            ConsoleWrapper.WriteLine("");
            standort.Print();
        }
        else 
        {

        }
    }

    private void UpdateBestand(int sup1, int sup2)
    {
        standort.RemoveEinerSUP(sup1);
        standort.RemoveZweierSUP(sup2);
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
        vermietung.Print();
    }
}
