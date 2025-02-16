
namespace RentASup;

using RentASup.Bestand;
using RentASup.SUPManagement;

internal static class WorkflowSelector
{
    internal static void Execute(int workflowId, Standort standort, IReadOnlyList<Kunde> kunden)
    {
        switch (workflowId)
        {
            case 0:
                var rentSupWorkflow = new RentSupWorkflow(standort);
                rentSupWorkflow.Execute();
                break;
            case 1:
                var kundeRegistrierenWorkflow = new KundeRegistrierenWorkflow();
                var registrierteKunden = kunden.ToList();
                registrierteKunden.Add(kundeRegistrierenWorkflow.Execute());
                break;
            case 2:
                var bestandPruefenWorkflow = new BestandPruefenWorkflow();
                ConsoleWrapper.PrintTitle("SUP Bestand");
                bestandPruefenWorkflow.Execute(standort);
                break;                
            case 3:
                break; 
        }   
    }
}