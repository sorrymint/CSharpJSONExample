# Serialization

## History
- What we used to use: [BinaryFormatter](https://learn.microsoft.com/en-us/dotnet/api/System.Runtime.Serialization.Formatters.Binary.BinaryFormatter?view=netframework-4.8)
- [Why we don't use it](https://learn.microsoft.com/en-us/dotnet/standard/serialization/binaryformatter-security-guide)
- DateOnly doesn't work with JSON converter :(

## POCO
- Build the `GameConsole.cs`

## Console App
- build `consoles.json`
- put it into `bin>Debug>net.8.0`
- Build out `readFileOnBoot()`
- Print out List of Consoles
- Add console to list
- Build out `SaveData()`

## EOD
  