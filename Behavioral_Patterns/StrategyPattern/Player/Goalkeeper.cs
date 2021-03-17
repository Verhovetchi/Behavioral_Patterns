using System;
using StrategyPattern.Strategy;

namespace StrategyPattern.Player
{
     class Goalkeeper : Player, ISave
     {
          public Goalkeeper() => Position = "Goalkeeper";

          public override void Jump() => Console.WriteLine("Jump for save");

     }
}
