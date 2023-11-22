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

            //Shape[] shapes = new Shape[2];
            //shapes[0] = new Triangle(12, 24, 13);
            //shapes[1] = new Rectangle(10, 23);

            //foreach (Shape shape in shapes)
            //{
            //    Console.WriteLine(shape.Area());
            //    Console.WriteLine(shape.Perimetr());
            //}

            //Test Task 

            //Book book = new Book("Programming in C", "John Doe", 2023);
            //book.Print();
            //book.MarkAsRead();
            //book.Print();

            //Задача 1.
            //Дан массив целых чисел. Требуется сформировать новый массив без дубликатов и вывести результат в консоль.
            //Пример: (i.e. "1 3 5 3 7 3 1 1 5"-> "1 3 5 7")
            //В алгоритме нельзя использовать System.Linq.
            //*/
            var arr = new int[] { 1, 3, 5, 3, 7, 3, 1, 1, 5 };
            var list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int n = 0;
                for (int j = 0; j < list.Count; j++)
                {
                    if (arr[i] == list[j]) { n++; }
                }
                if (n == 0) { list.Add(arr[i]); }
            }
            foreach (int k in list) { Console.Write(k); }

            var array = new List<int>();

            array = arr.Distinct().ToList();
            foreach (int k in list) { Console.Write(k); }
            //foreach (int i in arr)
            //{
            //    Console.Write($"{i} ");
            //}



        }

    }

}