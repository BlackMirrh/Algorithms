using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();

    }

    class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }

    class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }

    abstract class Herbivore
    { }

    abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }

    class Wildebeest : Herbivore
    {

    }

    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }

    class Bison : Herbivore
    {

    }

    class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }

    class AnimalWorld
    {
        private Herbivore herbivore;
        private Carnivore carnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            carnivore = factory.CreateCarnivore();
            herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            carnivore.Eat(herbivore);
        }
    }

    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    abstract class AbstractProductA
    {

    }

    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }

    class ProductA1 : AbstractProductA
    {

    }

    class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }

    class ProductA2 : AbstractProductA
    {

    }

    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }

    class Client
    {
        private AbstractProductA abstractProductA;
        private AbstractProductB abstractProductB;

        public Client(AbstractFactory factory)
        {
            abstractProductB = factory.CreateProductB();
            abstractProductA = factory.CreateProductA();
        }

        public void Run()
        {
            abstractProductB.Interact(abstractProductA);
        }

    }
}
