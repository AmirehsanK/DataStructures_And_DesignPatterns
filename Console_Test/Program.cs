
#region Decorator

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

/*
var facade = new Facade();

facade.DoSomething();
*/

#endregion

#region Bridge

/*Abstraction abstraction = new RefinedAbstraction();
abstraction.Function();*/

#endregion

#region Composite

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

/*//Shallow Copy
ConcretePrototype1 concretePrototype1 = new ConcretePrototype1();
ConcretePrototype1 concretePrototype1_2 =(ConcretePrototype1)concretePrototype1.Clone();

//Deep Copy
ConcretePrototype2 concretePrototype2 = new ConcretePrototype2();
ConcretePrototype2 concretePrototype2_2 =(ConcretePrototype2)concretePrototype1.Clone();*/


#endregion

#region Singleton

/*Singelton singelton = Singelton.GetInstance();
Singelton singelton_2 = Singelton.GetInstance();*/

#endregion

#region Factory Method

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



#endregion

#region Command



#endregion

#region Memento



#endregion

#region Observer



#endregion

Console.ReadLine();
