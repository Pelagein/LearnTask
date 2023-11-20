namespace LearnTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Повторения Наследования.
            //Animals animal = new Animals("Зверь");
            //Cat cat = new Cat("Тобиас");
            //Dog dog = new Dog("Тузик");

            //animal.Roar();
            //dog.Roar();
            //cat.Roar();

            //Animals catTwo = new Cat("Василий");
            //catTwo.Roar();

            //Повторение полиморфизма (абстрактных классов)

            Shape[] shapes = new Shape[2];
            shapes[0] = new Triangle(12, 24, 13);
            shapes[1] = new Rectangle(10, 23);

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area());
                Console.WriteLine(shape.Perimetr());
            }
            

        }

    }

}