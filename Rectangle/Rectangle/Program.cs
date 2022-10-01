using System;

namespace Rectangle
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        private double area;
        public double Area
        {
            get
            {
                return area;
            }
        }
        private double perimeter;
        public double Perimeter
        {
            get
            {
                return perimeter;
            }
        }

        public double AreaCalculator()
        {
            area = side1 * side2;
            Console.Write("Площа: ");
            return area;
        } 
        public double PerimeterCalculator()
        {
            perimeter = 2 * (side1 + side2);
            Console.Write("Периметр: ");
            return perimeter;
        }
      

        static void Main(string[] args)
        {
            Console.Write("Введiть ширину прямокутника: ");
            double x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введiть довжину прямокутника: ");
            double y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Rectangle rectangle = new Rectangle(x, y);            
            Console.WriteLine(rectangle.PerimeterCalculator());           
            Console.WriteLine(rectangle.AreaCalculator());
            Console.ReadKey();
        }
    }
}
