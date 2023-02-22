# C# interview boilerplate

Contains lib, console app, and test projects.

## Creation

```sh
dotnet new sln
dotnet new classlib NAME
dotnet new console NAME
dotnet new xunit NAME
# add references
cd Tests && dotnet add reference ..\Lib
cd App && dotnet add reference ..\Lib
# handy commands
dotnet build
dotnet run
dotnet test
```
