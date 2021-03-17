using System;
using StrategyPattern.Strategy;
using StrategyPattern.ConcreteStrategy;

namespace StrategyPattern.Player
{
     class Forward : Player, ISave
     {
          public Forward() 
          { 
               iSave = new NoSave();
               Position = "Forward";
          } 

          public override void Jump() => Console.WriteLine("Jump for shoot");
     }
}
