# C# Dice Roller

This project is a dice roller that gives you the sum of random dice rolls given the number of dice and the number of sides for those dice.

## Usage

To roll a single D4:
```
var die = new Die(4);
var result = die.Roll();
```

To roll 4 D20s:
```
var roller = new Roller(4, 20);
var result = roller.Roll();
```

## Build

To build the project run `dotnet build`

## Test

To run unit tests on the project run `dotnet test`
