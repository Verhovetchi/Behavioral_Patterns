using System;
using System.Collections.Generic;

namespace ObserverPattern.ConcreteSubject
{
     public class NewsEventArgs
     {
          public string FranceFootball { get; private set; }
          public string Deportivo { get; private set; }
          public string BarcaNews { get; private set; }

          public NewsEventArgs(string franceFootball, string deportivo, string barcaNews)
          {
               FranceFootball = franceFootball;
               Deportivo = deportivo;
               BarcaNews = barcaNews;
          }
     }

     public delegate void NewsChangedEventHandler(object sender, NewsEventArgs e);

     public class Publisher
     {
          private static Random _random;

          public Publisher()
          {
               _random = new Random();
          }

          public event NewsChangedEventHandler NewsChanged;

          public string GetFranceFootballNews()
          {
               var news = new List<string>
                           {
                               "News from FranceFootball 1",
                               "News from FranceFootball 2",
                               "News from FranceFootball 3"
                           };

               return news[_random.Next(3)];
          }

          public string GetDeportivoNews()
          {
               var news = new List<string>
                           {
                               "News from Deportivo 1",
                               "News from Deportivo 2",
                               "News from Deportivo 3"
                           };

               return news[_random.Next(3)];
          }

          public string GetBarcaNews()
          {
               var news = new List<string>
                           {
                               "News from BarcaNews 1",
                               "News from BarcaNews 2",
                               "News from BarcaNews 3"
                           };

               return news[_random.Next(3)];
          }

          public void Notify()
          {
               string franceFootball = GetFranceFootballNews();
               string deportivo = GetDeportivoNews();
               string barcaNews = GetBarcaNews();

               NewsChanged(this, new NewsEventArgs(franceFootball, deportivo, barcaNews));
          }
     }
}
