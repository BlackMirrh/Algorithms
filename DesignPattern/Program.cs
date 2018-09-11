using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Creational Patterns
            #region Singleton Structural
            // Ensure a class has only one instance and provide a global point of access to it.
            //Singleton s1 = Singleton.Instance();
            //Singleton s2 = Singleton.Instance();

            //if (s1 == s2)
            //{
            //    Console.WriteLine("Objects are the same instance");
            //}
            #endregion

            #region Abstract Factory Structural
            // Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
            //AbstractFactory factory1 = new ConcreteFactory1();
            //Client client1 = new Client(factory1);
            //client1.Run();

            //AbstractFactory factory2 = new ConcreteFactory2();
            //Client client2 = new Client(factory2);
            //client2.Run();
            #endregion

            #region Abstract Factory Real-World
            //ContinentFactory africa = new AfricaFactory();
            //AnimalWorld world = new AnimalWorld(africa);
            //world.RunFoodChain();

            //ContinentFactory america = new AmericaFactory();
            //world = new AnimalWorld(america);
            //world.RunFoodChain();
            #endregion

            #region Factory Method Structural
            // Define an interface for creating an object, but let subclasses decide which class to instantiate. 
            // Factory Method lets a class defer instantiation to subclasses.
            //Creator[] creators = new Creator[2];

            //creators[0] = new ConcreteCreatorA();
            //creators[1] = new ConcreteCreatorB();

            //foreach(Creator creator in creators)
            //{
            //    Product product = creator.FactoryMethod();
            //    Console.WriteLine("Created {0}", product.GetType().Name);
            //}
            #endregion

            #region Factory Method Real-World 
            //Document[] documents = new Document[2];

            //documents[0] = new Resume();
            //documents[1] = new Report();

            //foreach(Document document in documents)
            //{
            //    Console.WriteLine("\n" + document.GetType().Name + " -- ");
            //    foreach(Page page in document.Pages)
            //    {
            //        Console.WriteLine(" " + page.GetType().Name);
            //    }
            //}
            #endregion
            #endregion

            #region Structural Patterns

            #region Facade Strutural
            // Provide a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.
            //Facade facade = new Facade();

            //facade.MethodA();
            //facade.MethodB();

            #endregion

            #region Facade Real-World
            //Mortgage mortgage = new Mortgage();

            //Customer customer = new Customer("Ann McKinsey");
            //bool eligible = mortgage.IsEligible(customer, 125000);

            //Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approved" : "Rejected"));
            #endregion

            #region Proxy Structural
            // Provide a surrogate or placeholder for another object to control access to it.
            //Proxy proxy = new Proxy();
            //proxy.Request();
            #endregion

            #region Proxy Real-World
            //MathProxy proxy = new MathProxy();

            //Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            //Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            //Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            //Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));
            #endregion

            #region Adapter Strutural
            // Convert the interface of a class into another interface client expect. 
            // Adapter lets classes work together that couldn't otherwise because of incompatible interfaces
            //Target target = new Adapter();
            //target.Request();
            #endregion

            #region Adapter Real-World
            //Compound unknown = new Compound("Unknown");
            //unknown.Display();

            //Compound water = new RichCompound("Water");
            //water.Display();

            //Compound benzene = new RichCompound("Benzene");
            //benzene.Display();

            //Compound ethanol = new RichCompound("Ethanol");
            //ethanol.Display();
            #endregion

            #region Bridge Strutural
            // Decouple an abstraction from its implementation so that the two can vary independently
            //Abstraction ab = new RefinedAbstraction();

            //ab.Implementor = new ConcreateImplementorA();
            //ab.Operation();

            //ab.Implementor = new ConcreateImplementorB();
            //ab.Operation();
            #endregion

            #endregion

            #region Behavioral Patterns
            #region Observer Strutural
            // Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.

            #endregion

            #region Observer Real-World
            #endregion
            #endregion

            Console.ReadLine();
        }
    }
}
