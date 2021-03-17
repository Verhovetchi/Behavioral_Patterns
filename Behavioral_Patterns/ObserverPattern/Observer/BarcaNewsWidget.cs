using System;
using ObserverPattern.Observer;
using ObserverPattern.ConcreteSubject;

namespace ObserverPattern.ConcreteObserver
{
     class BarcaNewsWidget : IWidget
     {
          private string _barcaNews;

          public void Update(object sender, NewsEventArgs e)
          {
               _barcaNews = e.BarcaNews;
               Display();
          }

          public void Display() => Console.WriteLine("BarcaNews: {0}", _barcaNews);
     }
}
