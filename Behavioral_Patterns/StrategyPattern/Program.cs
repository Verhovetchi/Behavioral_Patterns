using System;
using System.Collections.Generic;
using StrategyPattern.Player;

namespace StrategyPattern
{
     class Program
     {
          static void Main(string[] args)
          {
               List<Player.Player> lstPlayers = new List<Player.Player>();

               Player.Player gk = new Goalkeeper();
               Player.Player df = new Defender();
               Player.Player mf = new Midfield();
               Player.Player fw = new Forward();

               lstPlayers.Add(gk);
               lstPlayers.Add(df);
               lstPlayers.Add(mf);
               lstPlayers.Add(fw);

               foreach (var player in lstPlayers)
               {
                    Console.WriteLine($"{player.Position}");
                    player.Save();
                    player.Fall();
                    player.Jump();
                    player.Shoot();
                    Console.WriteLine();
               }


               Console.ReadKey();
          }
     }
}
