# DiceTower

This project is a dice roller that gives you the sum of random dice rolls given the number of dice and the number of sides for those dice.

## Usage

To roll a single D4:
```
var die = new Die(4);
die.Roll();
Console.WriteLine($"You rolled a {die.Value}");
```

To roll 4 D20s:
```
var roller = new Roller(4, 20);
var rollResult = roller.Roll();
Console.WriteLine($"You rolled a total of {rollResult.TotalValue}");
```

To roll a single D20 with advantage:
```
var die = new Die(20);
die.WithAdvantage().Roll();
Console.WriteLine($"You rolled a {die.Value}");
```

To roll a single D20 with disadvantage:
```
var die = new Die(20);
die.WithDisadvantage().Roll();
Console.WriteLine($"You rolled a {die.Value}");
```

## Build

To build the project run `dotnet build`

## Test

To run unit tests on the project run `dotnet test`

## Package & Push

To package the project run `dotnet pack`

Then, to push it to nuget run `dotnet nuget push ./bin/Debug/DiceTower.*.nupkg -k [ApiKey] -s https://api.nuget.org/v3/index.json`
