#region Decorator
// Summary: Demonstrates the Decorator pattern which attaches additional
//          responsibilities to objects dynamically.
// Time Complexity: O(n) where n is the number of decorator layers.
// Number of Operations: 7

#region 1.1

/*var concreteComponent = new ConcreteComponent();
concreteComponent.Operation();

Console.WriteLine("--------------------------------------------");

var concreteComponent2 = new ConcreteComponent();
var concreteDecorator = new ConcreteDecorator(concreteComponent2);
concreteDecorator.Operation();
Console.WriteLine("--------------------------------------------");

var concreteComponent3 = new ConcreteComponent();
var concreteDecorator2 = new ConcreteDecorator2(concreteComponent3);
concreteDecorator2.Operation();*/

#endregion

#region 1.2

/*var smsSender = new SmsSender();
smsSender.Send();
Console.WriteLine("--------------------------------------------");
var smsSender2 = new SmsSender();
var smsSenderDecorator = new SmsSenderDecorator(smsSender);
smsSenderDecorator.Send();*/

#endregion

#region 1.3

/*var webClient = new WebClient();
var webClientDecorator = new WebClientDecorator(webClient);
var client1= webClientDecorator.DownloadString("http://www.google.com");
var client2= webClientDecorator.DownloadString("http://www.yahoo.com");
Console.ReadLine();*/

#endregion

#endregion

#region Facade
// Summary: Wraps complex subsystems with a simple interface.
// Time Complexity: O(1)
// Number of Operations: 1

/*
var facade = new Facade();

facade.DoSomething();
*/

#endregion

#region Bridge
// Summary: Decouples an abstraction from its implementation so the two can vary.
// Time Complexity: O(1)
// Number of Operations: 1

/*Abstraction abstraction = new RefinedAbstraction();
abstraction.Function();*/

#endregion

#region Composite
// Summary: Composes objects into tree structures to represent part-whole hierarchies.
// Time Complexity: O(n) where n is the number of nodes in the tree.
// Number of Operations: 15

/*Component component = new Composite("Root Item", [
    new Leaf("Leaf 1"),
    new Leaf("Leaf 2"),
    new Composite("Composite 1", [
        new Leaf("Leaf Composite 1-1"),
        new Leaf("Leaf Composite 1-2"),
        new Leaf("Leaf Composite 1-3"),
        new Composite("Composite 1-1", [
            new Leaf("Leaf Composite 1-1-1")
        ])
    ]),
    new Leaf("Leaf 3"),
    new Composite("Composite 2", [
        new Leaf("Leaf Composite 2-1"),
        new Leaf("Leaf Composite 2-2"),
        new Leaf("Leaf Composite 2-3")
    ]),
    new Leaf("Leaf 4")
]);
component.Display(1);*/

#endregion

#region Flyweight
// Summary: Shares common state across many small objects to save memory.
// Time Complexity: O(n) where n is the number of flyweight operations.
// Number of Operations: 4

/*var flyweightFactory = new FlyweightFactory();

var flyweight1=flyweightFactory.GetFlyweight("Hossein");
var flyweight2=flyweightFactory.GetFlyweight("Amir");
var flyweight3=flyweightFactory.GetFlyweight("Amir");

flyweight1.Operation("Flyweight1 Extrinsic state");
flyweight2.Operation("Flyweight2 Extrinsic state");
flyweight3.Operation("Flyweight3 Extrinsic state");

var unSharedConcreteFlyweight = new UnSharedConcreteFlyweight(new List<FlyWeight>()
{
    flyweightFactory.GetFlyweight("Hossein"),
    flyweightFactory.GetFlyweight("Amir"),
    flyweightFactory.GetFlyweight("Mohammad"),
    flyweightFactory.GetFlyweight("Reza")
});

unSharedConcreteFlyweight.Operation("unSharedConcreteFlyweight Extrinsic state");*/

#endregion

#region Adapter
// Summary: Converts the interface of a class into another interface clients expect.
// Time Complexity: O(1)
// Number of Operations: 2

#region Object Adapter

/*Target target = new Adapter();

target.Operation();*/

#endregion

#region Class Adapter

/*ITarget target2 = new DesignPattern.Adapter.ClassAdapter.Adapter();

target2.Operation();*/

#endregion

#endregion

#region Prototype
// Summary: Creates new objects by copying existing instances.
// Time Complexity: O(n) where n is the size of the object graph being cloned.
// Number of Operations: 2

