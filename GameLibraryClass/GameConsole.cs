namespace GameLibraryClass;

public class GameConsole(int type, DateTime release, int unitsSold, string platform)
{
    public string Platform { get; set;} = platform;
    public int Type { get; set; } = type;
    public DateTime Release { get; set; } = release;
    public int UnitsSold { get; set; } = unitsSold;

    public static string DisplayAll(List<GameConsole>? gConsoles)
    {
        var output = "";
        if (gConsoles == null) return output;
        foreach (var console in gConsoles)
        {
            output += console.ToString();
        }

        return output;
    }

    private string GetConsoleType()
    {
        return Type == 1 ? "Home Console" : "Handheld";
    }
    
    public override string ToString()
    {
        return $"{Platform} " +
               $"\n\tConsole Type {GetConsoleType()}" +
               $"\n\tRelease Date: {Release:d}" +
               $"\n\tUnits Sold: {UnitsSold:N} \n";
    }
}