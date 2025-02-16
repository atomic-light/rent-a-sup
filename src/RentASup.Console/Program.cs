using RentASup;

bool running = true;
while (running)
{
    ConsoleWrapper.WriteLine("Rent-a-SUP");
    ConsoleWrapper.WriteLine("1. SUP-Verleih anfragen");
    ConsoleWrapper.WriteLine("2. Kunde registrieren");
    ConsoleWrapper.WriteLine("3. SUP Bestand prüfen");
    ConsoleWrapper.WriteLine("4. Beenden");
    Console.Write("Bitte wählen Sie eine Option: ");

    var standortBeckenried = new Standort { Name = "Beckenried" };
    var standortLuzern = new Standort { Name = "Luzern" };

    int choice = ConsoleWrapper.ReadInteger();
    
    switch (choice)
    {
        case 1:
            var rentSupWorkflow = new RentSupWorkflow(standortBeckenried);
            rentSupWorkflow.Execute();
            break;
        case 2:
            var kundeRegistrierenWorkflow = new KundeRegistrierenWorkflow();
            kundeRegistrierenWorkflow.Execute();
            break;
        case 3:
        
            break;
        case 4:
            running = false;
            break;
        default:
            Console.WriteLine("Ungültige Auswahl. Bitte erneut versuchen.");
            break;
    }
    
    if (running)
    {
        ConsoleWrapper.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren...");
        ConsoleWrapper.ReadString();
    }
}
