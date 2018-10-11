# AgeCalc.cs

C# Age Calculation Library

## Installation

```sh
# Using NuGet Package Manager Console:
PM> Install-Package Faisalman.AgeCalc

# Using NuGet .NET CLI:
dotnet add package Faisalman.AgeCalc
```

## Usage Example

```cs
using System;
using Faisalman.AgeCalc;

class Program
{
  static void Main(string[] args)
  {
    DateTime bday = new DateTime(1970, 8, 21);
    DateTime cday = new DateTime(2014, 4, 30);
    Age age = new Age(bday, cday);
    
    Console.WriteLine("It's been {0} years, {1} months, and {2} days since your birthday", age.Years, age.Months, age.Days);
    // output: "It's been 43 years, 8 months, and 9 days since your birthday";
  }
}
```

## License

MIT License

Copyright © 2013 Faisalman <<fyzlman@gmail.com>>