/*//Shallow Copy
ConcretePrototype1 concretePrototype1 = new ConcretePrototype1();
ConcretePrototype1 concretePrototype1_2 =(ConcretePrototype1)concretePrototype1.Clone();

//Deep Copy
ConcretePrototype2 concretePrototype2 = new ConcretePrototype2();
ConcretePrototype2 concretePrototype2_2 =(ConcretePrototype2)concretePrototype1.Clone();*/


#endregion

#region Singleton
// Summary: Ensures a class has only one instance and provides global access.
// Time Complexity: O(1)
// Number of Operations: 2

/*Singelton singelton = Singelton.GetInstance();
Singelton singelton_2 = Singelton.GetInstance();*/

#endregion

#region Factory Method
// Summary: Defines an interface for creating an object but lets subclasses decide
//          which class to instantiate.
// Time Complexity: O(n) where n is the number of requested instances.
// Number of Operations: 6

/*
IUserService userService1;
IUserService userService2;
IUserService userService3;

Creator creator = new ConcreteCreator();

userService1 = creator.GetInstance(5);
userService1.Operation();
Console.WriteLine(".................................");
userService2 = creator.GetInstance(0);
userService2.Operation();
Console.WriteLine(".................................");
userService3 = creator.GetInstance(1);
userService3.Operation();
*/

#endregion

#region Builder
// Summary: Separates the construction of a complex object from its representation.
// Time Complexity: O(n) where n is the number of build steps.
// Number of Operations: 8

/*Director director = new();
var builder1 = new ConcreteProductBuilder1();
var builder2 = new ConcreteProductBuilder2();

director.SetProductBuilder(builder1);
director.Construct();

var product1 = builder1.GetResult();
product1.Show();
//or
director.SetProductBuilder(builder2);
director.Construct();

var product2 = builder2.GetResult();
product2.Show();*/

#endregion

#region Strategy
// Summary: Encapsulates interchangeable algorithms behind a common interface.
// Time Complexity: O(n) where n is the number of strategy operations.
// Number of Operations: 3

/*Context contextA = new(new ConcreteStrategyA());
Context contextB = new(new ConcreteStrategyB());
Context contextC = new(new ConcreteStrategyC());

contextA.Operation();
Console.WriteLine("....................");
contextB.Operation();
Console.WriteLine("....................");
contextC.Operation();*/

#endregion

#region Chain Of Responsibility
// Summary: Passes requests along a chain of handlers until one handles it.
// Time Complexity: O(n) where n is the number of handlers/requests.
// Number of Operations: 8

/*int[] requests = [2, 5, 14, 22, 18, 3, 24, 20];

Handler handler1 = new ConcreteHandler1();
Handler handler2 = new ConcreteHandler2();
Handler handler3 = new ConcreteHandler3();

handler1.SetSuccessor(handler2);
handler2.SetSuccessor(handler3);

foreach (var i in requests)
{
    handler1.Handle(i);
}*/

#endregion

#region Command
// Summary: Encapsulates a request as an object, allowing for parameterization
//          and queuing of requests.
// Time Complexity: O(1)
// Number of Operations: 2

/*Receiver receiver=new Receiver();
Command command = new ConcreteCommand(receiver);
Invoker invoker = new Invoker();

invoker.setCommand(command);
invoker.ExecuteCommand();*/

#endregion

#region Memento
// Summary: Captures and restores an object's internal state without violating encapsulation.
// Time Complexity: O(1)
// Number of Operations: 4

/*using DesignPattern.Memento;

Originator originator = new Originator();
Caretaker caretaker = new Caretaker();

originator.State = "State #1";
caretaker.Memento = originator.CreateMemento();

originator.State = "State #2";
originator.SetMemento(caretaker.Memento);

Console.WriteLine("Done");*/

#endregion

#region Observer
// Summary: Defines a one-to-many dependency so that observers are notified
//          of state changes.
// Time Complexity: O(n) where n is the number of observers.
// Number of Operations: 5

/*using DesignPattern.Observer;

ConcreteSubject subject = new ConcreteSubject();
subject.Attach(new ConcreteObserver(subject,"A"));
subject.Attach(new ConcreteObserver(subject,"B"));
subject.Attach(new ConcreteObserver(subject,"C"));

subject.SubjectState="Hello World!";
subject.Notify();*/

#endregion

#region Visitor
// Summary: Represents operations to be performed on elements of an object structure.
// Time Complexity: O(n) where n is the number of elements visited.
// Number of Operations: 10

