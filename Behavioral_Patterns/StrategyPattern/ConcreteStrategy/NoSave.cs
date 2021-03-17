using System;
using StrategyPattern.Strategy;

namespace StrategyPattern.ConcreteStrategy
{
     public class NoSave : ISave
     {
          public void Save(){ }
     }
}
