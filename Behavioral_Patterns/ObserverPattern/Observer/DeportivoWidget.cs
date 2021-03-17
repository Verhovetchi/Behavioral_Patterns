using System;
using ObserverPattern.Observer;
using ObserverPattern.ConcreteSubject;

namespace ObserverPattern.ConcreteObserver
{
     class DeportivoWidget : IWidget
     {
          private string _deportivo;

          public void Update(object sender, NewsEventArgs e)
          {
               _deportivo = e.Deportivo;
               Display();
          }

          public void Display() => Console.WriteLine("Deportivo: {0}", _deportivo);
     }
}
