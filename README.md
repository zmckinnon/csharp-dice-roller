# DiceTower [![Build Status](https://travis-ci.com/zmckinnon/dice-tower.svg?branch=master)](https://travis-ci.com/zmckinnon/dice-tower)

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

To roll a single D20 with advantage:
```
var die = new Die(20);
var result = die.WithAdvantage().Roll();
```

To roll a single D20 with disadvantage:
```
var die = new Die(20);
var result = die.WithDisadvantage().Roll();
```

## Build

To build the project run `dotnet build`

## Test

To run unit tests on the project run `dotnet test`

## Package & Push

To package the project run `dotnet pack`

Then, to push it to nuget run `dotnet nuget push ./bin/Debug/DiceTower.*.nupkg -k [ApiKey] -s https://api.nuget.org/v3/index.json`
