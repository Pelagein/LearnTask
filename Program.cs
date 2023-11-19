using System.Xml.Linq;

namespace LearnTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Animals animal = new Animals("Зверь");
            Cat cat = new Cat("Тобиас");
            Dog dog = new Dog("Тузик");

            animal.Roar();
            dog.Roar();
            cat.Roar();

            Animals catTwo = new Cat("Василий");
            catTwo.Roar();

        }
    }

}