using System.Reflection.Metadata;

namespace RentASup;

internal class Sicherheitscheck
{
    internal int Kundennummer { get;set; }
    internal DateTime Datum { get; set; }
    internal bool Bestaetigt { get; set; }
    internal Blob PDF { get; set; }

    public Sicherheitscheck(int kundennummer)
    {
        Kundennummer = kundennummer;
        Datum = DateTime.Now;
    }

    internal void Bestaetigen(Kunde kunde)
    {
        Bestaetigt = true;
    }
    internal void UploadPDF(Kunde kunde)
    {
        ConsoleWrapper.WriteLine("Upload PDf...");
    }
}