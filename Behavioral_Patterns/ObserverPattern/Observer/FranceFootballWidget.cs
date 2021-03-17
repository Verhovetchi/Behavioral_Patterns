using System;
using ObserverPattern.Observer;
using ObserverPattern.ConcreteSubject;

namespace ObserverPattern.ConcreteObserver
{
     class FranceFootballWidget : IWidget
     {
          private string _franceFootball;

          public void Update(object sender, NewsEventArgs e)
          {
               _franceFootball = e.FranceFootball;
               Display();
          }

          public void Display() => Console.WriteLine("FranceFootball: {0}", _franceFootball);

     }
}
