using StrategyPattern.ConcreteStrategy;
using StrategyPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Player
{
     class Midfield : Player, ISave
     {
          public Midfield() 
          { 
               iSave = new NoSave();
               Position = "Midfield";
          } 

          public override void Jump() => Console.WriteLine("Jump for shoot");


     }
}
