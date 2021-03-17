using System;
using StrategyPattern.Strategy;

namespace StrategyPattern.Player
{
     public abstract class Player
     {
          public string Position { get; protected set; }

          protected ISave iSave;

          public Player() => iSave = new SaveWithHands();
          
          public void Shoot() => Console.WriteLine("Shoot");

          public void Fall() => Console.WriteLine("Fall");

          public virtual void Save() => iSave.Save();

          public abstract void Jump();
     }
}