/*using DesignPattern.Visitor;

ConcreteElementA ca1 = new ConcreteElementA("Ca1_1");
ConcreteElementA ca2 = new ConcreteElementA("Ca1_2");
ConcreteElementA ca3 = new ConcreteElementA("Ca1_3");
ConcreteElementA ca4 = new ConcreteElementA("Ca1_4");

ConcreteElementB cb1 = new ConcreteElementB(1);
ConcreteElementB cb2 = new ConcreteElementB(2);
ConcreteElementB cb3 = new ConcreteElementB(3);
ConcreteElementB cb4 = new ConcreteElementB(4);

ObjectStructure objStructure = new ObjectStructure();

objStructure.AddElement(ca1);
objStructure.AddElement(ca2);
objStructure.AddElement(ca3);
objStructure.AddElement(ca4);
objStructure.AddElement(cb1);
objStructure.AddElement(cb2);
objStructure.AddElement(cb3);
objStructure.AddElement(cb4);

Visitor visitor1 = new ConcreteVisitor1();
Visitor visitor2 = new ConcreteVisitor2(); 
objStructure.Accept(visitor1);
objStructure.Accept(visitor2);*/

#endregion

#region Mediator
// Summary: Defines an object that encapsulates how a set of objects interact.
// Time Complexity: O(1)
// Number of Operations: 4

/*using DesignPattern.Mediator;

ConcreteMediator mediator = new ConcreteMediator();
ConcreteColleagueA colleagueA = new ConcreteColleagueA(mediator);
ConcreteColleagueB colleagueB = new ConcreteColleagueB(mediator);

mediator.ColleagueA = colleagueA;
mediator.ColleagueB = colleagueB;

colleagueA.Send("How are you?");
colleagueB.Send("Fine, thanks");*/

#endregion

#region Iterator
// Summary: Provides a way to access elements of a collection sequentially
//          without exposing its underlying representation.
// Time Complexity: O(n) where n is the number of elements iterated.
// Number of Operations: 5

/*using DesignPattern.Iterator;

ConcreteAggregate aggregate = new ConcreteAggregate();
aggregate[0] = "Item A";
aggregate[1] = "Item B";
aggregate[2] = "Item C";
aggregate[3] = "Item D";
aggregate[4] = "Item E";

Iterator iterator = aggregate.CreateIterator();

Object item = iterator.First();

while (!iterator.IsDone())
{
    Console.WriteLine(item);
    item = iterator.Next();
}*/

#endregion

#region State
// Summary: Allows an object to alter its behavior when its internal state changes.
// Time Complexity: O(n) where n is the number of state transitions.
// Number of Operations: 3

/*using DesignPattern.State;

Context context = new Context(new ConcreteStateA());
context.Request();
context.Request();
context.Request();*/

#endregion

#region Interpreter
// Summary: Defines a grammatical representation for a language and an interpreter
//          to evaluate sentences in the language.
// Time Complexity: O(n) where n is the number of expressions.
// Number of Operations: 2

/*using DesignPattern.Interpreter;

Context context = new Context();

List<AbstractExpression> list = new List<AbstractExpression>()
{
    new TerminalExpression(),
    new NonterminalExpression(new TerminalExpression(),new TerminalExpression())
};

foreach (var exp in list)
{
    exp.Interpret(context);
}*/

#endregion

#region Template Method
// Summary: Defines the skeleton of an algorithm, deferring some steps to subclasses.
// Time Complexity: O(n) where n is the number of template executions.
// Number of Operations: 2

/*using DesignPattern.Template_Method;

AbstractClass abstractClassA=new ConcreteClassA();
AbstractClass abstractClassB=new ConcreteClassB();

abstractClassA.TemplateMethod();
abstractClassB.TemplateMethod();*/

#endregion

#region Proxy
// Summary: Provides a surrogate or placeholder for another object to control access to it.
// Time Complexity: O(1)
// Number of Operations: 1

/*using DesignPattern.Proxy;

Proxy proxy = new Proxy();
proxy.Request();*/

#endregion

#region Abstract Factory
// Summary: Provides an interface for creating families of related objects
//          without specifying their concrete classes.
// Time Complexity: O(n) where n is the number of products created.
// Number of Operations: 8

/*using DesignPattern.Abstract_Factory;
using DesignPattern.Abstract_Factory.Services.ProductA;
using DesignPattern.Abstract_Factory.Services.ProductB;

IAbstractFactory factory1 = new ConcreteFactory1();
IAbstractFactory factory2 = new ConcreteFactory2();

IAbstractProductA productA1= factory1.CreateProductA();
IAbstractProductB productB1= factory1.CreateProductB();

productA1.Execute();
productB1.Execute();

IAbstractProductA productA2= factory2.CreateProductA();
IAbstractProductB productB2= factory2.CreateProductB();

productA2.Execute();
productB2.Execute();*/

#endregion

Console.ReadLine();