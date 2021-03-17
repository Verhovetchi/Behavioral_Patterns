using System;
using ObserverPattern.ConcreteSubject;
using ObserverPattern.ConcreteObserver;

namespace ObserverPattern
{
     class Program
     {
          static void Main(string[] args)
          {
               var publisher = new Publisher();
               var franceFootballWidget = new FranceFootballWidget();
               var deportivoWidget = new DeportivoWidget();
               var barcaNewsWidget = new BarcaNewsWidget();

               publisher.NewsChanged += franceFootballWidget.Update;
               publisher.NewsChanged += deportivoWidget.Update;
               publisher.NewsChanged += barcaNewsWidget.Update;

               publisher.Notify();
               Console.WriteLine();

               publisher.NewsChanged -= franceFootballWidget.Update;
               publisher.Notify();

               Console.ReadLine();
          }
     }
}
