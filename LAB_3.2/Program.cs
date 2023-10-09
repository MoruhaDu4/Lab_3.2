namespace LAB_3._2
{
    class Parent
    {
        protected double Pole1;
        protected double Pole2;

        public Parent()
        {
            Pole1 = 0;
            Pole2 = 0;
        }

        public Parent(double radius, double height)
        {
            Pole1 = radius;
            Pole2 = height;
        }

        public void Print()
        {
            Console.WriteLine($"Радiус пiдстави: {Pole1}");
            Console.WriteLine($"Висота: {Pole2}");
        }

        public double Metod1()
        {
            return Math.PI * Pole1 * Pole1 * Pole2;        }

        public double Metod2()
        {
            return 2 * Math.PI * Pole1 * (Pole1 + Pole2);
        }
    }

    class Child : Parent
    {
        public Child(double radius) : base(radius, 2 * radius)
        {
            
            double R = radius / 2;

            Console.WriteLine($"Радiус вписаного куля: {R}");
        }

        public double Metod3()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Pole1 / 2, 3);
        }

        public double Metod4()
        {
            return 4 * Math.PI * Math.Pow(Pole1 / 2, 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                double radius = rand.NextDouble() * 10 + 1;
                double height = rand.NextDouble() * 10 + 1;

                if (height != 2 * radius)
                {
                    Parent parentCylinder = new Parent(radius, height);
                    Console.WriteLine("Це звичайний цилiндр:");
                    parentCylinder.Print();
                    Console.WriteLine($"Об'єм цилiндра: {parentCylinder.Metod1()}");
                    Console.WriteLine($"Площа повної поверхнi цилiндра: {parentCylinder.Metod2()}");
                }
                else
                {
                    Child childCylinder = new Child(radius);
                    Console.WriteLine("Це рiвностороннiй цилiндр:");
                    childCylinder.Print();
                    Console.WriteLine($"Об'єм вписаного куля: {childCylinder.Metod3()}");
                    Console.WriteLine($"Площа поверхнi вписаного куля: {childCylinder.Metod4()}");
                }

                Console.WriteLine();
            }
        }
    }  
}
