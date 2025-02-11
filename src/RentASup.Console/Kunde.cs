namespace RentASup;

internal class Kunde
{
    internal string Name { get; set; }
    internal string Adresse { get; set; }
    internal int Kundennummer { get; set; }
    internal bool Bestandskunde { get; set; }

    internal Buchung Buchen(SUP sup)
    {
        return new Buchung { Kundeninfo = this, Sup = sup, Datum = DateTime.Now, Status = "Gebucht" };
    }

    internal void BestaetigeSicherheitscheck()
    {
        Console.WriteLine("Sicherheitscheck bestätigt.");
    }
}
