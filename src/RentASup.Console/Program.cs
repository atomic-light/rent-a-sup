using System.ComponentModel;
using RentASup;

bool running = true;

var standortBeckenried = new Standort { Name = "Beckenried" };
var standortLuzern = new Standort { Name = "Luzern" };

var kunden = new List<Kunde>();

string[] menuItems = { "SUP Vermietung", "Kunde registrieren", "SUP-Bestand prüfen", "Beenden" };
int selectedIndex = 0;

while (running)
{
    ConsoleWrapper.Clear();
    ConsoleWrapper.PrintHeader();

    for (int i = 0; i < menuItems.Length; i++)
    {
        if (i == selectedIndex)
        {
            ConsoleWrapper.SetForegroundColor(ConsoleColor.Yellow);
            ConsoleWrapper.WriteLine($"> {menuItems[i]} <");
            ConsoleWrapper.ResetColor();
        }
        else
        {
            ConsoleWrapper.WriteLine($"  {menuItems[i]}");
        }
    }

    ConsoleKeyInfo key = ConsoleWrapper.ReadKey();
    switch (key.Key)
    {
        case ConsoleKey.UpArrow:
            selectedIndex = (selectedIndex == 0) ? menuItems.Length - 1 : selectedIndex - 1;
            break;
        case ConsoleKey.DownArrow:
            selectedIndex = (selectedIndex == menuItems.Length - 1) ? 0 : selectedIndex + 1;
            break;
        case ConsoleKey.Enter:
            if (selectedIndex == menuItems.Length - 1) running = false;

            WorkflowSelector.Execute(selectedIndex, standortBeckenried, kunden);

            ConsoleWrapper.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren...");
            ConsoleWrapper.ReadKey();
            break;
    }
}
