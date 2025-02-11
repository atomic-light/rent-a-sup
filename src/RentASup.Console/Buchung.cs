namespace RentASup;

internal class Buchung
{
    internal int Buchungsnummer { get; set; }
    internal DateTime Datum { get; set; }
    internal string Status { get; set; }
    internal Kunde Kundeninfo { get; set; }
    internal SUP Sup { get; set; }
    internal Gepaeck Gepaeck { get; set; }
}

