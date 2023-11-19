namespace LearnTask
{
    class Animals
    {
        public Animals(string Name)
        {
            this.Name = Name;
        }
        public string Name { get; set; }
        virtual public void Roar()
        {
            Console.WriteLine($"{Name} кричит!");
        }

    }

    class Cat : Animals
    {
        public Cat(string Name) :base(Name) { }
        public override void Roar()
        {
            Console.WriteLine($"Кот {Name} мяукает !");
        }

    }

    class Dog : Animals
    {
        public Dog(string Name) : base(Name) { }
        public override void Roar()
        {
            Console.WriteLine($"Пёс {Name} гавкает !");
        }

    }
}
