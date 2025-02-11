namespace RentASup;

internal class Standort
{
    internal string Name { get; set; }
    internal string Adresse { get; set; }
    internal int Kapazitaet { get; set; }
    internal List<SUP> SUPs { get; set; }

    public Standort()
    {
        initialData();
    }

    internal List<SUP> GetSUPs()
    {
        return SUPs;
    }

    internal void initialData()
    {
        this.SUPs = new List<SUP>
        {
            new SUP { SupId = 1, Typ = SUPTyp.EINER_SUP, Status = "Betriebsbereit", Standort = new Standort { Name = "Hamburg" } },
            new SUP { SupId = 2, Typ = SUPTyp.EINER_SUP, Status = "Defekt", Standort = new Standort { Name = "Berlin" } },
            new SUP { SupId = 3, Typ = SUPTyp.EINER_SUP, Status = "Betriebsbereit", Standort = new Standort { Name = "München" } },
            new SUP { SupId = 4, Typ = SUPTyp.EINER_SUP, Status = "Betriebsbereit", Standort = new Standort { Name = "Köln" } },
            new SUP { SupId = 5, Typ = SUPTyp.EINER_SUP, Status = "Defekt", Standort = new Standort { Name = "Stuttgart" } },
            new SUP { SupId = 6, Typ = SUPTyp.EINER_SUP, Status = "Betriebsbereit", Standort = new Standort { Name = "Düsseldorf" } },
            new SUP { SupId = 7, Typ = SUPTyp.EINER_SUP, Status = "Betriebsbereit", Standort = new Standort { Name = "Leipzig" } },
            new SUP { SupId = 8, Typ = SUPTyp.EINER_SUP, Status = "Defekt", Standort = new Standort { Name = "Dortmund" } },
            new SUP { SupId = 9, Typ = SUPTyp.EINER_SUP, Status = "Betriebsbereit", Standort = new Standort { Name = "Essen" } },
            new SUP { SupId = 10, Typ = SUPTyp.EINER_SUP, Status = "Betriebsbereit", Standort = new Standort { Name = "Bremen" } },
            new SUP { SupId = 11, Typ = SUPTyp.EINER_SUP, Status = "Defekt", Standort = new Standort { Name = "Dresden" } },
            new SUP { SupId = 12, Typ = SUPTyp.EINER_SUP, Status = "Betriebsbereit", Standort = new Standort { Name = "Hannover" } },
            new SUP { SupId = 13, Typ = SUPTyp.EINER_SUP, Status = "Betriebsbereit", Standort = new Standort { Name = "Nürnberg" } },
            new SUP { SupId = 14, Typ = SUPTyp.EINER_SUP, Status = "Defekt", Standort = new Standort { Name = "Duisburg" } },
            new SUP { SupId = 15, Typ = SUPTyp.ZWEIER_SUP, Status = "Betriebsbereit", Standort = new Standort { Name = "Bochum" } },
            new SUP { SupId = 16, Typ = SUPTyp.ZWEIER_SUP, Status = "Betriebsbereit", Standort = new Standort { Name = "Wuppertal" } },
            new SUP { SupId = 17, Typ = SUPTyp.ZWEIER_SUP, Status = "Defekt", Standort = new Standort { Name = "Bielefeld" } },
            new SUP { SupId = 18, Typ = SUPTyp.ZWEIER_SUP, Status = "Betriebsbereit", Standort = new Standort { Name = "Bonn" } },
            new SUP { SupId = 19, Typ = SUPTyp.ZWEIER_SUP, Status = "Defekt", Standort = new Standort { Name = "Mannheim" } },
            new SUP { SupId = 20, Typ = SUPTyp.ZWEIER_SUP, Status = "Betriebsbereit", Standort = new Standort { Name = "Karlsruhe" } }
        };
    }
}