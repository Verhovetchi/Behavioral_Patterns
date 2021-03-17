using System;
using StrategyPattern.Strategy;

namespace StrategyPattern.Strategy
{
     class SaveWithHands : ISave
     {
          public void Save() => Console.WriteLine("Save with hands");
     }
}
