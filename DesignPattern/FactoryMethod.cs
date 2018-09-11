using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    abstract class Product
    {
    }

    class ConcreteProductA : Product
    {
    }

    class ConcreteProductB : Product
    {

    }

    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }

    abstract class Page
    { }

    class SkillsPage : Page
    { }

    class EducationPage : Page
    { }

    class ExperiencePage : Page
    { }

    class IntroductionPage : Page
    { }

    class ResultsPage : Page
    { }

    class ConclusionPage : Page
    { }

    class SummaryPage : Page
    { }

    class BibliopraphyPage : Page
    { }

    abstract class Document
    {
        private List<Page> pages = new List<Page>();

        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return pages; }
        }

        public abstract void CreatePages();
    }

    class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }

    class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliopraphyPage());
        }
    }
}
