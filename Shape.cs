namespace LearnTask
{
    public abstract class Shape
    {
        public Shape()
        {
            Console.WriteLine($"Shape created!");
        }

        public abstract double Area();
        public abstract double Perimetr();
    }

    public class Rectangle : Shape
    {
        private readonly double widht;
        private readonly double height;

        public Rectangle(double widht, double height)
        {
            this.widht = widht;
            this.height = height;
            Console.WriteLine($"Rectangle created!");
        }

        public override double Area()
        {
            return widht * height;
        }
        public override double Perimetr()
        {
            return 2 * (widht + height);
        }
    }

    public class Triangle : Shape
    {
        private readonly double ab;
        private readonly double bc;
        private readonly double ac;

        public Triangle(double ab, double bc, double ac)
        {
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;
            Console.WriteLine($"Triangle created!");
        }
        public override double Area()
        {
            double S = (ab + bc + ac) / 2;
            return Math.Sqrt(S * (S - ab) * (S - bc) * (S - ac));
        }
        public override double Perimetr()
        {
            return ab + bc + ac;
        }
    }
}
