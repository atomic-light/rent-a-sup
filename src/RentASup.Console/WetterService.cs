namespace RentASup;

internal class WetterService
{
    internal string GetPrognose()
    {
        return "Sonnig";
    }

    internal bool IstVerleihMoeglich()
    {
        return GetPrognose() != "Sturm";
    }
}