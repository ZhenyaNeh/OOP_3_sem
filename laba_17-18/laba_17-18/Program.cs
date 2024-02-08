using System;

namespace laba_17_18
{
    internal class Program
    {
        static void Main()
        {
            //SingleTone
            TravelAgent travelAgent = TravelAgent.GetInstance(); 
            TravelAgent travelAgent1 = TravelAgent.GetInstance(); 

            //Builder
            Client client = new Client { ClientName = "Eugene", IdNumb = 5635 };

            List<Tours> tours = new()
            {
                new Tours {Name = "Relax", IsHotDeal = true, BasePrice = 1200},
                new Tours {Name = "Travel", IsHotDeal = false, BasePrice = 1300},
                new Tours {Name = "Excursion", IsHotDeal = true, BasePrice = 1000}
            };

            var builder = new TravelAgentBuilder(client, tours);

            var director = new TravelAgentDirector(builder);

            director.Build();

            var report = builder.GetTravelAgent();

            Console.WriteLine(report);
            Console.WriteLine();

            //Abstract factory // adapter
            ITarget target = new Adapter(travelAgent1);
            target.Main();

            //Prototype
            Tours t1 = new Tours();
            t1.Name = "Relax";
            t1.IsHotDeal = true;
            t1.BasePrice = 1000;
            t1.IdInfo = new IdInfo(666);

            Tours t2 = t1.ShallowCopy();
            Tours t3 = t1.DeepCopy();

            Console.WriteLine("\n\nOriginal values of p1, p2, p3:");
            Console.WriteLine("   t1 instance values: ");
            DisplayValues(t1);
            Console.WriteLine("   t2 instance values:");
            DisplayValues(t2);
            Console.WriteLine("   t3 instance values:");
            DisplayValues(t3);

            t1.Name = "Travel";
            t1.IsHotDeal = false;
            t1.BasePrice = 2000;
            t1.IdInfo.IdNumber = 777;

            Console.WriteLine("\nValues of t1, t2 and t3 after changes to t1:");
            Console.WriteLine("   t1 instance values: ");
            DisplayValues(t1);
            Console.WriteLine("   t2 instance values:");
            DisplayValues(t2);
            Console.WriteLine("   t3 instance values:");
            DisplayValues(t3);

            //decorator
            Tours toursDecorator = new Tours();
            var simple = new ConcreteComponent();
            Console.WriteLine("\n\nWeather (simple Information):");
            toursDecorator.TourCode(simple);
            Console.WriteLine();

            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("Weather (Concrete Information):");
            toursDecorator.TourCode(decorator2);
            Console.WriteLine("\n");

            //state
            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();

            //strategy
            var contextStrategy = new ContextStrategy();

            Console.WriteLine("\n\nClient: Strategy is set to normal sorting.");
            contextStrategy.SetStrategy(new ConcreteStrategyA());
            contextStrategy.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            contextStrategy.SetStrategy(new ConcreteStrategyB());
            contextStrategy.DoSomeBusinessLogic();
            Console.WriteLine("\n\n");

            // Observer
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();
        }

        public static void DisplayValues(Tours p)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"      Name: {p.Name}, Hot: {p.IsHotDeal}, Price: {p.BasePrice}");
            Console.ResetColor();
            Console.WriteLine($"      ID#: {p.IdInfo.IdNumber}");
        }
    }
}