using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new PanelDeveloper("ТОВ Будівельник");
            House house2 = dev.Create();

            dev = new WoodDeveloper("Приватний будівельник");
            House house = dev.Create();

            Console.ReadLine();
        }
    }

    abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string n)
        {
            Name = n;
        }
        // фабричный метод
        abstract public House Create();
    }
 
    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new PanelHouse();
        }
    }

    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new WoodHouse();
        }
    }

    abstract class House
    { }

    class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельний дім побудований");
        }
    }
    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Дерев'яний дім побудований");
        }
    }
}
