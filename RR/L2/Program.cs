using L2.activeobject;
using L2.factorymethod;
using L2.flyweight;
using L2.observer;

void factoryMethod()
{
    Console.WriteLine("Factory method:");
    Creator creator = new ConcreteCreator();
    var product = creator.FactoryMethod();
    Console.WriteLine(product.Operation());
    Console.WriteLine(creator.AnOperation());
}

void flyweight()
{
    Console.WriteLine("Flyweight:");
    var factory = new FlyweightFactory();

    var flyweightX = factory.GetFlyweight("X");
    flyweightX.Operation("100");

    var flyweightY = factory.GetFlyweight("Y");
    flyweightY.Operation("200");

    var flyweightZ = factory.GetFlyweight("Z");
    flyweightZ.Operation("300");

    var flyweightXRepeated = factory.GetFlyweight("X");
    flyweightXRepeated.Operation("500");
}

void observer()
{
    Console.WriteLine("Observer:");
    var subject = new ConcreteSubject();
    var observer = new ConcreteObserver();
    subject.RegisterObserver(observer);
    subject.NotifyObservers();
    subject.RemoveObserver(observer);
}

void activeObject()
{
    Console.WriteLine("Active object:");
    var activeObject = new ActiveObject();

    activeObject.DoSomething();
    Thread.Sleep(100);
    Console.WriteLine($"Value after DoSomething: {activeObject.val}");

    activeObject.DoSomethingElse();
    Thread.Sleep(100);
    Console.WriteLine($"Value after DoSomethingElse: {activeObject.val}");
}

factoryMethod();
flyweight();
observer();
activeObject();