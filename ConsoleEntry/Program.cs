using System.Text.Json;
using GameLibraryClass;
using static System.Console;


List<GameConsole>? gameConsoles = [];
const string jsonFilePath = "consoles.json";
gameConsoles = ReadFileOnBoot();
WriteLine("The data from file");
WriteLine(jsonFilePath + "\n" +  GameConsole.DisplayAll(gameConsoles));
WriteLine("Adding Steam Deck");

gameConsoles?.Add(
    new GameConsole(
        2,
        Convert.ToDateTime("2022-2-25T00:00:00"),
        1_234_034,
        "Steam Deck")
);
SaveData(jsonFilePath, gameConsoles);
return;

void SaveData(string fileName, List<GameConsole>? gc)
{
    try
    {
        var jsonString = JsonSerializer.Serialize(gc);

        File.WriteAllText(jsonFilePath, jsonString);
        WriteLine("Data saved successfully.");
    }
    catch (JsonException)
    {
        WriteLine("Error serializing data to JSON.");
    }
    catch (IOException)
    {
        WriteLine("Error writing data to the file.");
    }
}

List<GameConsole>? ReadFileOnBoot()
{
    try
    {
        var jsonString = File.ReadAllText(jsonFilePath);

        gameConsoles = JsonSerializer.Deserialize<List<GameConsole>>(jsonString);
    }
    catch (FileNotFoundException)
    {
        WriteLine("The JSON file was not found.");
    }
    catch (JsonException)
    {
        WriteLine("Error parsing the JSON file.");
    }

    return gameConsoles;
}