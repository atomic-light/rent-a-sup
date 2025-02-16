namespace RentASup;
internal class SUP
{
    internal int SupId { get; set; }
    internal SUPTyp Typ { get; set; }
    internal bool Defekt {get; set; }
    internal bool Vermietet {get; set; }

    internal void Vermieten(Kunde kunde)
    {
        Console.WriteLine($"SUP {SupId} wurde an Kunde {kunde.Name} vermietet.");
    }
}