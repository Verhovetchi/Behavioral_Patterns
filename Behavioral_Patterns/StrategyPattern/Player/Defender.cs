using System;
using StrategyPattern.ConcreteStrategy;
using StrategyPattern.Strategy;

namespace StrategyPattern.Player
{
     class Defender : Player, ISave
     {
          public Defender() 
          { 
               iSave = new NoSave();
               Position = "Defender";
          } 

          public override void Jump() => Console.WriteLine("Jump for tackle");
          
     }
}
