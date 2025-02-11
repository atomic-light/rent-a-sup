namespace RentASup;
internal class SUP
{
    internal int SupId { get; set; }
    internal SUPTyp Typ { get; set; }
    internal string Status { get; set; }
    internal Standort Standort { get; set; }

    internal void Vermieten(Kunde kunde)
    {
        Console.WriteLine($"SUP {SupId} wurde an Kunde {kunde.Name} vermietet.");
    }

    internal bool Pruefen()
    {
        return Status == "Betriebsbereit";
    }

    internal void Reparieren()
    {
        Status = "Betriebsbereit";
    }
}