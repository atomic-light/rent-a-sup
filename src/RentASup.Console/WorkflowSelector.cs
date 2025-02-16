
namespace RentASup;

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
        }   
    }
}